using AutoMapper;
using OnlineShop.Common.Dtos.Sizes;
using OnlineShop.Domain;

namespace OnlineShop.Bll.Profiles
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<Size, SizeDto>();
        }
    }
}
