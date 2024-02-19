namespace Adapter;

public class LegacyAdapter : ILegacyAdapter
{
    LegacyCode _legacy;

    public LegacyAdapter(LegacyCode legacy)
    {
        _legacy = legacy;
    }

    public string Execute(int year, int month, int day)
    {
        return _legacy.DoSomething(new DateTime(year, month, day));
    }
}
