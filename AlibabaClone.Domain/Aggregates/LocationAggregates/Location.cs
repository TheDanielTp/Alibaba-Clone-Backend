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
        public string Title { get; set; }
        public int CityId { get; set; }
        public short LocationTypeId { get; set; }

        public virtual City City { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual ICollection<Transportation> DepartingTransportations { get; set; }
        public virtual ICollection<Transportation> ArrivingTransportations { get; set; }
    }
}