using AbstractFactory.Interfaces;

namespace AbstractFactory.Burgers;

public class Tasty : IBurger
{
    public void GetBurguer()
    {
        Console.WriteLine("It's a Tasty burger");
    }
}
