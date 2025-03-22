using AlibabaClone.Domain.Aggregates.CompanyAggregates;
using AlibabaClone.Domain.Aggregates.LocationAggregates;
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
    public class Transportation : Entity<long>
    {
        // Required properties
        public int FromLocationId { get; set; } // Foreign key
        public int ToLocationId { get; set; } // Foreign key
        public int CompanyId { get; set; } // Foreign key
        public int VehicleId { get; set; } // Foreign key
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string SerialNumber { get; protected set; }
        public int RemainingCapacity { get; protected set; }
        public decimal BasePrice { get; set; }

        // Optional properties
        public decimal? VIPPrice { get; set; }

        // Navigation properties
        public required virtual Location FromLocation { get; set; }
        public required virtual Location ToLocation { get; set; }
        public required virtual Company Company { get; set; }
        public required virtual Vehicle Vehicle { get; set; }
        public required virtual ICollection<Ticket> Tickets { get; set; }

    }
}