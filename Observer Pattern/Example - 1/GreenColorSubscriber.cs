namespace Observer_Pattern.Example___1;

/// <summary>
/// This is one of the concrete subscriber
/// </summary>
public class GreenColorSubscriber : IObserver
{
    public void ColorChanged(Color newColor)
    {
        if(newColor == Color.Green)
        {
            Console.WriteLine($"Green Subscriber ::: Desired One Found.");
            return;
        }
        Console.WriteLine($"Green Subscriber ::: Desired One Not Found.");
    }
}
