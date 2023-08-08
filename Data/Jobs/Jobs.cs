using System.Linq;
using Kamall_foods_server_aspNetCore.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Kamall_foods_server_aspNetCore.Data.Jobs;

public class Jobs : IJobs
{
    private readonly DatabaseContext _context;

    public Jobs(DbContextOptions<DatabaseContext> optionsBuilder)
    {
        _context = new DatabaseContext(optionsBuilder);
    }

    public void DeleteUnverifiedUsers()
    {
        var unverifiedUsers = _context.Users.Where(user => user.IsVerified == false);
        foreach (var user in unverifiedUsers) _context.Users.Remove(user);
        _context.SaveChanges();
    }
}