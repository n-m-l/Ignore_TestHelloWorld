Feature: Emit
	I want observers to be able to register an interest in receiving a hello world event

@mytag

Scenario: Register for a hello world event
	Given I have registered for a hello world event
	When SayHello is run
	Then I should receive the hello world message