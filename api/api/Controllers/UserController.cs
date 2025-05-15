using Microsoft.AspNetCore.Mvc;
using api.Services;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost(Name = "CreateUserAsync")]
        [Route("create-user")]
        public async Task<IActionResult> CreateUserAsync(UserCreateInput userCreateInput)
        {
            await _userService.CreateUserAsync(userCreateInput);
            return Ok();
        }

        [HttpPost(Name = "LoginUserAsync")]
        [Route("login-user")]
        public async Task<IActionResult> LoginUserAsync(UserLoginInput userLoginInput)
        {
            var vm = await _userService.LoginUserAsync(userLoginInput);
            return Ok(vm);
        }

        [HttpGet(Name = "GetUserAsync")]
        [Route("get-user")]
        [Authorize]
        public async Task<IActionResult> GetUserAsync()
        {
            var vm = await _userService.GetUserAsync();
            return Ok(vm);
        }
    }
}
