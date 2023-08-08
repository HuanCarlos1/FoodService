using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.Context;
using Kamall_foods_server_aspNetCore.Data.Models;

namespace Kamall_foods_server_aspNetCore.Repository.IRepository;

public class DeliveryPersonRepository : IDeliveryPersonRepository
{
    private readonly DatabaseContext _context;

    public DeliveryPersonRepository(DatabaseContext dbcontext)
    {
        _context = dbcontext;
    }

    public Task<DeliveryUser> Create(DeliveryUser newDeliveryUser)
    {
        throw new NotImplementedException();
    }

    public Task<DeliveryUser> Find(string ID)
    {
        throw new NotImplementedException();
    }

    public Task<List<DeliveryUser>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<Coordinate> GetPosition()
    {
        throw new NotImplementedException();
    }

    public Task Remove(string ID)
    {
        throw new NotImplementedException();
    }

    public Task Update(string ID, DeliveryUser newDeliveryUser)
    {
        throw new NotImplementedException();
    }
}