using Eastnetic.DAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> DeleteById(long id);
        Task<List<Order>> GetOrders();
        Task<Order> SaveOrder(Order order);
    }
}
