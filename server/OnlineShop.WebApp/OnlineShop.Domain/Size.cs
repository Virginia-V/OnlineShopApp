namespace OnlineShop.Domain
{
    public class Size : BaseEntity
    {
        public string ProductSize { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
