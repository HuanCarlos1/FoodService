namespace Kamall_foods_server_aspNetCore.Data.Models.Misc;

public class SecurityToken
{
    public string AccessToken { get; set; }
    public bool Succes { get; set; }
    public RefreshToken RefreshToken { get; set; }
    public string Email { get; set; }
}