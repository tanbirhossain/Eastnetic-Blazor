using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Eastnetic.DAL.Domain.Entities;
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
                Id = x.Id,
                Name = x.Name,
                State = x.State

            }).ToList();
            return list;
        }
        public async Task<OrderDto> SaveOrder(OrderDto dto)
        {
            var order = new Order
            {
                Id = dto.Id,
                Name = dto.Name,
                State = dto.State
            };
            var result = await _orderRepository.SaveOrder(order);
            return dto;
        }
        public async Task<bool> DeleteById(long id)
        {
            var result = await _orderRepository.DeleteById(id);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
