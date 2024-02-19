using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands;

public class IncreaseBrightnessCommand : ICommand
{
    private readonly LightReceiver _receiver;

    public IncreaseBrightnessCommand(LightReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.IncreaseBrightness();
        Console.WriteLine($"State: {_receiver.GetState()}, Brightness: {_receiver.GetBrightness()}");
    }
}
