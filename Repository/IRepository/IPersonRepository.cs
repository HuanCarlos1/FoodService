using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models.Person;

namespace Kamall_foods_server_aspNetCore.Repository.IRepository;

public interface IPersonRepository
{
    public Task<Person> Find(string id);
    public Task<Person> FindByEmail(string email);
    public Task Update(Person person);
}