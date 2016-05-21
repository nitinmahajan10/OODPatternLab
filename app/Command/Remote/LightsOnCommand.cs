using OODPatternLab.Command.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.Remote
{
    public class LightsOnCommand : CommandBase<Light>
    {
        public LightsOnCommand(Light state) : base(state)
        {
        }

        public override void Execute(object data)
        {
            _state.TurnOn();
        }

        public override void Undo()
        {
            _state.TurnOff();
        }
    }
}
