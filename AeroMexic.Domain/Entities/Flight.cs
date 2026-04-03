using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Entities;

public partial class Flight
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MyProperty { get; set; }
}
