namespace Observer_Pattern.Example___1;

/// <summary>
/// This is the subscriber interface/contract
/// </summary>
public interface IObserver
{
    void ColorChanged(Color newColor);
}
