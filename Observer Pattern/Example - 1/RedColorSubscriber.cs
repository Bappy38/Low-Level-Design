namespace Observer_Pattern.Example___1;

/// <summary>
/// This is one of the concrete subscriber
/// </summary>
public class RedColorSubscriber : IObserver
{
    public void ColorChanged(Color newColor)
    {
        if (newColor == Color.Red)
        {
            Console.WriteLine($"Red Subscriber ::: Desired One Found!");
            return;
        }
        Console.WriteLine($"Red Subscriber ::: Desired One Not Found.");
    }
}
