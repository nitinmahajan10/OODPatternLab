using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.Remote
{
    public abstract class CommandBase<Ts> : ICommand where Ts: class 
    {
        protected Ts _state;
                
        public CommandBase(Ts state)
        {
            _state = state;
            CanUndo = false;
        }

        public bool CanUndo { get; set; }
        
        public bool IsEnabled { get; set; }

        public abstract void Execute(object data);
        public abstract void Undo();
    }
}
