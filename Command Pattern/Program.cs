using Command_Pattern.Home_Automation_Example.Commands;
using Command_Pattern.Home_Automation_Example.Controller;
using Command_Pattern.Home_Automation_Example.Receivers;

void RunHomeAutomation()
{
    var remoteControl = new RemoteControl();

    var livingRoomLight = new Light("Living Room");

    var kitchenLight = new Light("Kitchen");

    var livingRoomLightOn = new LightOnCommand(livingRoomLight);
    var livingRoomLightOff = new LightOffCommand(livingRoomLight);

    var kitchenLightOn = new LightOnCommand(kitchenLight);
    var kitchenLightOff = new LightOffCommand(kitchenLight);

    var ceilingFan = new CeilingFan("Living Room");
    var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
    var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

    remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
    remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
    remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);

    remoteControl.OnButtonWasPushed(0);
    remoteControl.OffButtonWasPushed(0);
    remoteControl.UndoButtonWasPushed();

    remoteControl.OnButtonWasPushed(1);
    remoteControl.OffButtonWasPushed(1);
    remoteControl.UndoButtonWasPushed();

    remoteControl.OnButtonWasPushed(2);
    remoteControl.OffButtonWasPushed(2);
    remoteControl.UndoButtonWasPushed();
}

RunHomeAutomation();