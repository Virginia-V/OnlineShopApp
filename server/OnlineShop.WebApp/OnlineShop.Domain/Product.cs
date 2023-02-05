namespace OnlineShop.Domain
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public string ProductImage { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<BasketProduct> BasketProducts { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}
