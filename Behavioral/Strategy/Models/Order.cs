using System.Runtime.CompilerServices;

namespace Strategy.Models;

public class Order
{
    public Order(Guid id, string description, double unitPrice, int quantity)
    {
        this.id = id;
        this.description = description;
        this.unitPrice = unitPrice;
        this.quantity = quantity;
        CalculateTotal();
    }

    public Guid id { get; set; }
    public string description { get; set; } = string.Empty;
    public double unitPrice { get; set; }
    public int quantity { get; set; }
    public double total { get; set; }

    private void CalculateTotal()
    {
        total = unitPrice * quantity;
        Console.WriteLine(string.Format("{0}, R$ {1}", description, total));
    }
}
