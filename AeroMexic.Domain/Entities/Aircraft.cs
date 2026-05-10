using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class Aircraft : BaseEntity
    {
        public int Id { get; set; }
        public string Registration { get; set; } //matricula
        public int Model_Id { get; set; }
        public int PassengerCapacity { get; set; }
        public int TotalFlightHours { get; set; }
        public int HealthStatus_Id { get; set; }
        public int OperationalStatus_Id { get; set; }
        public int CurrentAirport_Id { get; set; }
    }
}
