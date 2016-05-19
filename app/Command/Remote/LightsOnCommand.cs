using OODPatternLab.Command.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.Remote
{
    public class LightsOnCommand : UndoableComannd<Lights, LightsOffCommand>
    {
        public LightsOnCommand(Lights state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.TurnOn();
        }
    }
}
