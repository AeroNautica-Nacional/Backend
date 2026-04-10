using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public partial class RoleUser : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
