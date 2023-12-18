using Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public abstract class CeilingFanCommand : ICommand
	{
		protected CeilingFan ceilingFan;
		protected int prevSpeed;

		public virtual void Execute()
		{
			this.prevSpeed = ceilingFan.Speed;
		}

		public void Undo()
		{
			if (prevSpeed == ceilingFan.Off)
			{
				ceilingFan.SetOff();
			}
			if (prevSpeed == ceilingFan.High)
			{
				ceilingFan.SetHigh();
			}
			if (prevSpeed == ceilingFan.Medium)
			{
				ceilingFan.SetMedium();
			}
		}
	}
}
