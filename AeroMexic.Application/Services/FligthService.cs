
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
                FlightNumber = f.FlightNumber,
                Aircarft = f.Aircarft,
                Origin = f.Origin,
                Destination = f.Destination,
                DepartureTime = f.DepartureTime,
                ArrivalTime = f.ArrivalTime,
                Status = f.Status,
                Gate = f.Gate,
                Occupancy_Id = f.Occupancy_Id
            }).ToList();

            return Task.FromResult(result);
        }
    }
}
