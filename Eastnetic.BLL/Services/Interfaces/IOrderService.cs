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
        Task<bool> DeleteById(long id);
        public Task<List<OrderDto>> GetOrders();
        Task<OrderDto> SaveOrder(OrderDto dto);
    }
}
