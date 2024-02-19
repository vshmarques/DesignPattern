using Builder.Cars;

namespace Builder.Builders;

public class Car1000CcBuilder : CarBuilderBase
{
    public Car1000CcBuilder()
    {
        car = new Car1000CC();
    }

    public override void SetCC()
    {
        car.SetCC(1000);
    }

    public override void SetColor()
    {
        car.SetColor("Red");
    }

    public override void SetPrice()
    {
        car.SetPrice(55000M);
    }
}
