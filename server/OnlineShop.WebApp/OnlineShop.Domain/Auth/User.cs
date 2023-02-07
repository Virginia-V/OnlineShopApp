using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    /// <summary>
    ///  Gets or sets the DbSet<TEntity> of Users.
    /// </summary>
    public class User : IdentityUser<int>
    {
        public virtual Basket Basket { get; set; }
    }
}




