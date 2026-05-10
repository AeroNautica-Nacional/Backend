using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class AircraftOperationalStatus : BaseEntity
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
