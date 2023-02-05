namespace OnlineShop.Common.Dtos.Products
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }
        public string ProductImage { get; set; }
        public string Category { get; set; }

    }
}
