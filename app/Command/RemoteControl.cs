using OODPatternLab.Command.State;
using System.Collections.Generic;

namespace OODPatternLab.Command.Remote
{
    public class RemoteControl
    {
        Dictionary<int, ICommand> Buttons = new Dictionary<int, ICommand>();
        ICommand KnobClockwiseCommand;
        ICommand KnobAntiClockwiseCommand;

        readonly CommandFactory theCommandFactory = new CommandFactory();

        public void WireButtonCommand(int button, string command)
        {
            var theCommand = theCommandFactory.CreateCommand(command);

            if (Buttons.ContainsKey(button))
                Buttons[button] = theCommand;
            else
                Buttons.Add(button, theCommand);
        }

        public void WireKnobButton(string clockwiseCommand, string antiClockwiseCommand)
        {
            KnobClockwiseCommand = theCommandFactory.CreateCommand(clockwiseCommand);
            KnobAntiClockwiseCommand = theCommandFactory.CreateCommand(antiClockwiseCommand);
        }

        public void PressButton(int button)
        {
            if (Buttons.ContainsKey(button))
            {
                Buttons[button].Execute();
            }
        }

        public void TurnKnobClockWise()
        {
            if (KnobClockwiseCommand == null)
                return;

            KnobClockwiseCommand.Execute();
        }

        public void TurnKnobAntiClockWise()
        {
            if (KnobAntiClockwiseCommand == null)
                return;

            KnobAntiClockwiseCommand.Execute();
        }
    }
}
