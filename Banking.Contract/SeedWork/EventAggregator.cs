using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Contract.SeedWork;

namespace Banking.Contract.SeedWork
{
    public class EventAggregator:IEventBus
    {
        public IList<object> Subscribers { get; set; }
        public void Publish<T>(T @event) where T : IEvent
        {
            var subscribers = Subscribers.AsQueryable().OfType<IEventHandler<T>>().ToList();
            foreach (var subscriber in subscribers)
            {
                subscriber.Handle(@event);
            }

        }

        public void Subscribe<TEvent>(IEventHandler<TEvent> eventHandler) where TEvent : IEvent
        {
            Subscribers.Add(eventHandler);
        }
    }
}
