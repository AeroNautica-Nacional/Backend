using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class RolePermission : BaseEntity
    {
        public int Id { get; set; }
        public int Role_Id { get; set; } // Foreign key
        public RoleUser RoleUser { get; set; } // Navegation

        public int Permission_Id { get; set; }
        public Permission Permission { get; set; }
    }
}
