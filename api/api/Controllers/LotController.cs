using Microsoft.AspNetCore.Mvc;
using api.Services;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet(Name = "GetLotsCreatedAsync")]
        [Route("get-lots-created")]
        [Authorize]
        public async Task<IActionResult> GetLotsCreatedAsync()
        {
            var vm = await _lotService.GetLotsCreatedAsync();
            return Ok(vm);
        }

        [HttpGet(Name = "GetLotsBoughtAsync")]
        [Route("get-lots-bought")]
        [Authorize]
        public async Task<IActionResult> GetLotsBoughtAsync()
        {
            var vm = await _lotService.GetLotsBoughtAsync();
            return Ok(vm);
        }
    }
}
