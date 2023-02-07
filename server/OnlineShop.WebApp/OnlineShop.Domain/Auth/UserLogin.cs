using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    /// <summary>
    /// Gets or sets the DbSet<TEntity> of User logins.
    /// </summary>
    public class UserLogin : IdentityUserLogin<int>
    {

    }
}

/// <summary>
/// The user login identity table is a database table that is used 
/// to store information about user login identities in an application. 
/// The table is typically used by the authentication and authorization 
/// system to manage user accounts and track user authentication information, 
/// such as the user's username, password, and claims.
/// 
/// The structure of the user login identity table depends on the 
/// specific implementation of the ASP.NET Core Identity framework, 
/// but typically includes columns for the user's unique identifier, 
/// username, password, email address, and claims. Additional columns 
/// may be added to the table to store additional information about the 
/// user, such as their role, first name, last name, or any other relevant information.
/// </summary>
