using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Misc;
using Kamall_foods_server_aspNetCore.Data.Models.Requests;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers;

[ApiController]
[Route("Auth")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IUserService _userService;
    private readonly IPersonService _personService;
    private readonly IPersonRepository _personRepository;


    public AuthController(IUserRepository userRepository, IUserService userService, 
        IPersonService personService, IPersonRepository personRepository)
    {
        _userService = userService;
        _userRepository = userRepository;
        _personService = personService;
        _personRepository = personRepository;
    }

    private static ReadOnlyCollection<string> AuthorizedEmails =>
        new List<string> { "dyiemboiro@gmail.com" }.AsReadOnly();

    [AllowAnonymous]
    [HttpGet]
    [Route("test")]
    public ActionResult Test()
    {
        return Ok("it works");
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("loginOld")]
    public async Task<ActionResult> LoginUser(UserLoginRequest user)
    {
        var response = _userService.Authenticate(user);

        if (response.IsFaulted)
            return StatusCode(404, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        var isAdmin = AuthorizedEmails.Any(email => email.Equals(user.Email.ToLower()));
        if (isAdmin) response = _userService.Authenticate(user, Role.SuperAdmin);
        
        var securityTokenResult = await response;
        var securityToken = (SecurityToken)securityTokenResult.Value;

        var updatedUser = await _userRepository.Find(securityToken.RefreshToken.UserId);

        if (updatedUser.IsVerified == false)
            return StatusCode(400, new
            {
                Error = "This account is not verified yet, please check your mailbox"
            });

        updatedUser.UpdatedAt = DateTime.UtcNow;
        updatedUser.RefreshToken = securityToken.RefreshToken.Token;

        await _userRepository.Update(updatedUser.ID, updatedUser);

        Response.Cookies.Append("X-Access-Token", securityToken.AccessToken,
            new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true,
                Path = "/",
                Expires = DateTimeOffset.Now.AddDays(1),
                IsEssential = true
            });
        Response.Cookies.Append("X-Username", updatedUser.ID,
            new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true,
                Path = "/"
            });
        Response.Cookies.Append("X-Refresh-Token", securityToken.RefreshToken.Token,
            new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true,
                Path = "/",
                Expires = securityToken.RefreshToken.ExpiryDate
            });

        return Ok("Successfully authenticated");
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("login")]
    public async Task<ActionResult> Login(PersonLoginRequest person)
    {
        try
        {
            var response = _personService.Authenticate(person, HttpContext);
            var securityTokenResult = await response;
            var securityToken = (SecurityToken)securityTokenResult.Value;

            if (securityToken != null)
            {
                var updatedUser = await _personRepository.Find(securityToken.RefreshToken.UserId);

                if (updatedUser.IsVerified == false)
                    throw new Exception("This account is not verified yet, please check your mailbox");
                
                //Update when user logs in
                updatedUser.UpdatedAt = DateTime.UtcNow;
                updatedUser.RefreshToken = securityToken.RefreshToken.Token;
                await _personRepository.Update(updatedUser);

                var tokenNameList = new[] { "X-Access-Token", "X-Username", "X-Refresh-Token" };
                var cookieOption = new CookieOptions()
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                    Path = "/",
                };
                var cookies = Response.Cookies;

                foreach (var tokenName in tokenNameList)
                {
                    switch (tokenName)
                    {
                        case "X-Access-Token":
                            cookieOption.Expires = DateTimeOffset.Now.AddDays(1);
                            cookieOption.IsEssential = true;
                            
                            cookies.Append(tokenName, securityToken.AccessToken, cookieOption);
                            break;
                        case "X-Username":
                            cookies.Append(tokenName, updatedUser.ID, cookieOption);
                            break;
                        case "X-Refresh-Token":
                            cookieOption.Expires = securityToken.RefreshToken.ExpiryDate;
                            cookies.Append(tokenName, updatedUser.ID, cookieOption);
                            break;
                    }
                }
            }
            else
                throw new Exception("An error has occured !");
        }
        catch (Exception e)
        {
            return StatusCode(404, new ErrorMessage
            {
                Error = e.Message
            });
        }
        return Ok("Successfully authenticated");
    }

    [Authorize]
    [HttpPost]
    [Route("logout")]
    public ActionResult Logout()
    {
        var response = _userService.Logout(HttpContext);

        if (response.IsFaulted) return BadRequest("Unable to log out");

        return Ok("Logged out successfully");
    }
}