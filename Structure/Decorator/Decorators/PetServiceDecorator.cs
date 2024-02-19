using Decorator.Interfaces;

namespace Decorator.Decorators;

public abstract class PetServiceDecorator : IPetService
{
    protected IPetService _petService;

    public PetServiceDecorator(IPetService petService)
    {
        _petService = petService;
    }

    public virtual string GetDescription()
    {
        return _petService.GetDescription();
    }

    public virtual double GetPrice()
    {
        return _petService.GetPrice();
    }
}
