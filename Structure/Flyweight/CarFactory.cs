using Flyweight.Cars;
using Flyweight.Model;

namespace Flyweight;

public class CarFactory
{
    private Dictionary<string, CarBase> _cars = new Dictionary<string, CarBase>();

    public CarBase BuildCar(string color)
    {
        if (_cars.ContainsKey(color))
            return _cars[color];
        
        CarBase car = null!;
        switch(color)
        {
            case "blue": car = new BlueCar();
                break;
            case "red":
                car = new RedCar();
                break;
        }

        _cars.Add(color, car);
        return car;
    }
}
