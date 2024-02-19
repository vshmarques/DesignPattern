using Decorator.Interfaces;

namespace Decorator.Services;

public class PetGrooming : IPetService
{
    public string GetDescription()
    {
        return "Pet Grooming";
    }

    public double GetPrice()
    {
        return 45;
    }
}
