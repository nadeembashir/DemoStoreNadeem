Feature: Login
	

@mytag
Scenario: Login to DemoStore 
	Given I navigate to the DemoStore site
	And I entered the crednetials
	When I click signin button
	Then I successfully logged in
Scenario: Logout successufully
When I click Logout button
Then I can successfully loged out
