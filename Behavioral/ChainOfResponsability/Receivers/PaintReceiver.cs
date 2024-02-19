using ChainOfResponsability.Abstractions;
using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Receivers;

public class PaintReceiver : OrderReceiver
{
    public override Order? AddServiceInOrder(Order order)
    {
        order.Add(new KeyValuePair<string, double>("Paint Car Service", 1500));

        return base.AddServiceInOrder(order);
    }
}
