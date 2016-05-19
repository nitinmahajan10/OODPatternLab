using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.State
{
    public class Lights
    {
        public void TurnOn()
        {
            Console.WriteLine("Brightness everywhere!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Darkness everywhere!");
        }
    }
}
