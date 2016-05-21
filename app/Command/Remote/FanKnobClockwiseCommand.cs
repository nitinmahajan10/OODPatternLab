using System;
using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class FanKnobClockwiseCommand : CommandBase<Fan>
    {
        public FanKnobClockwiseCommand(Fan state) : base(state)
        {
        }

        public override void Execute(object data)
        {
            _state.IncreaseSpeed();
        }

        public override void Undo()
        {
            _state.DecreaseSpeed();
        }
    }
}
