Feature: SauceDemo


@mytag
Scenario: Valid Login Details
	Given I am on Saucedemo Page
	When I enter username and password
	Then I am logged in