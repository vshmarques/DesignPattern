using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands;

public class DecreaseBrightnessCommand : ICommand
{
    private readonly LightReceiver _receiver;

    public DecreaseBrightnessCommand(LightReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.DecreaseBrightness();
        Console.WriteLine($"State: {_receiver.GetState()}, Brightness: {_receiver.GetBrightness()}");
    }
}
