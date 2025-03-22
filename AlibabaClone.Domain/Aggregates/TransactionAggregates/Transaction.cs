using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransactionAggregates
{
    public class Transaction : Entity<long>
    {
        // Required properties
        public decimal BaseAmount { get; set; }
        public decimal FinalAmount { get; set; }
        public string SerialNumber { get; protected set; }
        public long TicketId { get; set; } // Foreign key
        public DateTime CreatedAt { get; set; }

        // Optional properties
        public long? CouponId { get; set; }

        // Navigation properties
        public required virtual Ticket Ticket { get; set; }
    }
}