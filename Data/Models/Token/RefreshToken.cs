using System;

namespace Kamall_foods_server_aspNetCore.Data.Models.Misc;

public class RefreshToken
{
    public bool IsUsed { get; set; }
    public bool IsRevorked { get; set; }
    public string UserId { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Token { get; set; }
}