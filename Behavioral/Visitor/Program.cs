using Visitor.Interfaces;
using Visitor.Products;
using Visitor.Visitors;

var visitors = new List<IVisitor>() { new StateTexasVisitor(), new StateCaliforniaVisitor() };

var product1 = new EletricTool("Dril", 22);
var product2 = new ManualTool("Square", 5.6);

visitors.ForEach(visitor =>
{
    var tax = visitor.CalculateTaxEletricTool(product1);
    Console.WriteLine($"Tool: {product1.Name}, Price: {product1.Price}, Tax: {tax}, State: {visitor.GetType().Name}");
});

Console.WriteLine();

visitors.ForEach(visitor =>
{
    var tax = visitor.CalculateTaxManualTool(product2);
    Console.WriteLine($"Tool: {product2.Name}, Price: {product2.Price}, Tax: {tax}, State: {visitor.GetType().Name}");
});
