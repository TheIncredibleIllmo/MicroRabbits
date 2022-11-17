using MicroRabbits.Domain.Core.Commands;
using MicroRabbits.Domain.Core.Events;

namespace MicroRabbits.Domain.Core.Bus;

public interface IEventBus
{
    Task SendCommandAsync<T>(T command) where T : Command;
    void Publish<T>(T @event) where T: Event;
    void Subscribe<T, TH>() 
        where T: Event 
        where TH : IEventHandler<T>;
}