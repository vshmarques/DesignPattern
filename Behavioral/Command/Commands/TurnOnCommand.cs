using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands;

public class TurnOnCommand : ICommand
{
    private readonly LightReceiver _receiver;

    public TurnOnCommand(LightReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.TurnOn();
        Console.WriteLine($"State: {_receiver.GetState()}, Brightness: {_receiver.GetBrightness()}");
    }
}
