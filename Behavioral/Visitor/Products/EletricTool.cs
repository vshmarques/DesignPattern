using Visitor.Interfaces;

namespace Visitor.Products;

public class EletricTool : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }

    public EletricTool(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public double Tax(IVisitor visitor)
    {
        return visitor.CalculateTaxEletricTool(this);
    }
}
