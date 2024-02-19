using Observer.Interfaces;

namespace Observer.Observers;

public class Assigners : IObserver
{
    public string Name { get; set; }
    public string Message { get; set; }

    public Assigners(string name, string message)
    {
        Name = name;
        Message = message;
    }

    public void Update(int i)
    {
        Console.WriteLine($"Something has changed in subject and received by Obeserver {Name}. Received: {i}");
    }
}
