using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Services.IServices;

public interface IPersonService
{
    //By default someone login is a user
    public Task<ObjectResult> Authenticate(PersonLoginRequest person, HttpContext httpContext);
}