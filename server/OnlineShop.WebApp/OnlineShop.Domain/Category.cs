namespace OnlineShop.Domain
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
