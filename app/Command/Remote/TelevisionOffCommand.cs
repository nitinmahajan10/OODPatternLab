using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class TelevisionOffCommand : UndoableComannd<Television, TelevisionOnCommand>
    {
        public TelevisionOffCommand(Television state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.TurnOff();
        }
    }
}
