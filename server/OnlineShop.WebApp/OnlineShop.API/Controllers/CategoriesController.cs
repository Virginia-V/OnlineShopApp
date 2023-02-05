using Microsoft.AspNetCore.Mvc;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common.Dtos.Categories;

namespace OnlineShop.API.Controllers
{
    [Route("api/categories")]
    public class CategoriesController : AppBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService, ILogger<CategoriesController> logger) : base(logger)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public Task<IActionResult> GetCategoriesAsync()
        {
            return HandleAsync(() => _categoryService.GetCategoriesAsync());
        }
    }
}
