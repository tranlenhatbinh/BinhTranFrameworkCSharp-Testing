Feature: TC_Home Admin page
	Verify that user is able to login at the Login page admin

@mytag
Scenario: User is able to login with valid username and password 
	Given I navigate to Login page Admin
	When I login to Admin Xcart site with valid account
	
