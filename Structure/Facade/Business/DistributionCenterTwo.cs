namespace Facade.Business;

public class DistributionCenterTwo
{
    public List<object> GetTotalItems(DateTime dateTime)
    {
        Console.WriteLine($"Getting items of distribution center two at {dateTime}");
        return Enumerable.Repeat(new object() { }, 4).ToList();
    }
}
