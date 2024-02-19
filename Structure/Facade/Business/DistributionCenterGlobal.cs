namespace Facade.Business;

public class DistributionCenterGlobal
{
    public void GenerateTotalItems(List<object> cdOne, List<object> cdTwo)
    {
        int total = cdOne.Count + cdTwo.Count;
        Console.WriteLine($"The total of items is {total}");
    }
}
