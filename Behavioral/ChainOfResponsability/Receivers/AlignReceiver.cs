using ChainOfResponsability.Abstractions;
using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Receivers;

public class AlignReceiver : OrderReceiver
{
    public override Order? AddServiceInOrder(Order order)
    {
        order.Add(new KeyValuePair<string, double>("Align Car Service", 180));

        return base.AddServiceInOrder(order);
    }
}
