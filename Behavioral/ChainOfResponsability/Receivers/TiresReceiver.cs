using ChainOfResponsability.Abstractions;
using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Receivers;

public class TiresReceiver : OrderReceiver
{
    public override Order? AddServiceInOrder(Order order)
    {
        order.Add(new KeyValuePair<string, double>("Change of 4 tires Car Service", 90));

        return base.AddServiceInOrder(order);
    }
}