using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class FanKnobClockwiseCommand : UndoableComannd<Fan, FanKnobAntiClockwiseCommand>
    {
        public FanKnobClockwiseCommand(Fan state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.IncreaseSpeed();
        }
    }
}
