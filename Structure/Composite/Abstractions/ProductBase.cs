namespace Composite.Abstractions;

public abstract class ProductBase
{
    public abstract void Add(params ProductBase[] product);
    public abstract void Remove(ProductBase product);
    public abstract double Operation();

}
