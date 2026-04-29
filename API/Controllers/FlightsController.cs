using AeroMexic.Application.DTOs;
using API.Models.FlightModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    public partial class FlightsController
    {
        private ISender _mediator = null!;

        public FlightsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("list")]
        public async Task<FlightDto> GetFlightList(CancellationToken token)
        {
            return await _mediator.Send(new ListFlightModel { Items = FlightDto }, token);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ListFlightModel> GetFlightById([FromBody] int id, CancellationToken token)
        {
            return await _mediator.Send(new FlightDto { Item = id }, token);
        }
    }
}
