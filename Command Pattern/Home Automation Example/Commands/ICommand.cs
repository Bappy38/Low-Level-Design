namespace Command_Pattern.Home_Automation_Example.Commands;

public interface ICommand
{
    public void Execute();
    public void Undo();
}
