using State.Interfaces;

namespace State;

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        _state = state;
    }

    public IState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Changing to state {_state.GetType().Name}");
        }
    }

    public void ChangeState()
    {
        _state.Execute(this);
    }
}
