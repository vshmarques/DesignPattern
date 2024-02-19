using State.Interfaces;

namespace State.States;

public class StateA : IState
{
    public void Execute(Context context)
    {
        Console.WriteLine($"Running execution of state A");
        context.State = new StateB();
    }
}
