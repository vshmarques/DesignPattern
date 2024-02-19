using Visitor.Interfaces;

namespace Visitor.Products;

public class ManualTool : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }

    public ManualTool(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public double Tax(IVisitor visitor)
    {
        return visitor.CalculateTaxManualTool(this);
    }
}
