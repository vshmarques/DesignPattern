namespace Builder.Cars;

public class Car1000CC : Car
{
    public override void SetCC(int cc)
    {
        CC = cc;
    }

    public override void SetColor(string color)
    {
        Color = color;
    }

    public override void SetPrice(decimal price)
    {
        Price = price;
    }
}
