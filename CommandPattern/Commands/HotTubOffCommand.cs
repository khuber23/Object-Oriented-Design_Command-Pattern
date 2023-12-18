using CommandPattern.Commands;
using Receivers;

namespace CommandPattern
{
    public class HotTubOffCommand : ICommand
    {
        private HotTub hotTub;

        public HotTubOffCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void Execute()
        {
            this.hotTub.JetsOff();
            this.hotTub.SetTemperature(86);
        }

        public void Undo()
        {
            this.hotTub.JetsOn();
            this.hotTub.SetTemperature(112);
        }
    }
}