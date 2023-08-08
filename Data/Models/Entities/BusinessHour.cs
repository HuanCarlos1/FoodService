using System;

namespace Kamall_foods_server_aspNetCore.Data.Models;

public class BusinessHour
{
    public string ID { get; set; }
    public DateTime OpeningHour { get; set; }
    public DateTime ClosingHour { get; set; }
    public string Day { get; set; }
}