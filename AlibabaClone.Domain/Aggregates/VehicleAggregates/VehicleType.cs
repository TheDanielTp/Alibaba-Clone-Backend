using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.VehicleAggregates
{
    public class VehicleType : Entity<int>
    {
        public string Title { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}