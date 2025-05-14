using Microsoft.AspNetCore.Mvc;
using api.Services;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LotController : ControllerBase
    {
        private readonly ILotService _lotService;

        public LotController(ILotService lotService)
        {
            _lotService = lotService;
        }

        [HttpGet(Name = "GetLotsPublicAsync")]
        [Route("get-lots-public")]
        public async Task<IActionResult> GetLotsPublicAsync()
        {
            var vm = await _lotService.GetLotsPublicAsync();
            return Ok(vm);
        }
    }
}
