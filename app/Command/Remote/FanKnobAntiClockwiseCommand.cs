using System;
using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class FanKnobAntiClockwiseCommand: CommandBase<Fan>
    {
        public FanKnobAntiClockwiseCommand(Fan state) : base(state)
        {
        }

        public override void Execute(object data)
        {
            _state.DecreaseSpeed();
        }

        public override void Undo()
        {
            _state.IncreaseSpeed();
        }
    }
}
