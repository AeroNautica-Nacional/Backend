using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public partial class Flight : BaseEntity
    {
        public int Id { get; set; }
        public string CodeFlight { get; set; } = string.Empty;
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public DateTime ScheduledDepartureDate { get; set; }
        public DateTime ActualDepartureDate { get; set; }
        public DateTime ScheduledArrivalDate { get; set; }
        public DateTime ActualArrivalDate { get; set; }
        public int AircraftId { get; set; }
        public int FlightStatusId { get; set; }
        public int LastFlightPositionId { get; set; }

        // Navigation properties
    }
}
