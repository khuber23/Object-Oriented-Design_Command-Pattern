using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
	public class NoCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Command not implemented..");
		}

		public void Undo()
		{
			Console.WriteLine("Command not implemented..");
		}
	}
}
