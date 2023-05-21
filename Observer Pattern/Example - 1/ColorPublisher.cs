namespace Observer_Pattern.Example___1;

/// <summary>
/// This is the publisher
/// </summary>
public class ColorPublisher : ISubject
{
    private Color color = Color.Red;

    public Color Color
    {
        get { return color; }
        set { 
            color = value;
            Notify();
        }
    }


    private HashSet<IObserver> _observers = new HashSet<IObserver>();

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        Console.WriteLine($"{Color} Published.");
        _observers.ToList().ForEach(o => o.ColorChanged(Color));
    }
}
