using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Services;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [HttpPost(Name = "CreateUserAsync")]
        [Route("create-user")]
        public async Task<string> CreateUserAsync(UserCreateInput userCreateInput)
        {
            return await Task.FromResult<string>("Test1");
        }

        [HttpPost(Name = "LoginUserAsync")]
        [Route("login-user")]
        public async Task<string> LoginUserAsync(UserLoginInput userLoginInput)
        {
            return await Task.FromResult<string>("Test1");
        }
    }
}
