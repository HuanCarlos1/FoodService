using System;

namespace Kamall_foods_server_aspNetCore.Data.Models;

public class Food
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string price { get; set; }
    public byte[] ProfilePicture { get; set; }
    public FoodType Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}