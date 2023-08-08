using System.ComponentModel.DataAnnotations.Schema;

namespace Kamall_foods_server_aspNetCore.Data.Models;

[Table("DeliveryUsers")]
public class DeliveryUser : Person.Person
{
    public int ratings { get; set; }
}