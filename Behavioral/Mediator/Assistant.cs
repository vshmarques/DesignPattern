using Mediator.Abstractions;

namespace Mediator;

public class Assistant : ContactAbstraction
{
    public Assistant(MediatorAbstraction mediator) : base(mediator)
    {
    }

    public void SendMessage(string message)
    {
        this._mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"To Assistant: {message}");
    }
}
