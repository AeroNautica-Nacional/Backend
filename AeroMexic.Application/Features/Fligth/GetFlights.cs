using AeroMexic.Application.DTOs;
using AeroMexic.Application.Services;
using FluentValidation;
using MediatR;

namespace AeroMexic.Application.Features.Fligth
{
    public record GetFlightsRequest : IRequest<List<FlightDto>>;

    public class GetFlights : IRequestHandler<GetFlightsRequest, List<FlightDto>>
    {
        private readonly FligthService _service;

        public GetFlights(FligthService service)
        {
            _service = service;
        }

        public async Task<List<FlightDto>> Handle(GetFlightsRequest request, CancellationToken cancellationToken)
        {
            return await _service.GetFlights();
        }
    }

    public class FlightValidator : AbstractValidator<GetFlightsRequest>
    {
        public FlightValidator()
        {
            RuleFor(x => x).NotNull().WithMessage("Request cannot be null");
        }
    }
}
