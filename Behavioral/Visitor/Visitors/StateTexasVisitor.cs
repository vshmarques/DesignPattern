using Visitor.Interfaces;
using Visitor.Products;

namespace Visitor.Visitors;

public class StateTexasVisitor : IVisitor
{
    public double CalculateTaxEletricTool(EletricTool product)
    {
        return product.Price * 0.021;
    }

    public double CalculateTaxManualTool(ManualTool product)
    {
        return product.Price * 0.013;
    }
}
