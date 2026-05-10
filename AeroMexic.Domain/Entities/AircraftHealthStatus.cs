

using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class AircraftHealthStatus : BaseEntity
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
