using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using AlibabaClone.Domain.Framework.Base;

namespace AlibabaClone.Domain.Aggregates.AccountAggregates
{
    public class Account : Entity<long>
    {
        public string PhoneNumber { get; set; }
        public string Password { set; get; }

        public string? Email { get; set; }
        public long? PersonId { get; set; }

        public virtual Person? Person { get; set; }
        public virtual ICollection<Ticket> BoughtTickets { get; set; }
    }
}