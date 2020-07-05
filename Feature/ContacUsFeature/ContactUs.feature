Feature: ContactUsFeature

@mytag
Scenario: Contact Us (Without Login)
	Given I am on Contact us page
	When I enter all deatails and Click Send button
	Then request is sent
