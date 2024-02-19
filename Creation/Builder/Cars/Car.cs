namespace Builder.Cars;

public abstract class Car
{
    public string Color { get; protected set; }
    public int CC { get; protected set; }
    public decimal Price { get; protected set; }

    public abstract void SetColor(string color);
    public abstract void SetCC(int CC);
    public abstract void SetPrice(decimal price);
}
