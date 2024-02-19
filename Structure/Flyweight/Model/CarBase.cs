namespace Flyweight.Model;

public abstract class CarBase
{
    protected string status;

    public string color;
    public string size;

    public abstract void Show(string status);
}
