using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    /// <summary>
    /// Gets or sets the DbSet<TEntity> of User roles.
    /// </summary>
    public class UserRole : IdentityUserRole<int>
    {
    }
}
