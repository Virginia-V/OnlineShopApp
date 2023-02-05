using OnlineShop.Common.Dtos.Orders;

namespace OnlineShop.Bll.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetOrdersAsync();
        Task<OrderDto> GetOrderByIdAsync(int id);
        Task AddOrderAsync(CreateOrderDto dto);
        Task DeleteOrderAsync(int id);

    }
}
