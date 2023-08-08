using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Context;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Security;
using Microsoft.EntityFrameworkCore;

namespace Kamall_foods_server_aspNetCore.Repository;

public class RestaurantAdminRepository : IRestaurantAdminRepository
{
    private readonly DatabaseContext _context;

    public RestaurantAdminRepository(DbContextOptions<DatabaseContext> optionsBuilder)
    {
        _context = new DatabaseContext(optionsBuilder);
    }

    public async Task Create(RestaurantAdminCreateRequest request)
    {
        var restaurantAdmin = new RestaurantAdmin
        {
            ID = Guid.NewGuid().ToString(),
            Firstname = request.Firstname,
            Lastname = request.Lastname,
            Email = request.Email,
            Password = UserSecurity.HashPassword(request.Password),
            PhoneNumber = request.PhoneNumber
        };

        if (_context.RestaurantAdmins.Any(u => u.Email == restaurantAdmin.Email))
            throw new Exception("Cannot create account. Email already Exists.");

        await _context.RestaurantAdmins.AddAsync(restaurantAdmin);
        await _context.SaveChangesAsync();
    }

    public Task CreationValidation(RestaurantAdminCreateRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<List<RestaurantAdmin>> Get()
    {
        var response = _context.RestaurantAdmins.ToListAsync();

        if (response.IsFaulted)
            throw new Exception("Something unexpected has occured. Try later.");

        return await response;
    }

    public async Task<RestaurantAdmin> FindByEmail(string email)
    {
        var restaurantAdmin = await _context.RestaurantAdmins.SingleAsync(u => u.Email == email);

        if (restaurantAdmin == null) throw new Exception($"Email not found : {email}");

        return restaurantAdmin;
    }

    public async Task<RestaurantAdmin> Find(string id)
    {
        var restaurantAdmin = await _context.RestaurantAdmins.SingleAsync(u => u.ID == id);

        if (restaurantAdmin == null) throw new Exception($"User not found : {id}");

        return restaurantAdmin;
    }

    // Will probably have to delete Admin in the RestaurantAdmin and Persons Tables
    public async Task Remove(string id)
    {
        var restaurantAdmin = await _context.FindAsync<RestaurantAdmin>(id);

        if (restaurantAdmin == null) throw new Exception($"Cannot delete user. ID not found : {id}");

        _context.RestaurantAdmins.Remove(restaurantAdmin);
        await _context.SaveChangesAsync();
    }

    public async Task Update(string id, RestaurantAdmin restaurantAdmin)
    {
        var restaurantAdminOld = await _context.RestaurantAdmins.SingleOrDefaultAsync(u => u.ID == id);

        if (restaurantAdminOld != null)
            restaurantAdminOld = restaurantAdmin;
        else
            throw new Exception($"Cannot update user. ID not found : {id}");

        await _context.SaveChangesAsync();
    }
}