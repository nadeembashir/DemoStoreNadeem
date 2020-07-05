Feature: SelectCountryCurrency
	

@mytag
Scenario: Select the Country and Currency
	Given I  am on xcart  website 
	When I have selected all details and click save
	Then details are saved
