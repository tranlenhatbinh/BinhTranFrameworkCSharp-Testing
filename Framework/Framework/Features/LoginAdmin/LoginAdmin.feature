Feature: LoginAdmin
	Verify that user is able to login Admin page successfully

@mytag
Scenario: TC_LoginAdminPage
	Given I navigate to Login Admin page
	When I login with valid account
	Then the Home Admin page displays
