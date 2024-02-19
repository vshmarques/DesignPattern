using Decorator.Interfaces;

namespace Decorator.Decorators;

public class PetCollar : PetServiceDecorator
{
    public PetCollar(IPetService petService) : base(petService)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + "\n[+] Collar";
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 5.9;
    }
}
