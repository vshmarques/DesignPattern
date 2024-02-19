using AbstractFactory.Burgers;
using AbstractFactory.Drinks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories;

public class TastyComboFactory : ICombo
{
    public TastyComboFactory()
    {
        GetCombo();
    }

    public void GetCombo()
    {
        var burger = new Tasty();
        var drink = new Pespsi();

        burger.GetBurguer();
        drink.GetDrink();
    }
}
