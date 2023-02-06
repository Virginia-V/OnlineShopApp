using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OnlineShop.API.Infrastructure;
using OnlineShop.API.Infrastructure.Configurations;
using OnlineShop.Common.Dtos;
using OnlineShop.Common.Dtos.Users;
using OnlineShop.Domain.Auth;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AuthOptions _authenticationOptions;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<User> userManager, RoleManager<Role> roleManager,
                                        SignInManager<User> signInManager, IOptions<AuthOptions> authOptions, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _authenticationOptions = authOptions.Value;
            _configuration = configuration;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<UserManagerResponse> Register([FromBody] RegisterModelDto model)
        {
            if (ModelState.IsValid)
            {
                var userCheck = await _userManager.FindByEmailAsync(model.Email);

                if (userCheck == null)
                {
                    var user = new User
                    {
                        Email = model.Email,
                        UserName = model.Email,
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        var resultRole = _roleManager.RoleExistsAsync("user").Result;
                        if (!resultRole)
                        {
                            var role = new Role("user");
                            var roleResult = _roleManager.CreateAsync(role).Result;
                            if (!roleResult.Succeeded)
                            {
                                return new UserManagerResponse
                                {
                                    Message = "Such User Already Exists"
                                };
                            }
                        }
                        await _userManager.AddToRoleAsync(user, "user");
                        await _signInManager.SignInAsync(user, false);
                        //var encodedToken = JwtService.GenerateJwt(user, _userManager, _authenticationOptions);
                        return await JwtService.GenerateJwt(user, _userManager, _authenticationOptions);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                            return new UserManagerResponse
                            {
                                Message = "Error"
                            };
                        }
                    }
                }
                return new UserManagerResponse
                {
                    Message = "User With Such Email Already Exist",
                    IsSucces = false
                };
            }

            return new UserManagerResponse
            {
                Message = "Successfully",
                IsSucces = true,
            };
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<UserManagerResponse> Login([FromBody] LoginModelDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return new UserManagerResponse
                {
                    IsSucces = false,
                    Message = "User with such email doesn't exist"
                };
            }
            var checkingPasswordResult = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (checkingPasswordResult.Succeeded)
            {
                return await JwtService.GenerateJwt(user, _userManager, _authenticationOptions);
            }

            return new UserManagerResponse
            {
                Message = "Incorect password"
            };
        }
        [HttpPost]
        [Authorize]
        [Route("logout")]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Ok("Successfully");
        }
    }
}
