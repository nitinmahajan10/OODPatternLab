using System;

namespace OODPatternLab.Command.State
{
    public class Fan
    {
        public byte Speed { get; private set; }

        public void IncreaseSpeed()
        {
            if (Speed == 5)
                Speed = 0;
            else
                ++Speed;

            Console.WriteLine("Fan speed: " + Speed);
        }

        public void DecreaseSpeed()
        {
            if (Speed == 0)
                Speed = 5;
            else
                --Speed;

            Console.WriteLine("Fan speed: " + Speed);
        }
    }
}
