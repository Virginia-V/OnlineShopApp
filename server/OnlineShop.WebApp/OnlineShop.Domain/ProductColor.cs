﻿namespace OnlineShop.Domain
{
    public class ProductColor
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
    }
}
