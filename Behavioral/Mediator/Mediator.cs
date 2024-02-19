using Mediator.Abstractions;

namespace Mediator;

public class Mediator : MediatorAbstraction
{
    private Patient _patient = null!;
    private Assistant _assistant = null!;

    public Patient Patient
    {
        set { _patient = value; }
    }

    public Assistant Assistant
    {
        set { _assistant = value; }
    }

    public override void Send(string message, ContactAbstraction contact)
    {
        if (contact == _patient) _assistant.Notify(message);
        else if (contact == _assistant) _patient.Notify(message);
    }
}
