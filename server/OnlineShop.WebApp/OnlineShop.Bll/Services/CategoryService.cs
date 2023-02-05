using AutoMapper;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common;
using OnlineShop.Common.Dtos.Categories;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Domain;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Bll.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            var records = await _categoryRepository.GetAllAsync();
            if (!records.Any())
            {
                throw new ValidationException(ErrorMessages.NoCategories);
            }
            return _mapper.Map<IEnumerable<CategoryDto>>(records);
        }
    }
}
