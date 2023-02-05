using OnlineShop.Common.Dtos.Products;

namespace OnlineShop.Bll.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task CreateProductAsync(CreateProductDto dto);
        Task DeleteProductAsync(int id);
    }
}
