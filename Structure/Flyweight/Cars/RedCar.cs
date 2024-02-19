using Flyweight.Model;

namespace Flyweight.Cars;

public class RedCar : CarBase
{
    public RedCar()
    {
        this.color = "red";
        this.size = "14px";
    }

    public override void Show(string status)
    {
        Console.WriteLine($"Car of {this.size} and color {this.color} is {status}");
    }
}
