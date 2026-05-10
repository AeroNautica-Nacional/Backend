
using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int Id { get; set; }
        public int Ticket_Id { get; set; }
        public int PaymentMethod_Id { get; set; }
        public int Currency_Id { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal PaidAmount { get; set; }
        public string ExternalTransaction_Id { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        // Navigation properties
    }
}
