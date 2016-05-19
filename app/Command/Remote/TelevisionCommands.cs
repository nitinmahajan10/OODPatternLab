using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class TelevisionOnCommand : UndoableComannd<Television, TelevisionOffCommand>
    {
        public TelevisionOnCommand(Television state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.TurnOn();
        }
    }
}
