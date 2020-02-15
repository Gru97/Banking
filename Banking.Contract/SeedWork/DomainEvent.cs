using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Banking.Contract.SeedWork
{
    public class DomainEvent:IEvent
    {
        public DateTime CreateAt { get; set; }
        public Guid Id { get; set; }

        public DomainEvent(DateTime at, Guid id)
        {
            CreateAt = at;
            Id = id;
        }
    }
}
