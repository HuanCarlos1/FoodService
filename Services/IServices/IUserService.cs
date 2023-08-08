using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Services.IServices;

public interface IUserService
{
    public Task<ObjectResult> Authenticate(UserLoginRequest user, Role role = Role.User);
    public Task Logout(HttpContext httpContext);
    public Task<object> Register(UserCreateRequest user);
    public bool PasswordIsValid(User userAuth, string password);
}