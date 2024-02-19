namespace Mediator.Abstractions;

public abstract class MediatorAbstraction
{
    public abstract void Send(string message, ContactAbstraction contact);
}
