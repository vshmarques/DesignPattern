using AbstractFactory.Interfaces;

namespace AbstractFactory.Drinks;

public class CocaCola : IDrink
{
    public void GetDrink()
    {
        Console.WriteLine("It's a coca-cola drink");
    }
}
