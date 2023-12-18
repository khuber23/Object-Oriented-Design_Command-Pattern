using CommandPattern.Commands;
using Receivers;

namespace CommandPattern
{
    public class StereoOffCommand : ICommand
    {
        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.Off();
        }

        public void Undo()
        {
            this.stereo.On();
            this.stereo.SetVolume(this.stereo.Volume);
        }
    }
}