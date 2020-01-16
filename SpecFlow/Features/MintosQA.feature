Feature: MintosQA

@web
Scenario: purchase a product
#	1. Go to web page https://lv.sportsdirect.com/
	Given I can open sportdirect home page
	When Home page title check
	When Accept Promo Banner
	When Login with 'womin37063@jancloud.net' and 'qwertyqwerty' 
	When Search field input 'Nike Air Max'
	When Click first item on results page
	When Select first available size on product page
	When Click add to Bag button
	When Click Checkout button
	When Click Continue Securely
	When Select standard delivery
	When Continue Securely
	When Pay With Card
	Then Go to Edit Bag
	And Clean up the Cart

		