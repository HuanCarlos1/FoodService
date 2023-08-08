using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Context;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Security;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kamall_foods_server_aspNetCore.Services;

public class UserService : IUserService
{
    private static DatabaseContext _context;
    private readonly ITokenService _tokenService;

    public UserService(DbContextOptions<DatabaseContext> _optionsBuilder, ITokenService tokenService)
    {
        _context = new DatabaseContext(_optionsBuilder);
        _tokenService = tokenService;
    }

    public async Task<ObjectResult> Authenticate(UserLoginRequest user, Role role = Role.User)
    {
        var token = _tokenService.Create(user.Email, user.Password, role);
        return await token;
    }

    public Task Logout(HttpContext httpContext)
    {
        foreach (var cookie in httpContext.Request.Cookies)
            if (new List<string> { "X-Refresh-Token", "X-Username", "X-Access-Token" }.Any(c => c.Equals(cookie.Key)))
                httpContext.Response.Cookies.Delete(cookie.Key, new CookieOptions
                {
                    Secure = true,
                    SameSite = SameSiteMode.None
                });
        return Task.CompletedTask;
    }

    public async Task<object> Register(UserCreateRequest user)
    {
        return await Task.Run(() => new
        {
            Message = "Your account was created successfully"
        });
    }

    public bool PasswordIsValid(User userAuth, string password)
    {
        return UserSecurity.VerifyHashedPassword(userAuth.Password, password);
    }
}