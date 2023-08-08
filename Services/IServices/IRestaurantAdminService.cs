using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;

namespace Kamall_foods_server_aspNetCore.Services.IServices;

public interface IRestaurantAdminService
{
    public Task SendRegisteringRequestEmail(RestaurantAdminCreateRequest restaurantAdmin);
    public Task Approve(string id);
    public Task DisapproveAndDelete(string id);
}