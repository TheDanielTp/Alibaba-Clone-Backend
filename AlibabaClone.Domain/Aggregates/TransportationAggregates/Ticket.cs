using AlibabaClone.Domain.Aggregates.AccountAggregates;
using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransportationAggregates
{
    public class Ticket : Entity<long>
    {
        // Required properties
        public long TransportationId { get; set; } // Foreign key
        public long SeatId { get; set; } // Foreign key
        public long BuyerId { get; set; } // Foreign key
        public long TravelerId { get; set; } // Foreign key
        public DateTime CreatedAt { get; set; }

        // Optional properties
        public long? CompanionId { get; set; } // Foreign key

        // Required properties
        public short TicketStatusId { get; set; } // Foreign key
        public string SerialNumber { get; protected set; }

        // Optional properties
        public string? Description { get; set; }

        // Navigation properties
        public required virtual Seat Seat { get; set; }
        public required virtual Account Buyer { get; set; }
        public required virtual Person Traveler { get; set; }
        public required virtual Person? Companion { get; set; }
        public required virtual TicketStatus TicketStatus { get; set; }
        public required virtual Transportation Transportation { get; set; }
    }
}