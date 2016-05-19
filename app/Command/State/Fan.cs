using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.State
{
    public class Fan
    {
        public byte _speed;

        public void IncreaseSpeed()
        {
            if (_speed == 5)
                _speed = 0;
            else
                ++_speed;

            Console.WriteLine("Fan speed: " + _speed);
        }

        public void DecreaseSpeed()
        {
            if (_speed == 0)
                _speed = 5;
            else
                --_speed;

            Console.WriteLine("Fan speed: " + _speed);
        }
    }
}
