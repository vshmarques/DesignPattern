using Observer.Interfaces;

namespace Observer.Subjects;

public class Blog : ISubject
{
    public List<IObserver> Observers { get; set; }

    public Blog()
    {
        Observers= new List<IObserver>();
    }

    public void Add(params IObserver[] observer)
    {
        Observers.AddRange(observer);
    }

    public void Notify(int i)
    {
        Observers.ForEach(o => o.Update(i));
    }

    public void Remove(IObserver observer)
    {
        Observers.Remove(observer);
    }
}
