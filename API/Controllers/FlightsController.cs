using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    public partial class FlightsController
    {
        private ISender _mediator;

        public FlightsController(ISender mediator)
        {
            _mediator = mediator;
        }
    }
}
