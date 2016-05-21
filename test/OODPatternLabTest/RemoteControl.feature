Feature: Remote Control Testing
	In order to reduce my fatigue
	As a lazy person
	I want to control devices from remote

Background: Wiring Up the Remote
Given I have configured Remote 
| Button | Command           |
| 1      | TurnOnLight       |
| 2      | TurnOffLight      |
| 3      | TurnOnTelevision  |
| 4      | TurnOffTelevision |
| 5      | SetTvChannel      |
And Wired Knob Button To Fan Speed


@CommandDesignPattern
Scenario: Turn On Light
	Given Remote is Wired
	When I press Button1
	Then the Light should be On

@CommandDesignPattern
Scenario: Turn Off Light
	Given Remote is Wired
	When I press Button2
	Then the Light should be Off


@CommandDesignPattern
Scenario: Increase Fan Speed
	Given Remote is Wired 
	When I Turn the Knob Clockwise
	Then the Speed Of Fan Should Increase


@CommandDesignPattern
Scenario: Decrease Fan Speed
	Given  Remote is Wired
	When I Turn the Knob AntiClockwise
	Then the Speed Of Fan Should Decrease


@CommandDesignPattern
Scenario: Turn Television On
	Given  Remote is Wired
	When I press Button3
	Then the Television should be On

@CommandDesignPattern
Scenario: Turn Television Off
	Given  Remote is Wired
	When I press Button4
	Then the Television should be Off

@CommandDesignPattern
Scenario Outline: Set Television Channel
	Given  Remote is Wired
	When I Set Channel <ChannelNumber> by Pressing Button5	
	Then the Television Channel should be set to <ChannelNumber>

	Examples:
	|ChannelNumber|
	|201|
	|301|
	|401|