﻿using NUnit.Framework;
using OODPatternLab.Command.Remote;
using OODPatternLab.Command.State;
using System;
using TechTalk.SpecFlow;

namespace OODPatternLabTest
{
    [Binding]
    public class RemoteControlTestingSteps
    {
        RemoteControl _theRemote = new RemoteControl();
        int speedBeforeIncreasing = 0;
        int speedBeforeDecreasing = 0;

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
            _theRemote.PressButton(p0, null);
        }
        
        [When(@"I Turn the Knob Clockwise")]
        public void WhenITurnTheKnobClockwise()
        {
            speedBeforeIncreasing = StateStore.TheFan.Speed;
            _theRemote.TurnKnobClockWise();
        }
        
        [When(@"I Turn the Knob AntiClockwise")]
        public void WhenITurnTheKnobAntiClockwise()
        {
            speedBeforeDecreasing = StateStore.TheFan.Speed;
            _theRemote.TurnKnobAntiClockWise();
        }
        
             
        [Then(@"the Light should be On")]
        public void ThenTheLightShouldBeOn()
        {
            Assert.IsTrue(StateStore.TheLight.State);
        }
        
        [Then(@"the Light should be Off")]
        public void ThenTheLightShouldBeOff()
        {
            Assert.IsFalse(StateStore.TheLight.State);
        }
        
        [Then(@"the Speed Of Fan Should Increase")]
        public void ThenTheSpeedOfFanShouldIncrease()
        {
            ++speedBeforeIncreasing;
            if (speedBeforeIncreasing > 5)
                speedBeforeIncreasing = speedBeforeIncreasing - 6;

            Assert.IsTrue(StateStore.TheFan.Speed == speedBeforeIncreasing, "Actual Speed: " + StateStore.TheFan.Speed);
        }
        
        [Then(@"the Speed Of Fan Should Decrease")]
        public void ThenTheSpeedOfFanShouldDecrease()
        {
            --speedBeforeDecreasing;
            if (speedBeforeDecreasing < 0)
                speedBeforeDecreasing += 6;

            Assert.IsTrue(StateStore.TheFan.Speed == speedBeforeDecreasing, "Actual Speed: " + StateStore.TheFan.Speed);
        }
        
        [Then(@"the Television should be On")]
        public void ThenTheTelevisionShouldBeOn()
        {
            Assert.IsTrue(StateStore.TheTelevision.State);
        }
        
        [Then(@"the Television should be Off")]
        public void ThenTheTelevisionShouldBeOff()
        {
            Assert.IsFalse(StateStore.TheTelevision.State);
        }

        [When(@"I Set Channel (.*) by Pressing Button(.*)")]
        public void WhenISetChannelByPressingButton(string p0, int p1)
        {
            var channelNum = int.Parse(p0);
            _theRemote.PressButton(p1, channelNum);
        }

        [Then(@"the Television Channel should be set to (.*)")]
        public void ThenTheTelevisionChannelShouldBeSetTo(string p0)
        {
            Assert.IsTrue(StateStore.TheTelevision.ChannelNumber == int.Parse(p0));
        }


    }
}
