using OnlineShop.Common.Dtos.Sizes;

namespace OnlineShop.Bll.Interfaces
{
    public interface ISizeService
    {
        Task<IEnumerable<SizeDto>> GetSizesAsync();
    }
}
