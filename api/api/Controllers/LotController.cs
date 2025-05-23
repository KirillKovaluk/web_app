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

        [HttpPost(Name = "GetLotsPublicAsync")]
        [Route("get-lots-public")]
        public async Task<IActionResult> GetLotsPublicAsync(LotQueryInput lotQueryInput)
        {
            var vm = await _lotService.GetLotsPublicAsync(lotQueryInput);
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

        [HttpPost(Name = "CreateLotAsync")]
        [Route("create-lot")]
        [Authorize]
        public async Task<IActionResult> CreateLotAsync([FromForm] LotCreateInput lotCreateInput)
        {
            await _lotService.CreateLotAsync(lotCreateInput);
            return Ok();
        }

        [HttpPost(Name = "BetLotAsync")]
        [Route("bet-lot")]
        [Authorize]
        public async Task<IActionResult> BetLotAsync(LotBetInput lotBetInput)
        {
            await _lotService.BetLotAsync(lotBetInput);
            return Ok();
        }
    }
}
