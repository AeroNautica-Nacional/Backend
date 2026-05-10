using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class Airport : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IataCode { get; set; } = string.Empty;
        public string IcaoCode { get; set; } = string.Empty;
        public int City_Id { get; set; }
        public int Country_Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int Elevation { get; set; }
        public string Timezone { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        // Navigation properties
        public City City { get; set; }
        public Country Country { get; set; }
    }
}
