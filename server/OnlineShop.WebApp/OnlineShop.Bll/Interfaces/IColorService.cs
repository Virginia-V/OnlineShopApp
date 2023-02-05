using OnlineShop.Common.Dtos.Colors;

namespace OnlineShop.Bll.Interfaces
{
    public interface IColorService
    {
        Task<IEnumerable<ColorDto>> GetColorsAsync();
    }
}
