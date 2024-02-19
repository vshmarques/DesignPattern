namespace Memento;

public class Originator
{
    private string _status;

    public string Status
    {
        get { return _status; }
        set
        {
            _status = value;
            Console.WriteLine(_status);
        }
    }

    public Memento CreateSnapshot()
    {
        return new Memento(_status);
    }

    public void Restore(Memento memento)
    {
        Status = memento.GetStatus();
    }
}
