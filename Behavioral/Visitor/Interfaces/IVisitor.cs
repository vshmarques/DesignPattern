using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Products;

namespace Visitor.Interfaces;

public interface IVisitor
{
    double CalculateTaxEletricTool(EletricTool product);
    double CalculateTaxManualTool(ManualTool product);
}
