

namespace AeroMexic.Domain.Entities
{
    public class FlightSeat
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
        public int Flight_Id { get; set; }
        public Flight Flight { get; set; }
    }
}
