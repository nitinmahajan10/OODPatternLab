using System;

namespace OODPatternLab.Command.State
{
    public class Television
    {
        public int ChannelNumber { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("It's so entertaining!");
        }

        public void TurnOff()
        {
            Console.WriteLine("It's so dark!");
        }

        public void SetChannel(int channel)
        {
            ChannelNumber = channel;

            Console.WriteLine("Now Playing " + ChannelNumber);
        }
    }
}
