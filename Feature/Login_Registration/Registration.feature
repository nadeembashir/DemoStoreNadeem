Feature: DemoStoreRegistration
So that I can use the site
I need to register
@RegistraionUser
Scenario: Valid Registration
	Given I navigate to the site
	And I click on SignIN/SignUp link
	And I click CretaNewAccount link
	When I entered email "test@email1.com"
	And I enter Password
	And I confirm password
	And I click the create button
	Then I should be registered