using NUnit.Framework;
using OODPatternLab.Command.Remote;
using OODPatternLab.Command.State;
using TechTalk.SpecFlow;

namespace OODPatternLabTest
{
    [Binding]
    public class RemoteControlTestingSteps
    {
        RemoteControl _theRemote = new RemoteControl();

        [Given(@"I have configured Remote")]
        public void GivenIHaveConfiguredRemote(Table table)
        {
            foreach (TableRow theRow in table.Rows)
            {
                _theRemote.WireButtonCommand(int.Parse(theRow[0]), theRow[1]);
            }
        }
        
        [Given(@"Wired Knob Button To Fan Speed")]
        public void GivenWiredKnobButtonToFanSpeed()
        {
            _theRemote.WireKnobButton("IncreaseFan", "DecreaseFan");
        }
        
        [Given(@"Remote is Wired")]
        public void GivenRemoteIsWired()
        {
            
        }
        
        [When(@"I press Button(.*)")]
        public void WhenIPressButton(int p0)
        {
            _theRemote.PressButton(p0);
        }
        
        [When(@"I Turn the Knob Clockwise")]
        public void WhenITurnTheKnobClockwise()
        {
            _theRemote.TurnKnobClockWise();
        }
        
        [When(@"I Turn the Knob AntiClockwise")]
        public void WhenITurnTheKnobAntiClockwise()
        {
            _theRemote.TurnKnobAntiClockWise();
        }
        
        [When(@"I Set Channel (.*) by Pressing Button(.*)")]
        public void WhenISetChannelByPressingButton(string p0, int p1)
        {
            var channelNum = int.Parse(p0);

            _theRemote.PressButton(p1);
        }
        
        [Then(@"the Light should be On")]
        public void ThenTheLightShouldBeOn()
        {
            Assert.IsTrue(StateStoe.TheLight.State);
        }
        
        [Then(@"the Light should be Off")]
        public void ThenTheLightShouldBeOff()
        {
            Assert.IsFalse(StateStoe.TheLight.State);
        }
        
        [Then(@"the Speed Of Fan Should Increase")]
        public void ThenTheSpeedOfFanShouldIncrease()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Speed Of Fan Should Decrease")]
        public void ThenTheSpeedOfFanShouldDecrease()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Television should be On")]
        public void ThenTheTelevisionShouldBeOn()
        {
            Assert.IsTrue(StateStoe.TheTelevision.State);
        }
        
        [Then(@"the Television should be Off")]
        public void ThenTheTelevisionShouldBeOff()
        {
            Assert.IsFalse(StateStoe.TheTelevision.State);
        }
        
        [Then(@"the Television Channel should be set to (.*)")]
        public void ThenTheTelevisionChannelShouldBeSetTo(string p0, Table table)
        {
            Assert.IsTrue(StateStoe.TheTelevision.ChannelNumber == int.Parse(p0));
        }
    }
}
