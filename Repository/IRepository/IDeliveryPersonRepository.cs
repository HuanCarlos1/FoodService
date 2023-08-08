using System.Collections.Generic;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Models;

namespace Kamall_foods_server_aspNetCore.Repository.IRepository;

internal interface IDeliveryPersonRepository
{
    public Task<List<DeliveryUser>> Get();
    public Task<DeliveryUser> Find(string ID);
    public Task<DeliveryUser> Create(DeliveryUser newDeliveryUser);
    public Task Update(string ID, DeliveryUser newDeliveryUser);
    public Task Remove(string ID);

    public Task<Coordinate> GetPosition();
}