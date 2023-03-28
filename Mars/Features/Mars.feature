Feature: MarsFeature1

@mytag
Scenario: Login into Mars Portal
	Given I navigate to Mars Portal Successfully
	When Click on Sign In
	And  Feed Credentials
	Then Should be on Home page
