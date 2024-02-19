namespace Memento;

public class Memento
{
    private string _status;

    public Memento(string status)
    {
        _status = status;
    }

    public string GetStatus() => _status;
}
