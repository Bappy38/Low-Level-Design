using Command_Pattern.Home_Automation_Example.Receivers;

namespace Command_Pattern.Home_Automation_Example.Commands;

public class LightOnCommand : ICommand
{
    public Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.On();
    }

    public void Undo()
    {
        light.Off();
    }
}
