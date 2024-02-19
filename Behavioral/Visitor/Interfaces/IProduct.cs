namespace Visitor.Interfaces;

public interface IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }

    public double Tax(IVisitor visitor);
}
