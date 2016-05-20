using OODPatternLab.Command.State;
using System;

namespace OODPatternLab.Command.Remote
{
    public class CommandFactory
    {
        public ICommand CreateCommand(string commandName)
        {
            if (commandName.Equals("TurnOnLight"))
            {
                return new LightsOnCommand(StateStoe.TheLight);
            }

            if (commandName.Equals("TurnOffLight"))
            {
                return new LightsOffCommand(StateStoe.TheLight);
            }

            if (commandName.Equals("TurnOnTelevision"))
            {
                return new TelevisionOnCommand(StateStoe.TheTelevision);
            }

            if (commandName.Equals("TurnOffTelevision"))
            {
                return new TelevisionOffCommand(StateStoe.TheTelevision);
            }

            if (commandName.Equals("SetTvChannel"))
            {
                return new TelevisionSetChannelCommand(StateStoe.TheTelevision, 0);
            }

            if (commandName.Equals("DecreaseFan"))
            {
                return new FanKnobAntiClockwiseCommand(StateStoe.TheFan);
            }

            if (commandName.Equals("IncreaseFan"))
            {
                return new FanKnobClockwiseCommand(StateStoe.TheFan);
            }

            throw new Exception("Command not found : " + commandName);
        }
    }
}
