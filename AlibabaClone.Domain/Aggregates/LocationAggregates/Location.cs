using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.LocationAggregates
{
    public class Location : Entity<int>
    {
        // Required properties
        public required string Title { get; set; }
        public int CityId { get; set; } // Foreign key
        public short LocationTypeId { get; set; } // Foreign key

        // Navigation properties
        public required virtual City City { get; set; }
        public required virtual LocationType LocationType { get; set; }
        public required virtual ICollection<Transportation> Transportations { get; set; }
    }
}