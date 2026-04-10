using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string PaternalLastName { get; set; }
        public string MaternalLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role_Id { get; set; }
        public RoleUser Role { get; set; }
    }
}