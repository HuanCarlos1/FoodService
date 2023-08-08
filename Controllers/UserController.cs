using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.CacheSystem;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Response;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers;

[ApiController]
[Route("Users")]
public class UserController : ControllerBase
{
    private readonly ICacheSystem _cacheSystem;
    private readonly IEmailService _emailService;
    private readonly ITokenService _tokenService;
    private readonly IUserRepository _userRepository;
    private readonly IUserService _userService;

    public UserController(IUserRepository userRepository, IUserService userService, ICacheSystem cacheSystem,
        ITokenService tokenService, IEmailService emailService)
    {
        _userRepository = userRepository;
        _userService = userService;
        _cacheSystem = cacheSystem;
        _tokenService = tokenService;
        _emailService = emailService;
    }

    [Authorize]
    [HttpGet]
    [Route("current")]
    public async Task<ActionResult<UserInfoGetResponse>> GetAuthenticatedUser()
    {
        var id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = _userRepository.Find(id);

        if (response.IsFaulted)
            return StatusCode(404, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        var user = await response;
        var userGetResponse = new UserInfoGetResponse(user);
        return Ok(userGetResponse);
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("register")]
    public async Task<ActionResult> CreateUser(UserCreateRequest user)
    {
        var response = _userRepository.Create(user);

        if (response.IsFaulted)
            return StatusCode(404, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        try
        {
            var successMessage = await _userService.Register(user);
            var foundUser = await _userRepository.FindByEmail(user.Email);
            await _emailService.UserLinkValidationEmail(foundUser);
            //_roleManager.
            return StatusCode(201, successMessage);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("refresh")]
    public async Task<ActionResult> RefreshUser()
    {
        if (!(Request.Cookies.TryGetValue("X-Username", out var id) &&
              Request.Cookies.TryGetValue("X-Refresh-Token", out var refreshToken)))
            return BadRequest("Refresh token not found");

        var user = await _userRepository.Find(id);

        if (user == null || refreshToken != user?.RefreshToken)
            return BadRequest("Refresh token doesnt match");

        var token = _tokenService.GenerateJwt(user, user.Email);

        Response.Cookies.Append("X-Access-Token", token, new CookieOptions
        {
            HttpOnly = true,
            SameSite = SameSiteMode.None,
            Secure = true,
            Path = "/",
            Expires = DateTimeOffset.Now.AddDays(1),
            IsEssential = true
        });
        Response.Cookies.Append("X-Username", user.ID, new CookieOptions
        {
            HttpOnly = true,
            SameSite = SameSiteMode.None,
            Secure = true
        });

        return Ok();
    }

    [AllowAnonymous]
    [HttpPut]
    [Route("account_verification/email/{userId}/{token}")]
    public async Task<ActionResult> VerifyUser([FromRoute] string userId, [FromRoute] string token)
    {
        var response = _userRepository.Find(userId);

        if (response.IsFaulted)
            return StatusCode(404, new
            {
                Error = "Invalid confirmation link"
            });

        var user = await response;

        if (user.IsVerified) return Ok("Your email have been confirmed.");

        if (user.AccountValidationToken != token)
            return StatusCode(404, new
            {
                Error = "Invalid confirmation Email"
            });

        user.IsVerified = true;
        await _userRepository.Update(userId, user);
        return Ok("Your email have been confirmed.");
    }

    [Authorize(Roles = "SuperAdmin")]
    [HttpGet]
    public async Task<ActionResult> GetUsers()
    {
        var response = _userRepository.Get();

        if (response.IsFaulted)
            return StatusCode(404, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        var users = await response;

        return Ok(users);
    }

    [Authorize(Roles = "SuperAdmin")]
    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult> GetUser(string id)
    {
        var response = _userRepository.Find(id);

        if (response.IsFaulted)
            return StatusCode(404, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        var user = await response;
        return Ok(user);
    }

    [Authorize(Roles = "SuperAdmin")]
    [HttpPut]
    [Route("{id}")]
    public ActionResult UpdateUser(string id)
    {
        var response = _userRepository.Remove(id);

        if (response.IsFaulted)
            return StatusCode(409, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        return StatusCode(204, new { Message = $"User {id} updated successfully" });
    }

    [Authorize(Roles = "SuperAdmin")]
    [HttpDelete]
    [Route("{id}")]
    public ActionResult DeleteUser(string id)
    {
        var response = _userRepository.Remove(id);

        if (response.IsFaulted)
            return StatusCode(409, new ErrorMessage
            {
                Error = response.Exception?.Message
            });

        return StatusCode(204, new { Message = $"User {id} deleted successfully" });
    }
}