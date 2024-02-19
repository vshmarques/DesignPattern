using FactoryMethod.Interfaces;

namespace FactoryMethod.Services;

public class ServiceTwo : IService
{
    public ServiceTwo()
    {
        Console.WriteLine("Service two created");
    }

    public void Execute()
    {
        Console.WriteLine("Executing service two");
    }
}
