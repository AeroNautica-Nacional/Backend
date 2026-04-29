using AeroMexic.Application.DTOs;
using MediatR;

namespace AeroMexic.Application.Features.Flight.List
{
    public class ListFlightQuery : IRequest<FlightDto>
    {
    }
}
