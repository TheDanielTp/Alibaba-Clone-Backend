using AlibabaClone.Domain.Framework.Base;
using AlibabaClone.Domain.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountAggregates
{
    public class Person : Entity<long>
    {
        // Required properties
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string IdNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public short GenderId { get; set; } // Foreign key

        // Optional properties
        public string? PassportNumber { get; set; }
        public string? EnglishFirstName { get; set; }
        public string? EnglishLastName { get; set; }

        // Navigation properties
        public required virtual Gender Gender { get; set; }
        public required virtual ICollection<Account> Accounts { get; set; }
    }
}