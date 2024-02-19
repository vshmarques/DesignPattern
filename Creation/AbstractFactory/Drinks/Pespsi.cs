using AbstractFactory.Interfaces;

namespace AbstractFactory.Drinks;

public class Pespsi : IDrink
{
    public void GetDrink()
    {
        Console.WriteLine("It's a Pespsi drink");
    }
}
