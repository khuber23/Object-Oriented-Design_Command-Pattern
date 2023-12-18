using CommandPattern.Commands;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        private ICommand[] onCommands;

		private ICommand[] offCommands;

		private ICommand undoCommand;
        public RemoteControl()
        {
			onCommands = new ICommand[7];
			offCommands = new ICommand[7];
			ICommand noCommand = new NoCommand();
			for (int i = 0; i <7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
			}
			undoCommand = noCommand;
		}

		public void SetCommand(int slot, ICommand onCommand, ICommand offComand)
        {
			onCommands[slot] = onCommand;
			offCommands[slot] = offComand;
        }

        public void OnButtonPressed(int slot)
        {
            onCommands[slot].Execute();
			undoCommand = onCommands[slot];
        }

		public void OffButtonPressed(int slot)
		{
            offCommands[slot].Execute();
			undoCommand = offCommands[slot];
		}

		public void UndoButtonPressed()
		{
			undoCommand.Undo();
		}

        public override string ToString()
        {
			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.Append("\n----------------------- Remote Control -----------------------\n");

			for (int i = 0; i < this.onCommands.Length; i++)
			{
				stringBuilder.Append(string.Format("{0,-35} {1, -5}\n", $"[slot {i + 1}] {this.onCommands[i].GetType().Name}", $"{this.offCommands[i].GetType().Name}"));
			}
			stringBuilder.Append($"[undo]\t{this.undoCommand.GetType().Name}\n");
			stringBuilder.Append("\n");

			return stringBuilder.ToString();
		}
	}
}