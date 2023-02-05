using OnlineShop.Common.Dtos.Categories;

namespace OnlineShop.Bll.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
    }
}
