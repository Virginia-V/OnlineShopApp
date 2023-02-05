using Microsoft.AspNetCore.Mvc;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common.Dtos.Orders;

namespace OnlineShop.API.Controllers
{
    [Route("api/orders")]
    public class OrdersController : AppBaseController
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService, ILogger<OrdersController> logger) : base(logger)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public Task<IActionResult> GetOrdersAsync()
        {
            return HandleAsync(() => _orderService.GetOrdersAsync());
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetOrderAsync(int id)
        {
            return HandleAsync(() => _orderService.GetOrderByIdAsync(id));
        }

        [HttpPost]
        public Task<IActionResult> CreateOrderAsync([FromBody] CreateOrderDto orderDto)
        {
            return HandleAsync(() => _orderService.AddOrderAsync(orderDto));
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> DeleteOrderAsync(int id)
        {
            return HandleAsync(() => _orderService.DeleteOrderAsync(id));
        }
    }
}
