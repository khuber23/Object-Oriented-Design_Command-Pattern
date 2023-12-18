using CommandPattern.Commands;
using Receivers;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
			RemoteControl remoteControl = new RemoteControl();

			CeilingFan ceilingFan = new CeilingFan("Living Room");

			CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
			CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
			CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);

			remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
			remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

			remoteControl.OnButtonPressed(0);
			remoteControl.OffButtonPressed(0);

			Console.WriteLine(remoteControl.ToString());

			remoteControl.UndoButtonPressed();

			remoteControl.OnButtonPressed(1);

			Console.WriteLine(remoteControl.ToString());

			remoteControl.UndoButtonPressed();

			Light light = new Light("Living Room");
			LightOnCommand lightOnCommand = new LightOnCommand(light);
			LightOffCommand lightOffCommand = new LightOffCommand(light);

			TV tv = new TV("Living Room");
			TVOnCommand tVOnCommand = new TVOnCommand(tv);
			TVOffCommand tVOffCommand = new TVOffCommand(tv);

			Stereo stereo = new Stereo("Patio");
			StereoOnCommand stereoOnCommand = new StereoOnCommand(stereo);
			StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

			HotTub hotTub = new HotTub("Patio");
			HotTubOnCommand hotTubOnCommand = new HotTubOnCommand(hotTub);
			HotTubOffCommand hotTubOffCommand = new HotTubOffCommand(hotTub);

			ICommand[] partyOn = { lightOnCommand, tVOnCommand, stereoOnCommand, hotTubOnCommand };
			ICommand[] partyOff = { lightOffCommand, tVOffCommand, stereoOffCommand, hotTubOffCommand };

			MacroCommand partyOnMacro= new MacroCommand(partyOn);
			MacroCommand partyOffMacro= new MacroCommand(partyOff);

			remoteControl.SetCommand(2, partyOnMacro, partyOffMacro);
			Console.WriteLine("");
			Console.WriteLine("------------------Starting the Party!------------------");
			remoteControl.OnButtonPressed(2);
			Console.WriteLine("");
			Console.WriteLine("------------------Ending the party :( ------------------");
			remoteControl.OffButtonPressed(2);

			Console.WriteLine(remoteControl.ToString());

			Console.WriteLine("------------------Starting the Party!------------------");
			remoteControl.OnButtonPressed(2);
			Console.WriteLine("");
			Console.WriteLine("------------------Undo Starting the party :( ------------------");
			remoteControl.UndoButtonPressed();

			Console.Read();
		}
    }
}