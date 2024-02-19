using Composite.Abstractions;

namespace Composite;

public class ProductComposite : ProductBase
{
    private List<ProductBase> _products;

    public ProductComposite()
    {
        _products= new List<ProductBase>();
    }

    public override void Add(ProductBase[] product)
    {
        _products.AddRange(product);
    }

    public override double Operation()
    {
        double total = 0;

        _products.ForEach(product =>
        {
            total += product.Operation();
        });

        return total;
    }

    public override void Remove(ProductBase product)
    {
        _products.Remove(product);
    }
}
