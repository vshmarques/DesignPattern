using ChainOfResponsability.Abstractions;
using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Receivers;

public class GoldHammerReceiver : OrderReceiver
{
    public override Order? AddServiceInOrder(Order order)
    {
        order.Add(new KeyValuePair<string, double>("Gold Hammer Service", 420));

        return base.AddServiceInOrder(order);
    }
}
