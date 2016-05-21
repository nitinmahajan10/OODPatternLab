using System;
using OODPatternLab.Command.State;

namespace OODPatternLab.Command.Remote
{
    public class LightsOffCommand : CommandBase<Light>
    {
        public LightsOffCommand(Light state) : base(state)
        {
        }

        public override void Execute(object data)
        {
            _state.TurnOff();
        }

        public override void Undo()
        {
            _state.TurnOn();
        }
    }
}
