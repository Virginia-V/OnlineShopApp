using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Domain.Auth
{
    public class Role : IdentityRole<int>
    {
        public Role(string name) : base(name)
        {

        }
    }
}
