namespace Command_Pattern.Home_Automation_Example.Commands;

public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Do Nothing.");
    }

    public void Undo()
    {
        Console.WriteLine("Do Nothing.");
    }
}
