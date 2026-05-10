using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClientsController : ControllerBase
    {
        private ISender _mediator;

        public ClientsController(ISender mediator)
        {
            _mediator = mediator;
        }
    }
}
