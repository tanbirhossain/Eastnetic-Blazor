using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Eastnetic.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            var result = await _orderRepository.GetOrders();
            var list = result.Select(x => new OrderDto()
            {
                 Id= x.Id,
                 Name= x.Name,
                 State= x.State
                  
            }).ToList();
            return list;
        }
    }
}
