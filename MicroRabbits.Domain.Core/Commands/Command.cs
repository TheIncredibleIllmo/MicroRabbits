using MicroRabbits.Domain.Core.Events;

namespace MicroRabbits.Domain.Core.Commands;

public abstract class Command : Message
{
    public DateTime Timestamp { get; protected set; }

    protected Command()
    {
        Timestamp = DateTime.Now;
    }
}