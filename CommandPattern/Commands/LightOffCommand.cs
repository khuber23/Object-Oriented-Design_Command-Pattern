using Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public class LightOffCommand : ICommand
	{
		private Light light;
		public LightOffCommand(Light light)
		{
			this.light = light;
		}
		public void Execute()
		{
			this.light.Off();
		}

		public void Undo()
		{
			this.light.On();
		}
	}
}
