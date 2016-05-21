using OODPatternLab.Command.State;
using System.Collections.Generic;

namespace OODPatternLab.Command.Remote
{
    public class TelevisionSetChannelCommand : CommandBase<Television>
    {
        Stack<int> UndoStack = new Stack<int>();
        public int ChannelNumber { get; set; }

        public TelevisionSetChannelCommand(Television state, int channel) : base(state)
        {
            ChannelNumber = channel;
        }

        public override void Execute(object data)
        {
            UndoStack.Push(_state.ChannelNumber);
            ChannelNumber = (int)data;
            _state.SetChannel(ChannelNumber);
        }

        public override void Undo()
        {
            if (UndoStack.Count == 0)
                return;

            _state.SetChannel(UndoStack.Pop());
        }
    }
}
