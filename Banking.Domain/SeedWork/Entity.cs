using System;
using System.Collections.Generic;
using System.Text;
using Banking.Contract.SeedWork;

namespace Banking.Domain.SeedWork
{
    public class Entity
    {
        public Guid Id { get; set; }
        public List<IEvent> Events { get; set; }

        public Entity()
        {
            Events =new List<IEvent>();
        }
    }
}
