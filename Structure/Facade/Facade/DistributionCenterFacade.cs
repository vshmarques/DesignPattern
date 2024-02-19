using Facade.Business;

namespace Facade.Facade;

public class DistributionCenterFacade
{
    public void GetTotalItens()
    {
        var cdOne = new DistributionCenterOne();
        var cdTwo = new DistributionCenterTwo();
        var global = new DistributionCenterGlobal();

        var now = DateTime.Now;

        var itensOne = cdOne.GetTotalItems(now);
        var itensTwo = cdTwo.GetTotalItems(now);

        global.GenerateTotalItems(itensOne, itensTwo);
    }
}
