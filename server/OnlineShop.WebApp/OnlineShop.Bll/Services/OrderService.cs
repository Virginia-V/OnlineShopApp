using AutoMapper;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common;
using OnlineShop.Common.Dtos.Orders;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Domain;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Bll.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IRepository<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderDto> GetOrderByIdAsync(int id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            var result = _mapper.Map<OrderDto>(order);
            return result;
        }

        public async Task<IEnumerable<OrderDto>> GetOrdersAsync()
        {
            var records = await _orderRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<OrderDto>>(records);
        }

        public async Task AddOrderAsync(CreateOrderDto dto)
        {
            if (dto.OrderedProducts.Select(x => x.ProductId).Count()
                != dto.OrderedProducts.Select(x => x.ProductId).Distinct().Count())
            {
                throw new ValidationException(ErrorMessages.SameProductError);
            }
            var order = _mapper.Map<Order>(dto);
            await _orderRepository.AddAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
            {
                throw new ValidationException(ErrorMessages.NoOrderForDelete);
            }
            await _orderRepository.DeleteAsync(order);
        }
    }
}


