using System;
using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class TelevisionOffCommand : CommandBase<Television>
    {
        public TelevisionOffCommand(Television state) : base(state)
        {
        }

        public override void Execute()
        {
            _state.TurnOff();
        }

        public override void Undo()
        {
            _state.TurnOn();
        }
    }
}
