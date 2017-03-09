Feature: TC_Home Admin page
	Verify that the "Orders list" link displays after clicking on the Orders link at Home Admin page

Scenario: TC_HomeAdmin_Orders_001
	Given I navigate to Login Admin page
	When I login with valid account
		And I click on Orders link on the left  
	Then Orders list link displays below it 

Scenario: TC_HomeAdmin_Orders_002
	Given I navigate to Login Admin page
	When I login with valid account
		And I click on Orders link on the left  
		And I click on Orders list link 
	Then Orders page displays