using Command.Interfaces;

namespace Command.Invokers;

public class LightInvoker
{
    private List<ICommand> _commands = new List<ICommand>();

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    public void ExecuteCommands()
    {
        _commands.ForEach(cmd => cmd.Execute());
    }
}
