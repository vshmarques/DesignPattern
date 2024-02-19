using Builder.Cars;

namespace Builder.Builders;

public abstract class CarBuilderBase
{
    protected Car car;

    public Car GetCar() { return car; }

    public abstract void SetColor();
    public abstract void SetCC();
    public abstract void SetPrice();
}
