using System.ComponentModel.DataAnnotations;

namespace Kamall_foods_server_aspNetCore.Data.Models;

public class UserLoginRequest
{
    [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }
}