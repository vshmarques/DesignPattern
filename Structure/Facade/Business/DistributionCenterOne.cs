namespace Facade.Business;

public class DistributionCenterOne
{
    public List<object> GetTotalItems(DateTime dateTime)
    {
        Console.WriteLine($"Getting items of distribution center one at {dateTime}");
        return Enumerable.Repeat(new object(){ }, 5).ToList();
    }
}
