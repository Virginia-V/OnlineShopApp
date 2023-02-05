using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    public class User : IdentityUser<int>
    {
        public virtual Basket Basket { get; set; }
    }
}
