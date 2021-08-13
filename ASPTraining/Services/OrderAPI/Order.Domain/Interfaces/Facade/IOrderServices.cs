using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Facade
{
    public interface IOrderServices
    {
        Task<List<Entities.OrderEntity>> GetAllOrders();
        Task<Guid> Add(Entities.OrderEntity order);
        Task<List<Entities.OrderEntity>> GetByUser(string user);
        Task<Entities.OrderEntity> GetOrder(Guid id);
        Task UpdateOrder(Entities.OrderEntity order);
    }
}
