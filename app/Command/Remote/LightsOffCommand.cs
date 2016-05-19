using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class LightsOffCommand : UndoableComannd<Lights, LightsOnCommand>
    {
        public LightsOffCommand(Lights state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.TurnOff();
        }        
    }
}
