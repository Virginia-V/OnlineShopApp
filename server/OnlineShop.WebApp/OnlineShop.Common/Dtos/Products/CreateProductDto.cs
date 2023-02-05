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
        public int SizeId { get; set; }
        [Required]
        public int ColorId { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductImage { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
