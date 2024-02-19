using Builder.Cars;

namespace Builder.Builders;

public class Car1500CcBuilder : CarBuilderBase
{
    public Car1500CcBuilder()
    {
        car = new Car1500CC();
    }

    public override void SetCC()
    {
        car.SetCC(1500);
    }

    public override void SetColor()
    {
        car.SetColor("Blue");
    }

    public override void SetPrice()
    {
        car.SetPrice(68000M);
    }
}
