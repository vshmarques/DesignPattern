using FactoryMethod.Interfaces;

namespace FactoryMethod.Services
{
    public class ServiceThree : IService
    {
        public ServiceThree()
        {
            Console.WriteLine("Service three created");
        }

        public void Execute()
        {
            Console.WriteLine("Executing service three");
        }
    }
}
