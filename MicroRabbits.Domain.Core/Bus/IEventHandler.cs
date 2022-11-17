using MicroRabbits.Domain.Core.Events;

namespace MicroRabbits.Domain.Core.Bus;

// contravariant
public interface IEventHandler<in TEvent> : IEventHandler where TEvent: Event
{
    Task Handle(TEvent @event);
}

public interface IEventHandler
{
    
}