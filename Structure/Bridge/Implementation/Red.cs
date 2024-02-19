using Bridge.Implementation.Interfaces;

namespace Bridge.Implementation;

public class Red : IColor
{
    public string FindByColor(string type)
    {
        return $"Has {new Random().Next(100, 1000)} items of type {type} and color {GetType().Name}";
    }
}
