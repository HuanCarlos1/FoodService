using System.ComponentModel.DataAnnotations;

namespace Kamall_foods_server_aspNetCore.Data.Models.Requests;

public class PersonLoginRequest
{
    [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }
    [Required] public Role Role { get; set; } = Role.User;
}