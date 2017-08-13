Feature: StepByStepJourney
	Selecting  from the options " Your step-by-step journey"
@mytag
Scenario: 0.2Where to live page is loaded

Given New user is loged in  Successfully
Given "Your step-by-step journey" page is loaded
When User selects "Find your new home " 
Then new page "Rental advice" is clickable

Scenario: 0.3Recommended reading page is loaded

Given Login is done  Successfully
When User scroll to "Recommended reading" part
And User selects "Where to live" button
Then new page "Where to live" is uploaded


 

	