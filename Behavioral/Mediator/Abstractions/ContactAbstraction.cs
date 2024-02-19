namespace Mediator.Abstractions;

public abstract class ContactAbstraction
{
    protected MediatorAbstraction _mediator;

    public ContactAbstraction(MediatorAbstraction mediator)
    {
        _mediator = mediator;
    }
}
