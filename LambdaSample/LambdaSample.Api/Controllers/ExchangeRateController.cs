using LambdaSample.Core.Models.Requests;
using LambdaSample.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaSample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly IDynamoService _dynamoService;

        public ExchangeRateController(IDynamoService dynamoService)
        {
            _dynamoService = dynamoService;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetRate([FromRoute] int id)
        {
            var result = await _dynamoService.GetAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRate([FromBody] ParentRequest request)
        {
            var result = await _dynamoService.CreateAsync(request);

            return Ok(result);
        }
    }
}
