using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.VehicleAggregates
{
    public class Seat : Entity<long>
    {
        // Required properties
        public int VehicleId { get; set; } // Foreign key
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsVIP { get; set; }
        public bool IsAvailable { get; set; }

        // Optional properties
        public string? Description { get; set; }

        // Navigation properties
        public required virtual Vehicle Vehicle { get; set; }
        public required virtual ICollection<Ticket> Tickets { get; set; }
    }
}