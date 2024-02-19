using Visitor.Interfaces;
using Visitor.Products;

namespace Visitor.Visitors;

public class StateCaliforniaVisitor : IVisitor
{
    public double CalculateTaxEletricTool(EletricTool product)
    {
        return product.Price * 0.016;
    }

    public double CalculateTaxManualTool(ManualTool product)
    {
        return product.Price * 0.011;

    }
}
