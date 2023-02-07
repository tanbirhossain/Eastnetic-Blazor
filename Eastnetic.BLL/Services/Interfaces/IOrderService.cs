using Eastnetic.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.BLL.Services.Interfaces
{
    public interface IOrderService
    {
        public Task<List<OrderDto>> GetOrders();
    }
}
