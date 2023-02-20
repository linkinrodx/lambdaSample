using AutoMapper;
using LambdaSample.Core.Models;
using LambdaSample.Core.Models.Requests;
using LambdaSample.Core.Models.Responses;
using LambdaSample.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaSample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly IDynamoService _dynamoService;
        private readonly IMapper _mapper;

        public ExchangeRateController(IDynamoService dynamoService, IMapper mapper)
        {
            _dynamoService = dynamoService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetRate([FromRoute] Guid id)
        {
            var result = await _dynamoService.GetAsync(id);

            if (result is null)
            {
                return NotFound();
            }

            var response = _mapper.Map<ParentResponse>(result);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRate([FromBody] ParentRequest request)
        {
            var parent = _mapper.Map<Parent>(request);
            parent.Id = Guid.NewGuid().ToString();

            var result = await _dynamoService.CreateAsync(parent);

            return Ok(result);
        }
    }
}
