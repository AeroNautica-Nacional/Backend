using AeroMexic.Domain.Common;
using AeroMexic.Domain.Entities;

namespace 
        publicAeroMexic.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public int Id { get; set; }
        public string Method { get; set; } = string.Empty;
        public int PaymentNetwork_Id { get; set; }

        // Navigation property
        public PaymentNetwork PaymentNetwork { get; set; }
    }
}
