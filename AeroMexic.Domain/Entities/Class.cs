using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class Class : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
