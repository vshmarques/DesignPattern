using FactoryMethod.Interfaces;

namespace FactoryMethod.Services;

public class ServiceOne : IService
{
    public ServiceOne()
    {
        Console.WriteLine("Service one created");
    }

    public void Execute()
    {
        Console.WriteLine("Executing service one");
    }
}
