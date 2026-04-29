using AeroMexic.Application.DTOs;
using MediatR;

namespace AeroMexic.Application.Features.Flight.List
{
    public class ListFlightHandler : IRequestHandler<ListFlightQuery, FlightDto>
    {

        public ListFlightHandler()
        {
        }

        public Task<FlightDto> Handle(ListFlightQuery request, CancellationToken cancellationToken = default)
        {
            
        }
    }
}
