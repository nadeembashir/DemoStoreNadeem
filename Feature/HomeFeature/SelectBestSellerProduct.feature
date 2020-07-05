Feature: SelectBestSellerProduct
	
@mytag
Scenario: Select best seller product
	Given I am on Home  page
	When I click the Best Seller (WaistTieDress)
	Then WaistTieDress is selected
