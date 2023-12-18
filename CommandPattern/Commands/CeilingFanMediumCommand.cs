using Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public class CeilingFanMediumCommand : CeilingFanCommand
	{
		public CeilingFanMediumCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public override void Execute()
		{
			base.Execute();
			this.ceilingFan.SetMedium();
		}
	}
}
