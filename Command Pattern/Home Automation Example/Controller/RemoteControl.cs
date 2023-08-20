using Command_Pattern.Home_Automation_Example.Commands;

namespace Command_Pattern.Home_Automation_Example.Controller;

public class RemoteControl
{
    public List<ICommand> onCommands;
    public List<ICommand> offCommands;
    ICommand UndoCommand;

    public RemoteControl()
    {
        onCommands = new List<ICommand>();
        offCommands = new List<ICommand>();

        var noCommand = new NoCommand();

        for (var slot = 0 ; slot < 3; slot++)
        {
            onCommands.Add(noCommand);
            offCommands.Add(noCommand);
        }

        UndoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
        UndoCommand = onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
        UndoCommand = offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        UndoCommand.Undo();
    }
}
