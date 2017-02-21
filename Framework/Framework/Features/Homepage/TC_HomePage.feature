Feature: TC_HomePage
	Verify the Home link displays at Home page

@mytag
Scenario: Homepage displays
	Given I navigate to Home page
	Then the Home link displays on the screen
