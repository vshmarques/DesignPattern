using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using FactoryMethod.Services;

namespace FactoryMethod;

public class ServiceBuilder : ServiceFactory
{
    public override IService Build(EnumServiceType type)
    {
        switch(type)
        {
            case EnumServiceType.One: return new ServiceOne();
            case EnumServiceType.Two: return new ServiceTwo();
            case EnumServiceType.Three: return new ServiceThree();
            default: return null;
        }
    }
}
