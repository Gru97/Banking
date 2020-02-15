using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Contract.SeedWork
{
    public interface IEventBus
    {
        void Publish<T>(T @event) where T : IEvent;
        void Subscribe<TEvent>(IEventHandler<TEvent> eventHandler) where TEvent : IEvent;
    }
    public interface IEvent
    {
    }
    public interface IEventHandler<T> where T : IEvent
    {
        Task Handle<T>(T @event) where T : IEvent;
    }
}
