using Eastnetic.BLL.DTO;
using Eastnetic.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eastnetic.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
            var result = await _orderService.GetOrders();
            return Ok(result);
        }
        [HttpGet]
        [Route("DeleteOrderById")]
        public async Task<IActionResult> DeleteOrderById(long id)
        {
            var result = await _orderService.DeleteById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("SaveOrder")]
        public async Task<IActionResult> SaveOrder(OrderDto dto)
        {
            var result = await _orderService.SaveOrder(dto);
            return Ok(result);
        }
    }
}
