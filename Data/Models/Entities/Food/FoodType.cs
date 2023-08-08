using System.Runtime.Serialization;

namespace Kamall_foods_server_aspNetCore.Data.Models;

public class FoodType
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string ID { get; set; }

    public string Name { get; set; }
}