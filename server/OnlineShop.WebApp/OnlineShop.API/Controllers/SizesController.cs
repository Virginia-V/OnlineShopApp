using Microsoft.AspNetCore.Mvc;
using OnlineShop.Bll.Interfaces;

namespace OnlineShop.API.Controllers
{
    [Route("api/sizes")]
    public class SizesController : AppBaseController
    {
        private readonly ISizeService _sizeService;

        public SizesController(ISizeService sizeService, ILogger<SizesController> logger) : base(logger)
        {
            _sizeService = sizeService;
        }

        [HttpGet]
        public Task<IActionResult> GetSizesAsync()
        {
            return HandleAsync(() => _sizeService.GetSizesAsync());
        }
    }
}
