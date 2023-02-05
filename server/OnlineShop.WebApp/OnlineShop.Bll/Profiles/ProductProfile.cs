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
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Category.CategoryName));
            CreateMap<CreateProductDto, Product>();
            CreateMap<ProductSizeDto, ProductSize>();
            CreateMap<ProductColorDto, ProductColor>();

        }
    }
}
