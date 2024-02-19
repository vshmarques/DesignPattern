using Flyweight.Model;

namespace Flyweight.Cars;

public class BlueCar : CarBase
{
    public BlueCar()
    {
        this.color = "blue";
        this.size = "10px";
    }

    public override void Show(string status)
    {
        Console.WriteLine($"Car of {this.size} and color {this.color} is {status}");
    }
}
