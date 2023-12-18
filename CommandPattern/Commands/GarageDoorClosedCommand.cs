using Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public class GarageDoorClosedCommand : ICommand
	{
		private GarageDoor garageDoor;
		public GarageDoorClosedCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public void Execute()
		{
			this.garageDoor.Down();
		}

		public void Undo()
		{
			this.garageDoor.Up();
		}
	}
}
