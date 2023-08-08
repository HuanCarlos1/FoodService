using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Claims;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Response;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers;

[ApiController]
[Authorize(Roles = "SuperAdmin")]
[Route("Admins")]
public class AdminController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IUserService _userService;

    public AdminController(IUserRepository userRepository, IUserService userService)
    {
        _userRepository = userRepository;
        _userService = userService;
    }

    private static ReadOnlyCollection<string> AuthorizedEmails =>
        new List<string> { "dyiemboiro@gmail.com" }.AsReadOnly();

    [HttpGet]
    [Route("current")]
    public async Task<ActionResult> GetAuthenticatedAdmin()
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
}