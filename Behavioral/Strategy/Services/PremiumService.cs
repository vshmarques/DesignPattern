using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Services;

public class PremiumService : IService
{
    private Order _order;

    public PremiumService(Order order)
    {
        _order = order;
    }

    public void CalculateService()
    {
        if (_order.quantity > 10)
            _order.total *= 0.9;

        Console.WriteLine(string.Format("{0}, R$ {1}", _order.description, _order.total));
    }
}
