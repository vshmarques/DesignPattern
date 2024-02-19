using State.Interfaces;

namespace State.States;

public class StateB : IState
{
    public void Execute(Context context)
    {
        Console.WriteLine($"Running execution of state B");
        context.State = new StateA();
    }
}
