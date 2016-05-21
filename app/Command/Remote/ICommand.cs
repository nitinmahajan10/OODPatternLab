﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPatternLab.Command.Remote
{
    public interface ICommand
    {
        void Execute(object data);

        void Undo();
    }
}
