using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using AlibabaClone.Domain.Framework.Base;

namespace AlibabaClone.Domain.Aggregates.AccountAggregates
{
    public class Account : Entity<long>
    {
        // Required properties
        public required string PhoneNumber { get; set; }
        public required string Password { set; get; }

        // Optional properties
        public string? Email { get; set; }
        public long? PersonId { get; set; } // Foreign key

        // Navigation properties
        public required virtual Person? Person { get; set; }
        public required virtual ICollection<Ticket> BoughtTickets { get; set; }
    }
}