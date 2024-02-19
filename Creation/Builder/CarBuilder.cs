using Builder.Builders;

namespace Builder;

public class CarBuilder
{
    public void BuildCar(CarBuilderBase builder)
    {
        builder.SetCC();
        builder.SetColor();
        builder.SetPrice();
    }
}
