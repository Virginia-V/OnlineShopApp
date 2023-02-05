using AutoMapper;
using OnlineShop.Common.Dtos.Colors;
using OnlineShop.Domain;

namespace OnlineShop.Bll.Profiles
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<Color, ColorDto>();
        }
    }
}
