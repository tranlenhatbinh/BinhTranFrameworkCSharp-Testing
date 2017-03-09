Feature: TC_Home Admin page
	Verify that the "Orders list" link displays after clicking on the Orders link at Home Admin page
	Verify that the Orders page displays after clicking on the Orders list link at Home Admin page

#Verify that the "Orders list" link displays after clicking on the Orders link at Home Admin page

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

Scenario: TC_HomeAdmin_Orders_003
	Given I navigate to Login Admin page
	When I login with valid account
		And I click on Orders link on the left  
		And I click on Orders list link 
	    And I enter Order ID on OrderID textbox
		And I click on Search button
    Then the information of this OrderID displays 

Scenario: TC_HomeAdmin_Orders_004
	Given I navigate to Login Admin page
	When I login with valid account
		And I click on Orders link on the left  
		And I click on Orders list link 
	    And I select payment status option from Payment statuses dropdown
		And I click on Search button
    Then all appropriate Orders of this payment status option display 

Scenario: TC_HomeAdmin_Orders_005
	Given I navigate to Login Admin page
	When I login with valid account
		And I click on Orders link on the left  
		And I click on Orders list link 
	    And I select shipping status option from Shipping statuses dropdown
		And I click on Search button
    Then all appropriate Orders of this shipping status option display 

Scenario: TC_HomeAdmin_Orders_006
	Given I navigate to Login Admin page
	When I login with valid account
		And I click on Orders link on the left  
		And I click on Orders list link 
	    And I select shipping status option from Shipping statuses dropdown
		And I click on Search button
    Then all appropriate Orders of this shipping status option display 