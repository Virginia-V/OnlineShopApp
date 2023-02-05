using AutoMapper;
using OnlineShop.Common.Dtos.Orders;
using OnlineShop.Domain;

namespace OnlineShop.Bll.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<CreateOrderDto, Order>();
            CreateMap<OrderedProductDto, OrderedProduct>();
        }
    }
}
