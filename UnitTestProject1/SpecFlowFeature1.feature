Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result shouldt be 120 on the screen


@mytag
Scenario: toujours vrai
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then toujours 2 vrai

@mytag
Scenario: toujours faux
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then toujours 2 faux
