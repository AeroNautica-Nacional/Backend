using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Entities
{
    public partial class Airport
    {
        public int Id { get; private set; }
        public string IataCode { get; set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string Country { get; private set; } = string.Empty;

        // Nav Inversa
        public ICollection<Flight> DepartingFlights { get; private set; } = new List<Flight>();
        public ICollection<Flight> ArrivingFlights { get; private set; } = new List<Flight>();
    }
}
