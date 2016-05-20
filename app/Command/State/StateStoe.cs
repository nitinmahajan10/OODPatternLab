using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.State
{
    public static class StateStoe
    {
        public static Light TheLight = new Light();
        public static Fan TheFan = new Fan();
        public static Television TheTelevision = new Television();               
    }
}
