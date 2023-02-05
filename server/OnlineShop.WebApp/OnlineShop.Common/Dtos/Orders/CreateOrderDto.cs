using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Common.Dtos.Orders
{
    public class CreateOrderDto
    {
        [Required]
        public decimal ShippingAmount { get; set; }
        [Required]
        public IList<OrderedProductDto> OrderedProducts { get; set; }

    }
}

