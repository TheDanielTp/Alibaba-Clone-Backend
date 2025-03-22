using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountAggregates
{
    public class AccountRole
    {
        // Required properties
        public long AccountId { get; set; } // Foreign key
        public short RoleId { get; set; } // Foreign key
    }
}