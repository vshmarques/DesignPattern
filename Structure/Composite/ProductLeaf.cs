using Composite.Abstractions;

namespace Composite;

public class ProductLeaf : ProductBase
{
    private string _name;
    private double _price;

    public ProductLeaf(string name, double price)
    {
        _name = name;
        _price = price;
    }

    public override void Add(ProductBase[] product)
    {
        throw new Exception("Leaf objects does not add child");
    }

    public override double Operation()
    {
        Console.WriteLine($"Product: {_name}, price: {_price}");
        return _price;
    }

    public override void Remove(ProductBase product)
    {
        throw new Exception("Leaf objects does not remove child");
    }
}
