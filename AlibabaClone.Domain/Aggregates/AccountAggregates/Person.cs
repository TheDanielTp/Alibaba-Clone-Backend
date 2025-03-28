using AlibabaClone.Domain.Aggregates.TransportationAggregates;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public short GenderId { get; set; }

        public string? PassportNumber { get; set; }
        public string? EnglishFirstName { get; set; }
        public string? EnglishLastName { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Ticket> TraveledTickets { get; set; }
    }
}