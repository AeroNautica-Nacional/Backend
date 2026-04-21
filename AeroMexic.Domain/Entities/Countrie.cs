using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Entities
{
    public partial class Countrie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IosCode { get; set; } = string.Empty;
        public string PhoneCode { get; set; } = string.Empty;
    }
}
