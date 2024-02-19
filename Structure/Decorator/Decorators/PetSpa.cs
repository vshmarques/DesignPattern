using Decorator.Interfaces;

namespace Decorator.Decorators;

public class PetSpa : PetServiceDecorator
{
    public PetSpa(IPetService petService) : base(petService)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + "\n[+] Spa";
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 300;
    }
}
