using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Common.Dtos.Products
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductSKU { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductDescription { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductImage { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public IList<ProductSizeDto> ProductSizes { get; set; }
        [Required]
        public IList<ProductColorDto> ProductColors { get; set; }

    }
}
