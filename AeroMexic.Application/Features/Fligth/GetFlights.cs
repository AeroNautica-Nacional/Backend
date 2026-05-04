using AeroMexic.Application.DTOs;
using AeroMexic.Application.Services;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace AeroMexic.Application.Features.Fligth
{
    public record GetFlightsRequest : IRequest<List<FlightDto>>;

    public class GetFlights : IRequestHandler<GetFlightsRequest, List<FlightDto>>
    {
        private readonly FligthService _service;
        private readonly ILogger<GetFlights> _logger;

        public GetFlights(FligthService service, ILogger<GetFlights> logger)
        {
            _service = service;
            _logger = logger;
        }

        public async Task<List<FlightDto>> Handle(GetFlightsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Fetching flight information");
                var flights = await _service.GetFlights();
                _logger.LogInformation($"Retrieved {flights.Count} flights");
                return flights;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching flights");
                throw;
            }
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
