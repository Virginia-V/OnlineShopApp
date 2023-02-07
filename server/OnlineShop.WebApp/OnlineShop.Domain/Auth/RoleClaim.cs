using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    /// <summary>
    ///  Gets or sets the DbSet<TEntity> of role claims.
    /// </summary>
    public class RoleClaim : IdentityRoleClaim<int>
    {
    }
}

/// <summary>
/// Role claims are a type of user claim in ASP.NET Core Identity that are used 
/// to represent a user's role in an application. Role claims are used to store 
/// information about the user's role, such as "Admin", "Moderator", "User", etc. 
/// Role claims can be used in authorization scenarios to make decisions about 
/// what the user is allowed to do in the application.
/// </summary>