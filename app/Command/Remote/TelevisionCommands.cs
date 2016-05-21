using System;
using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class TelevisionOnCommand : CommandBase<Television>
    {
        public TelevisionOnCommand(Television state) : base(state)
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
