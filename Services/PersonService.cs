using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Requests;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Services;

public class PersonService: IPersonService
{
    private readonly ITokenService _tokenService;
    private static ReadOnlyCollection<string> AuthorizedEmails =>
        new List<string> { "dyiemboiro@gmail.com" }.AsReadOnly();

    public PersonService(ITokenService tokenService)
    {
        _tokenService = tokenService;
    }

    public async Task<ObjectResult> Authenticate(PersonLoginRequest person, HttpContext httpContext)
    {
        Task<ObjectResult> token = null;
        
        switch (person.Role)
        {
            case Role.User:
                token = _tokenService.Create(person.Email, person.Password, person.Role);
                break;
            case Role.RestaurantAdmin:
                token = _tokenService.Create(person.Email, person.Password, Role.RestaurantAdmin);
                break;
            case Role.SuperAdmin:
                var isAdmin = AuthorizedEmails.Any(email => email.Equals(person.Email.ToLower()));
                if (isAdmin) token = _tokenService.Create(person.Email, person.Password, Role.SuperAdmin);
                break;
            case Role.DeliveryMan:
                token = _tokenService.Create(person.Email, person.Password, Role.DeliveryMan);
                break;
            default:
                throw new Exception("Role not found.");
        }

        if (token == null) throw new Exception("Cannot Log in, an error has occured !");
        return await token;
    }
}