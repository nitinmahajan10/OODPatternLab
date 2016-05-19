using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class FanKnobAntiClockwiseCommand: UndoableComannd<Fan, FanKnobClockwiseCommand> 
    {
        public FanKnobAntiClockwiseCommand(Fan state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.DecreaseSpeed();
        }        
    }
}
