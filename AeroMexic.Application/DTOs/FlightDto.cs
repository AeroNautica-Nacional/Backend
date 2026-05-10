namespace AeroMexic.Application.DTOs
{
    public partial class FlightDto
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
    }
}
