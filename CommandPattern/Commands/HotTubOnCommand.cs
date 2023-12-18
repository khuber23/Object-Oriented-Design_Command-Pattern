using CommandPattern.Commands;
using Receivers;

namespace CommandPattern
{
    public class HotTubOnCommand : ICommand
    {
        private HotTub hotTub;

        public HotTubOnCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void Execute()
        {
            this.hotTub.JetsOn();
            this.hotTub.SetTemperature(112);
        }

        public void Undo()
        {
            this.hotTub.JetsOff();
            this.hotTub.SetTemperature(86);
        }
    }
}