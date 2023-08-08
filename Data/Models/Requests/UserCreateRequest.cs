namespace Kamall_foods_server_aspNetCore.Data.Models;

public class UserCreateRequest
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}