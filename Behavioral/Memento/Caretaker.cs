namespace Memento;

public class Caretaker
{
    private Memento _memento;

    public void AddSnapshot(Memento memento)
    {
        _memento= memento;
    }

    public Memento GetSnapshot() => _memento;
}
