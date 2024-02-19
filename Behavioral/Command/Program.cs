using Command.Commands;
using Command.Invokers;
using Command.Receivers;

var receiver = new LightReceiver();

var invoker = new LightInvoker();
invoker.AddCommand(new TurnOnCommand(receiver));
invoker.AddCommand(new DecreaseBrightnessCommand(receiver));
invoker.AddCommand(new DecreaseBrightnessCommand(receiver));
invoker.AddCommand(new DecreaseBrightnessCommand(receiver));
invoker.AddCommand(new DecreaseBrightnessCommand(receiver));
invoker.AddCommand(new TurnOffCommand(receiver));
invoker.ExecuteCommands();