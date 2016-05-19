using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.Remote
{
    public abstract class CommandBase<Ts> where Ts: class 
    {
        protected Ts _state;
        protected CommandBase<Ts> _undoCommand;
        
        public CommandBase(Ts state)
        {
            _state = state;
            CanUndo = false;
        }

        public bool CanUndo { get; set; }
        
        public bool IsEnabled { get; set; }

        public abstract void Execute();
        
        public virtual void Undo()
        {
            if (_undoCommand != null)
                _undoCommand.Execute();
        }
    }
}
