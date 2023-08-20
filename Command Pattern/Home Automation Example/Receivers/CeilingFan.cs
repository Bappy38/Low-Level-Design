namespace Command_Pattern.Home_Automation_Example.Receivers;

public class CeilingFan
{
    public const int HIGH = 3;
    public const int MEDIUM = 2;
    public const int LOW = 1;
    public const int OFF = 0;

    private string Location;
    private int Speed;

    public CeilingFan(string location)
    {
        Location = location;
        Speed = OFF;
    }

    public void High()
    {
        Speed = HIGH;
        Console.WriteLine($"Ceiling Fan is ON in HIGH Speed.");
    }

    public void Medium()
    {
        Speed = MEDIUM;
        Console.WriteLine($"Ceiling Fan is ON in MEDIUM Speed.");
    }

    public void Low()
    {
        Speed = LOW;
        Console.WriteLine($"Ceiling Fan is ON in LOW Speed.");
    }

    public void Off()
    {
        Speed = OFF;
        Console.WriteLine($"Ceiling Fan is OFF.");
    }

    public int GetSpeed()
    {
        return Speed;
    }
}
