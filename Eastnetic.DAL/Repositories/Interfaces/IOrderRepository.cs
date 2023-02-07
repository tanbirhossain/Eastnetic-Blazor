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
        public Task<List<Order>> GetOrders();
    }
}
