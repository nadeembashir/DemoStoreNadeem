Feature: SelectSaleProduct


@mytag
Scenario: Select Sale Product
	Given I navigated the sales page
	When I selected the sales item
	Then I am taken to the selected sales item
