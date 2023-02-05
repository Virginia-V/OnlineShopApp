using OnlineShop.Domain.Auth;

namespace OnlineShop.Domain
{
    public class Basket : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BasketProduct> BasketProducts { get; set; }
    }
}
