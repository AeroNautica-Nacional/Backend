using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class FlightStatus : BaseEntity
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
