namespace AeroMexic.Application.DTOs
{
    public partial class FlightDto
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; } = string.Empty;
        public string Aircarft { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Gate { get; set; } = string.Empty;
        public int Occupancy_Id { get; set; }
    }
}
