using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Banking.Contract.SeedWork;

namespace Banking.Contract.DomainEvents
{
    public class CustomerCreatedDomainEvent: DomainEvent
    {
        public string NationalCode { get; private set; }


        public CustomerCreatedDomainEvent(string nationalCode) : base(DateTime.Now.ToLocalTime(),Guid.NewGuid())
        {
            NationalCode = nationalCode;
        }
    }
}
