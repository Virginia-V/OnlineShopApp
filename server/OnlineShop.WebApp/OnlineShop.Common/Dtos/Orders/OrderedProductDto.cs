﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Common.Dtos.Orders
{
    public class OrderedProductDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
