using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Entities
{
    public partial class State
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Country_Id { get; set; }
        public Country Country { get; set; }
    }
}
