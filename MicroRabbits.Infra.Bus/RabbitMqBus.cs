using MediatR;
using MicroRabbits.Domain.Core.Bus;
using MicroRabbits.Domain.Core.Commands;
using MicroRabbits.Domain.Core.Events;

namespace MicroRabbits.Infra.Bus;

public class RabbitMqBus : IEventBus
{
    private readonly IMediator _mediator;
    private readonly Dictionary<string,List<Type>> _handlers;
    private readonly List<Type> _eventTypes;

    public RabbitMqBus(IMediator mediator)
    {
        _mediator = mediator;
        _handlers = new Dictionary<string, List<Type>>();
        _eventTypes = new List<Type>();
    }

    public Task SendCommandAsync<T>(T command) where T : Command => _mediator.Send(command);

    public void Publish<T>(T @event) where T : Event
    {
        throw new NotImplementedException();
    }

    public void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>
    {
        throw new NotImplementedException();
    }
}