using System;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Context;
using Kamall_foods_server_aspNetCore.Data.Models.Person;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Kamall_foods_server_aspNetCore.Repository;

public class PersonRepository: IPersonRepository
{
    private readonly DatabaseContext _context;

    public PersonRepository(DbContextOptions<DatabaseContext> optionsBuilder)
    {
        _context = new DatabaseContext(optionsBuilder);
    }

    public async Task<Person> Find(string id)
    {
        try
        {
            return await _context.FindAsync<Person>(id);
        }
        catch (Exception e)
        {
            throw new Exception($"User not found : {id}");
        }
    }

    public async Task<Person> FindByEmail(string email)
    {
        try
        {
            return await _context.Persons.SingleAsync(u => u.Email == email);
        }
        catch (Exception e)
        {
            throw new Exception($"Email not found : {email}");
        }
    }

    public async Task Update(Person person)
    {
        try
        {
            _context.Update(person);
        }
        catch (Exception e)
        {
            throw new Exception($"Cannot update user. ID not found : {person.ID}");
        }

        await _context.SaveChangesAsync();
    }
}