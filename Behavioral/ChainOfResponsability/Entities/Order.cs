namespace ChainOfResponsability.Entities;

public class Order
{
    private Dictionary<string, double> items;

    public Order()
    {
        items = new Dictionary<string, double>();
    }

    public void Add(KeyValuePair<string, double> item) 
    {
        items.Add(item.Key, item.Value);
    }

    public List<string> GetItems() => items.Keys.ToList();
        
    public double GetTotal() => items.Values.Sum();
}
