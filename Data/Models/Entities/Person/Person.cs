using System;
using System.Runtime.Serialization;

namespace Kamall_foods_server_aspNetCore.Data.Models.Person;

public abstract class Person
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string ID { get; set; }

    [DataMember(Name = "firstname", EmitDefaultValue = false)]
    public string Firstname { get; set; }

    [DataMember(Name = "lastname", EmitDefaultValue = false)]
    public string Lastname { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }

    [DataMember(Name = "profilePicture", EmitDefaultValue = false)]
    public byte[] ProfilePicture { get; set; }

    [DataMember(Name = "username", EmitDefaultValue = false)]
    public string Username { get; set; }

    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }

    [DataMember(Name = "longiture", EmitDefaultValue = false)]
    public double Longitude { get; set; }

    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public double Latitude { get; set; }

    [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
    public string RefreshToken { get; set; }

    [DataMember(Name = "validation_token", EmitDefaultValue = false)]
    public string AccountValidationToken { get; set; }

    [DataMember(Name = "isVerified", EmitDefaultValue = false)]
    public bool IsVerified { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}