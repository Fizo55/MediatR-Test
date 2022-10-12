using MediatR.Modules.Sample.Modules.Random.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Modules.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RandomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Index")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _mediator.Send(new RandomCommand()));
        }
    }
}
