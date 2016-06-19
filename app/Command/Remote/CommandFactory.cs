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
                return new LightsOnCommand(StateStore.TheLight);
            }

            if (commandName.Equals("TurnOffLight"))
            {
                return new LightsOffCommand(StateStore.TheLight);
            }

            if (commandName.Equals("TurnOnTelevision"))
            {
                return new TelevisionOnCommand(StateStore.TheTelevision);
            }

            if (commandName.Equals("TurnOffTelevision"))
            {
                return new TelevisionOffCommand(StateStore.TheTelevision);
            }

            if (commandName.Equals("SetTvChannel"))
            {
                return new TelevisionSetChannelCommand(StateStore.TheTelevision, 0);
            }

            if (commandName.Equals("DecreaseFan"))
            {
                return new FanKnobAntiClockwiseCommand(StateStore.TheFan);
            }

            if (commandName.Equals("IncreaseFan"))
            {
                return new FanKnobClockwiseCommand(StateStore.TheFan);
            }

            throw new Exception("Command not found : " + commandName);
        }
    }
}
