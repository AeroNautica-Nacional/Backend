using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Rule_Id { get; set; }

        // Relación
        public ICollection<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();
    }
}