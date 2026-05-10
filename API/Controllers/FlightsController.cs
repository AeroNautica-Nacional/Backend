using AeroMexic.Application.Features.Fligth;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    public partial class FlightsController : ControllerBase
    {
        private ISender _mediator;

        public FlightsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetFlights()
        {
            var result = await _mediator.Send(new GetFlightsRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlightById(int id)
        {
            var result = await _mediator.Send(new GetFlightByIdRequest { Id = id });
            return Ok(result);
        }
    }
}
