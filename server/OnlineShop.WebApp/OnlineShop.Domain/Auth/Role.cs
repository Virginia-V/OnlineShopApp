using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    /// <summary>
    ///  Gets or sets the DbSet<TEntity> of roles.
    /// </summary>
    public class Role : IdentityRole<int>
    {
        public Role(string name) : base(name)
        {

        }
    }
}

