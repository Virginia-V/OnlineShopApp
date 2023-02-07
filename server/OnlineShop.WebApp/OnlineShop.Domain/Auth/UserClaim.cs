using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    /// <summary>
    ///  Gets or sets the DbSet<TEntity> of User claims.
    /// </summary>
    public class UserClaim : IdentityUserClaim<int>
    {

    }
}

/// <summary>
///  User claims are a way of representing information about a user in the form of a key-value pair. 
///  They are used in authentication and authorization scenarios to store additional information about 
///  the user that can be used to make decisions in an application. 
///  In the context of ASP.NET Core Identity, 
///  claims can be associated with a user account and can be used to store information such 
///  as the user's name, email address, role, or any other custom information that 
///  may be relevant to the application. Claims are stored in the user's security 
///  token and can be accessed by the application during the authentication and 
///  authorization process to make decisions about what the user is allowed to do.
///  
/// For example, you may have a driver's license, issued by a local driving license authority. 
/// Your driver's license has your date of birth on it. In this case the claim name would be 
/// DateOfBirth, the claim value would be your date of birth, for example 8th June 1970 
/// and the issuer would be the driving license authority. 
/// 
/// Claims requirements are policy based, the developer must build and register a policy 
/// expressing the claims requirements.
/// </summary>