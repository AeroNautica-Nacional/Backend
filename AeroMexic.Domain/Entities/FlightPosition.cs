using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class FlightPosition : BaseEntity
    {
        public int Id { get; set; }
        public int Flight_Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Altitude { get; set; }
        public int Speed { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
