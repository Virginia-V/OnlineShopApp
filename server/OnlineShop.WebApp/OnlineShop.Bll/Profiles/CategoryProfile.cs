using AutoMapper;
using OnlineShop.Common.Dtos.Categories;
using OnlineShop.Domain;

namespace OnlineShop.Bll.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();

        }
    }
}
