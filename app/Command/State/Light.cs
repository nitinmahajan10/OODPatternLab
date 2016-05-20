using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.State
{
    public class Light
    {
        public bool State { get; private set; }

        public void TurnOn()
        {
            State = true;
            Console.WriteLine("Brightness everywhere!");
        }

        public void TurnOff()
        {
            State = false;
            Console.WriteLine("Darkness everywhere!");
        }
    }
}
