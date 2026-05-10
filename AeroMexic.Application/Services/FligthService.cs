
using AeroMexic.Application.DTOs;
using AeroMexic.Domain.Entities;

namespace AeroMexic.Application.Services
{
    public class FligthService
    {
        public Task<List<FlightDto>> GetFlights()
        {
            var flights = new List<Flight>();
            var result = flights.Select(f => new FlightDto
            {
                Id = f.Id,
                CodeFlight = f.CodeFlight,
                OriginAirportId = f.OriginAirportId,
                DestinationAirportId = f.DestinationAirportId,
                ScheduledDepartureDate = f.ScheduledDepartureDate,
                ActualDepartureDate = f.ActualDepartureDate,
                ScheduledArrivalDate = f.ScheduledArrivalDate,
                ActualArrivalDate = f.ActualArrivalDate,
                AircraftId = f.AircraftId,
                FlightStatusId = f.FlightStatusId,
                LastFlightPositionId = f.LastFlightPositionId
            }).ToList();

            return Task.FromResult(result);
        }

        public Task<FlightDto> GetFlightById(int id, CancellationToken cancellationToken)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero.");
            }

            var flight = new Flight();

            var result = new FlightDto
            {
                Id = id,
                CodeFlight = flight.CodeFlight,
                OriginAirportId = flight.OriginAirportId,
                DestinationAirportId = flight.DestinationAirportId,
                ScheduledDepartureDate = flight.ScheduledDepartureDate,
                ActualDepartureDate = flight.ActualDepartureDate,
                ScheduledArrivalDate = flight.ScheduledArrivalDate,
                ActualArrivalDate = flight.ActualArrivalDate,
                AircraftId = flight.AircraftId,
                FlightStatusId = flight.FlightStatusId,
                LastFlightPositionId = flight.LastFlightPositionId
            };

            return Task.FromResult(result);
        }
    }
}
