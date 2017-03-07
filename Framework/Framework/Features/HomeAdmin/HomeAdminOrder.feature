Feature: TC_Home Admin page
	Verify that the "Orders list" link displays after clicking on Orders link at Home Admin page

#The Orders list link displays after clicking on Orders link
Scenario: TC_HomeAdmin_Orders_001
	Given I navigate to Home Admin page after login with valid account
	When I click on Orders link on the left menu  
	Then the Orders list link displays below it
