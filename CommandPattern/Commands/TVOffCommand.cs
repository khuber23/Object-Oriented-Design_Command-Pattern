using CommandPattern.Commands;
using Receivers;

namespace CommandPattern
{
    public class TVOffCommand : ICommand
    {
        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            this.tv.Off();
        }

        public void Undo()
        {
            this.tv.On();

            this.tv.SetChannel(this.tv.Channel);
            this.tv.SetVolume(this.tv.Volume);
        }
    }
}