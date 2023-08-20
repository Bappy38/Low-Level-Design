using Command_Pattern.Home_Automation_Example.Receivers;

namespace Command_Pattern.Home_Automation_Example.Commands;

public class CeilingFanOffCommand : ICommand
{
    private CeilingFan ceilingFan;
    int prevSpeed;

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Off();
    }

    public void Undo()
    {
        switch (prevSpeed)
        {
            case CeilingFan.HIGH:
                ceilingFan.High();
                break;
            case CeilingFan.MEDIUM:
                ceilingFan.Medium();
                break;
            case CeilingFan.LOW:
                ceilingFan.Low();
                break;
            case CeilingFan.OFF:
                ceilingFan.Off();
                break;
        }
    }
}
