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

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext _context;

    public UserRepository(DbContextOptions<DatabaseContext> optionsBuilder)
    {
        _context = new DatabaseContext(optionsBuilder);
    }

    public async Task<List<User>> Get()
    {
        var response = _context.Users.ToListAsync();

        if (response.IsFaulted)
            throw new Exception("Something unexpected has occured. Try later.");

        return await response;
    }

    public async Task Create(UserCreateRequest newUser)
    {
        var user = new User
        {
            ID = Guid.NewGuid().ToString(),
            Firstname = newUser.Firstname,
            Lastname = newUser.Lastname,
            Email = newUser.Email,
            Password = UserSecurity.HashPassword(newUser.Password),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            IsVerified = false,
            AccountValidationToken = string.Concat(Guid.NewGuid().ToString("N").Select(c => (char)(c + 17)))
        };

        if (_context.Users.Any(u => u.Email == newUser.Email))
            throw new Exception("Cannot create account. Email already Exists.");

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public Task CreationVerification(UserCreateRequest user)
    {
        throw new NotImplementedException();
    }

    public async Task<User> Find(string ID)
    {
        var user = await _context.FindAsync<User>(ID);

        if (user == null)
            throw new Exception($"User not found : {ID}");

        return user;
    }

    public async Task<User> FindByEmail(string email)
    {
        var user = await _context.Users.SingleAsync(u => u.Email == email);

        if (user == null) throw new Exception($"Email not found : {email}");

        return user;
    }

    public async Task Remove(string ID)
    {
        var user = await _context.FindAsync<User>(ID);

        if (user == null) throw new Exception($"Cannot delete user. ID not found : {ID}");

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task Update(string ID, User newUser)
    {
        var result = await _context.Users.SingleOrDefaultAsync(b => b.ID == ID);

        if (result != null)
            result = newUser;
        else
            throw new Exception($"Cannot update user. ID not found : {ID}");

        await _context.SaveChangesAsync();
    }
}