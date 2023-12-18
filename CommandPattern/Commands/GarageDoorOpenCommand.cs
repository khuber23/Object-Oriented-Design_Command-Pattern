using Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public class GarageDoorOpenCommand : ICommand
	{
		private GarageDoor garageDoor;
		public GarageDoorOpenCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public void Execute()
		{
			this.garageDoor.Up();
		}

		public void Undo()
		{
			this.garageDoor.Down();
		}
	}
}
