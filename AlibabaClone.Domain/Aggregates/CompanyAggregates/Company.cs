using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.CompanyAggregates
{
    public class Company : Entity<int>
    {
        // Required properties
        public required string Title { get; set; }

        // Navigation properties
        public required virtual ICollection<Transportation> Transportations { get; set; }
    }
}