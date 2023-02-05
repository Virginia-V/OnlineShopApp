using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Common.Dtos.Products
{
    public class ProductColorDto
    {
        [Required]
        public int ColorId { get; set; }
    }
}
