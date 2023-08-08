using System.Collections.Generic;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;

namespace Kamall_foods_server_aspNetCore.Repository.IRepository;

public interface IUserRepository
{
    public Task<List<User>> Get();
    public Task<User> Find(string ID);
    public Task<User> FindByEmail(string email);
    public Task Create(UserCreateRequest newUser);
    public Task CreationVerification(UserCreateRequest user);
    public Task Update(string ID, User newUser);
    public Task Remove(string ID);
}