using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands;

public class TurnOffCommand : ICommand
{
    private readonly LightReceiver _receiver;

    public TurnOffCommand(LightReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.TurnOff();
        Console.WriteLine($"State: {_receiver.GetState()}, Brightness: {_receiver.GetBrightness()}");
    }
}
