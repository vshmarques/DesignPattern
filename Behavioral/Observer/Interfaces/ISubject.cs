namespace Observer.Interfaces;

public interface ISubject
{
    List<IObserver> Observers { get; set; }
    void Add(params IObserver[] observer);
    void Remove(IObserver observer);
    void Notify(int i);
}
