using System;

namespace OODPatternLab.Command.State
{
    public class Television
    {
        public bool State { get; private set; }
        public int ChannelNumber { get; private set; }

        public void TurnOn()
        {
            State = true;
            Console.WriteLine("It's so entertaining!");
        }

        public void TurnOff()
        {
            State = false;
            Console.WriteLine("It's so dark!");
        }

        public void SetChannel(int channel)
        {
            ChannelNumber = channel;

            Console.WriteLine("Now Playing " + ChannelNumber);
        }
    }
}
