using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod;

public abstract class ServiceFactory
{
    public abstract IService Build(EnumServiceType type);
}
