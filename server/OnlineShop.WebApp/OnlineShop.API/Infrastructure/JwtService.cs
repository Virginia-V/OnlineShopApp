using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using OnlineShop.API.Infrastructure.Configurations;
using OnlineShop.Common.Dtos;
using OnlineShop.Domain.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace OnlineShop.API.Infrastructure
{
    public static class JwtService
    {
        public static async Task<UserManagerResponse> GenerateJwt(User user, UserManager<User> userManager, AuthOptions authOptions)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                };
            var userRoles = await userManager.GetRolesAsync(user);
            claims.AddRange(userRoles.Select(s => new Claim(ClaimTypes.Role, s)));
            var isAdmin = userRoles.Contains("admin");
            var signinCredentials = new SigningCredentials(authOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                 issuer: authOptions.Issuer,
                 audience: authOptions.Audience,
                 claims: claims,
                 expires: DateTime.Now.AddDays(30),
                 signingCredentials: signinCredentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();

            var encodedToken = tokenHandler.WriteToken(jwtSecurityToken);
            return new UserManagerResponse
            {
                IsSucces = true,
                ExpireDate = jwtSecurityToken.ValidTo,
                Token = encodedToken,
                IsAdmin = isAdmin
            };
        }
    }
}
