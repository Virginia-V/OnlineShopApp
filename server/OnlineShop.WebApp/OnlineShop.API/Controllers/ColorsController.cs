using Microsoft.AspNetCore.Mvc;
using OnlineShop.Bll.Interfaces;

namespace OnlineShop.API.Controllers
{
    [Route("api/colors")]
    public class ColorsController : AppBaseController
    {
        private readonly IColorService _colorService;

        public ColorsController(IColorService colorService, ILogger<ColorsController> logger) : base(logger)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public Task<IActionResult> GetColorsAsync()
        {
            return HandleAsync(() => _colorService.GetColorsAsync());
        }
    }
}
