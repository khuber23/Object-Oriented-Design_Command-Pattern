﻿using Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public class LightOnCommand : ICommand
	{
		private Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}
		public void Execute()
		{
			this.light.On();
		}

		public void Undo()
		{
			this.light.Off();
		}
	}
}
