using CommandPattern.Commands;
using Receivers;

namespace CommandPattern
{
    public class StereoOnCommand : ICommand
    {
        private Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.On();
            this.stereo.SetCD();
            this.stereo.SetVolume(11);
        }

        public void Undo()
        {
            this.stereo.Off();
        }
    }
}