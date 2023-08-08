using System;
using System.Collections.Generic;
using Kamall_foods_server_aspNetCore.Data.Models.Entities.Restaurant;

namespace Kamall_foods_server_aspNetCore.Data.Models;

public class Restaurant
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public byte[] ProfilePicture { get; set; }
    public ICollection<Food> Foods { get; set; }
    public ICollection<RestaurantType> Types { get; set; }
    public ICollection<BusinessHour> OpeningHours { get; set; }
    public RestaurantAdmin Owner { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}