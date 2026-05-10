using AeroMexic.Application.DTOs;

namespace API.Models.FlightModel
{
    public class ListFlightModel
    {
        public List<FlightDto> Items { get; set; } = new List<FlightDto>();
        public FlightDto? Item { get; set; }
    }
}
