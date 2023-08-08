namespace Kamall_foods_server_aspNetCore.Data.Models;

public class RestaurantAdmin : Person.Person
{
    public string RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
}