namespace OnlineShop.Domain
{
    public class Color : BaseEntity
    {
        public string ProductColor { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
