namespace OnlineShop.Common.Dtos.Orders
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TotalOrderedAmount { get; set; }

    }
}
