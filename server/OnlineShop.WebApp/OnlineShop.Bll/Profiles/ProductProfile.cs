using AutoMapper;
using OnlineShop.Common.Dtos.Products;
using OnlineShop.Domain;

namespace OnlineShop.Bll.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Category.CategoryName))
                .ForMember(x => x.ProductColor, y => y.MapFrom(z => z.Color.ProductColor))
                .ForMember(x => x.ProductSize, y => y.MapFrom(z => z.Size.ProductSize));
            CreateMap<CreateProductDto, Product>();

        }
    }
}
