using AbstractFactory.Interfaces;

namespace AbstractFactory.Burgers;

public class BigMac : IBurger
{
    public void GetBurguer()
    {
        Console.WriteLine("It's a BigMac burger");
    }
}
