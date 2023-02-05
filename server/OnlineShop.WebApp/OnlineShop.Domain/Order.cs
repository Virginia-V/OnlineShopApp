using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Domain
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public decimal ShippingAmount { get; set; }
        [NotMapped]
        public decimal TotalOrderedAmount
        {
            get { return OrderedProducts.Select(x => x.Quantity * x.Product.ProductPrice).Sum() + ShippingAmount; }
            private set { TotalOrderedAmount = value; }
        }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}
