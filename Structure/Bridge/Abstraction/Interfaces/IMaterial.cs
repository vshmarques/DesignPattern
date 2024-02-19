using Bridge.Implementation.Interfaces;

namespace Bridge.Abstraction.Interfaces;

public interface IMaterial
{
    IColor Color { get; set; }

    string Find();
}
