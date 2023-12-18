using CommandPattern.Commands;
using Receivers;

namespace CommandPattern
{
    public class TVOnCommand : ICommand
    {
        private TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.On();
            this.tv.SetChannel(12);
            this.tv.SetVolume(30);
        }

        public void Undo()
        {
            this.tv.Off();
        }
    }
}