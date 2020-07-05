Feature: SubscribeEmail
	
@mytag
Scenario: Subscribe Email
	Given I am on home page
	When I subscribe the email 'email@email.com'
	Then I am successfully able to subscribe
