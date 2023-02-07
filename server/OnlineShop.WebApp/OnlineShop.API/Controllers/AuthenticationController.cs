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
        /// <summary>
        /// [AllowAnonymous] => it means that even unauthenticated users can access that action.
        /// </summary>
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModelDto model)
        {
            if (ModelState.IsValid)
            {
                var user_exist = await _userManager.FindByEmailAsync(model.Email);

                if (user_exist == null)
                {
                    var user = new User
                    {
                        Email = model.Email,
                        UserName = model.Email,
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        var resultRole = await _roleManager.RoleExistsAsync("user");
                        if (!resultRole)
                        {
                            var role = new Role("user");
                            var roleResult = await _roleManager.CreateAsync(role);
                            if (!roleResult.Succeeded)
                            {
                                return BadRequest(new UserManagerResponse()
                                {
                                    IsSucces = false,
                                    Errors = new List<string>()
                                         {
                                           "User with such role already exists."
                                         }
                                });
                            }
                        }
                        await _userManager.AddToRoleAsync(user, "user");
                        await _signInManager.SignInAsync(user, false);
                        var encodedToken = await JwtService.GenerateJwt(user, _userManager, _authenticationOptions);
                        return Ok(encodedToken);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                            return BadRequest(new UserManagerResponse()
                            {
                                IsSucces = false,
                                Errors = new List<string>()
                                    {
                                      "Error."
                                    }
                            });
                        }
                    }
                }
                return BadRequest(new UserManagerResponse()
                {
                    IsSucces = false,
                    Errors = new List<string>()
                        {
                            "This email is already associated with an account."
                        }
                });
            }
            return BadRequest();
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModelDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest(new UserManagerResponse()
                {
                    IsSucces = false,
                    Errors = new List<string>()
                        {
                           "User with such email doesn't exist"
                        }
                });
            }
            var checkingPasswordResult = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (checkingPasswordResult.Succeeded)
            {
                var encodedToken = await JwtService.GenerateJwt(user, _userManager, _authenticationOptions);
                return Ok(encodedToken);
            }

            return BadRequest(new UserManagerResponse()
            {
                IsSucces = false,
                Errors = new List<string>()
                    {
                       "Incorrect password"
                    }
            });
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

/// <summary>
///  The UserManager class is responsible for managing user accounts and authentication information 
///  in an application. The UserManager class provides a convenient and flexible API for performing 
///  common user management tasks, such as creating and updating user accounts, assigning roles, and 
///  resetting passwords.
///  The UserManager class is typically used in the application's code to perform user management 
///  operations, such as creating a new user account, retrieving an existing user, or updating a 
///  user's information. 
/// </summary>


/// <summary>
///  The RoleManager class is responsible for managing role-based authorization in an application. 
///  The RoleManager class provides a convenient and flexible API for performing common role management tasks, 
///  such as creating and updating roles, assigning roles to users, and checking if a user is in a specific role.
///  The RoleManager class is typically used in the application's code to perform role management operations, 
///  such as creating a new role, retrieving a list of roles, or checking if a user is in a specific role. 
/// </summary>


/// <summary>
///  The SignInManager class is a component of the ASP.NET Core Identity framework. It is responsible 
///  for managing the sign-in process for users in an application. The SignInManager class provides a 
///  convenient and flexible API for performing common sign-in tasks, such as signing in a user, signing 
///  out a user, and checking if a user is signed in.
/// </summary>