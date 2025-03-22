using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.LocationAggregates
{
    public class City : Entity<int>
    {
        // Required properties
        public required string Title { get; set; }

        // Navigation properties
        public required virtual ICollection<Location> Locations { get; set; }
    }
}