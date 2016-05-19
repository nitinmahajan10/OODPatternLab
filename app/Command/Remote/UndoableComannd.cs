using System;

namespace OODPatternLab.Command.Remote
{
    public abstract class UndoableComannd<Ts, TUndo> : CommandBase<Ts> where Ts : class where TUndo : CommandBase<Ts>
    {
        public UndoableComannd(Ts state) : base(state)
        {        
            CanUndo = true;
        }

        public override void Undo()
        {
            _undoCommand = (TUndo)Activator.CreateInstance(typeof(TUndo), _state);
            base.Undo();
        }
    }
}
