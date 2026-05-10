using AeroMexic.Application.DTOs;
using AeroMexic.Application.Services;
using MediatR;

namespace AeroMexic.Application.Features.Fligth
{
    public record GetFlightByIdRequest : IRequest<FlightDto>
    {
        public int Id { get; init; }
    }
    public class GetFlightById : IRequestHandler<GetFlightByIdRequest, FlightDto>
    {
        private readonly FligthService _service;

        public GetFlightById(FligthService service)
        {
            _service = service;
        }

        public Task<FlightDto> Handle(GetFlightByIdRequest request, CancellationToken cancellationToken)
        {
            return _service.GetFlightById(request.Id, cancellationToken);
        }
    }
}
