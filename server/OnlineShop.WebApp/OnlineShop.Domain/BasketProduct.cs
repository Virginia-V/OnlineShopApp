﻿namespace OnlineShop.Domain
{
    public class BasketProduct
    {
        public int BasketId { get; set; }
        public virtual Basket Basket { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
