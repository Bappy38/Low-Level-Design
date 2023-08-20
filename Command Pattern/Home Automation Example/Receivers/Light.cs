namespace Command_Pattern.Home_Automation_Example.Receivers;

public class Light
{
    private string Location;

    public Light(string location)
    {
        Location = location;
    }

    public void On()
    {
        Console.WriteLine($"{Location} Light is On.");
    }

    public void Off()
    {
        Console.WriteLine($"{Location} Light is Off.");
    }
}
