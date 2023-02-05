using Microsoft.AspNetCore.Mvc;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common.Dtos.Products;

namespace OnlineShop.API.Controllers
{
    [Route("api/products")]
    public class ProductsController : AppBaseController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService, ILogger<ProductsController> logger) : base(logger)
        {
            _productService = productService;
        }

        [HttpGet]
        public Task<IActionResult> GetProductsAsync()
        {
            return HandleAsync(() => _productService.GetProductsAsync());
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetProductAsync(int id)
        {
            return HandleAsync(() => _productService.GetProductByIdAsync(id));
        }

        [HttpPost]
        public Task<IActionResult> CreateProductAsync([FromBody] CreateProductDto productDto)
        {
            return HandleAsync(() => _productService.CreateProductAsync(productDto));
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> DeleteProductAsync(int id)
        {
            return HandleAsync(() => _productService.DeleteProductAsync(id));
        }
    }
}
