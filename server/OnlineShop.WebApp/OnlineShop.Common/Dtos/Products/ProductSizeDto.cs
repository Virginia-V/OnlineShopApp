using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Common.Dtos.Products
{
    public class ProductSizeDto
    {
        [Required]
        public int SizeId { get; set; }
    }
}
