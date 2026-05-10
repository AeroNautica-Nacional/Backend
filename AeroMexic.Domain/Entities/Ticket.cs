using AeroMexic.Domain.Common;

namespace AeroMexic.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public int Id { get; set; }
        public int Flight_Id { get; set; }
        public int User_Id { get; set; }
        public string PassagerFirstName { get; set; } = string.Empty;
        public string PassagerLastName { get; set; } = string.Empty;
        public string Seat { get; set; } = string.Empty;
        public int Class_Id { get; set; }
        public decimal PaidFare { get; set; }
        public int Currency_Id { get; set; }
        public string BookingCode { get; set; } = string.Empty;
        public string TicketNumber { get; set; } = string.Empty;
        public int TicketStatus_Id { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;

        // Navigation properties
        public Flight Flight { get; set; }
        public User User { get; set; } 
        public Class Class { get; set; } 
    }
}
