using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Common
{
    public partial class BaseEntity
    {
        public int Id { get; private set; }

        // Auditoria de creacion
        public DateTime CreatedAt { get; private set; }
        public string CreatedBy { get; private set; } = string.Empty;

        // Auditoria de actualizacion
        public DateTime? UpdatedAt { get; private set; }
        public string UpdatedBy { get; private set; } = string.Empty;

        // Baja logica
        public bool IsActive { get; private set; }
        public DateTime? DesactivatedAt { get; private set; }
        public string DeactivatedBy { get; private set; } = string.Empty;

        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public void Desactivated(string deactivatedBy)
        {
            IsActive = false;
            DesactivatedAt = DateTime.UtcNow;
            DeactivatedBy = deactivatedBy;
        }

        public void SetUpdated(string updatedBy)
        {
            UpdatedAt = DateTime.UtcNow;
            UpdatedBy = updatedBy;
        }
    }
}
