namespace Kamall_foods_server_aspNetCore.Data.Models;

public class RestaurantAdminCreateRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string RestaurantName { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
}