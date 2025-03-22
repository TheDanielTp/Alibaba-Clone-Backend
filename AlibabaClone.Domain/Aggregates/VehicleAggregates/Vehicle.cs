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
    public class Vehicle : Entity<int>
    {
        // Required properties
        public required string Title { get; set; }
        public int VehicleTypeId { get; set; } // Foreign key
        public int Capacity { get; set; }
        public required string PlateNumber { get; set; }

        // Optional properties
        public required virtual VehicleType VehicleType { get; set; }
        public required virtual ICollection<Seat> Seats { get; set; }
        public required virtual ICollection<Transportation> Transportations { get; set; }
    }
}