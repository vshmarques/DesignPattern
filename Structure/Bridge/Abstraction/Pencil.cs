using Bridge.Abstraction.Interfaces;
using Bridge.Implementation.Interfaces;

namespace Bridge.Abstraction;

public class Pencil : IMaterial
{
    public IColor Color { get; set; } = null!;
    
    public string Find()
    {
        return Color.FindByColor(GetType().Name);
    }
}