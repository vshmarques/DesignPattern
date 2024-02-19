using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Abstractions;

public abstract class OrderReceiver
{
    private OrderReceiver Next = null;

    public OrderReceiver AddNext(OrderReceiver next)
    {
        this.Next = next;
        return next;
    }

    public virtual Order AddServiceInOrder(Order order)
    {
        if (this.Next != null)
            return this.Next.AddServiceInOrder(order);

        return null;
    }
}
