using LambdaSample.Middleware.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaSample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TkambioController : ControllerBase
    {
        private readonly ITkambioService tkambioService;

        public TkambioController(ITkambioService _tkambioService)
        {
            tkambioService = _tkambioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetExchangeRate()
        {
            var result = await tkambioService.GetExchangeRate();

            return Ok(result);
        }
    }
}
