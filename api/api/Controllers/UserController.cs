using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [HttpGet(Name = "GetTestAsync")]
        [Route("get-test")]
        public async Task<string> GetTestAsync()
        {
            return await Task.FromResult<string>("Test");
        }
    }
}
