using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Common.Dtos.Users
{
    public class LoginModelDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool RememberMe { get; set; }
    }
}
