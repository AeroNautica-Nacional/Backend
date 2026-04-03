using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Entities
{
    public partial class Aicraft
    {
        public int Id { get; private set; }
        public string Model { get; private set; } = string.Empty;
        public string TailNumber { get; private set; } = string.Empty;
        public int Capacity { get; private set; }

        public ICollection<Flight> Flights { get; private set; } = new List<Flight>();
    }
}
