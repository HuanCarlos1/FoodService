using System.Collections.Generic;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;

namespace Kamall_foods_server_aspNetCore.Repository.IRepository;

public interface IRestaurantAdminRepository
{
    public Task Create(RestaurantAdminCreateRequest request);
    public Task CreationValidation(RestaurantAdminCreateRequest request);

    public Task<List<RestaurantAdmin>> Get();

    public Task<RestaurantAdmin> FindByEmail(string email);
    public Task<RestaurantAdmin> Find(string id);

    public Task Remove(string id);

    public Task Update(string id, RestaurantAdmin restaurantAdmin);
}