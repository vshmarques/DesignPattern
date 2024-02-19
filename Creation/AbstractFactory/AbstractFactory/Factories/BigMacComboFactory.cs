using AbstractFactory.Burgers;
using AbstractFactory.Drinks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories;

public class BigMacComboFactory : ICombo
{
    public BigMacComboFactory()
    {
        GetCombo();
    }

    public void GetCombo()
    {
        var burger = new BigMac();
        var drink = new CocaCola();

        burger.GetBurguer();
        drink.GetDrink();
    }
}
