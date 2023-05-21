namespace Observer_Pattern.Example___1;

/// <summary>
/// This is the publisher interface/contract
/// </summary>
public interface ISubject
{
    void Register(IObserver observer);
    void Unregister(IObserver observer);

    void Notify();
}
