using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Services;

public class StandardService : IService
{
    private Order _order;

    public StandardService(Order order)
    {
        _order = order;
    }

    public void CalculateService()
    {
        if (_order.quantity > 30)
            _order.total *= 0.95;

        Console.WriteLine(string.Format("{0}, R$ {1}", _order.description, _order.total));
    }
}
