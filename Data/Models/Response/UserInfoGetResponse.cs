namespace Kamall_foods_server_aspNetCore.Data.Models.Response;

public class UserInfoGetResponse
{
    public UserInfoGetResponse(User user)
    {
        Firstname = user.Firstname;
        Lastname = user.Lastname;
        Email = user.Email;
        ProfilePicture = user.ProfilePicture;
        Username = user.Username;
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public byte[] ProfilePicture { get; set; }
    public string Username { get; set; }
}