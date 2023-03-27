Feature: Mars

@mytag
Scenario: Login into Mars Portal
	Given I logged into portal successfully
	When I navigate to Skills Field
	And  Click on Add New Button
	And Fill new Skill in Add Skill Text box
	And Choose Skill Level From Drop Down
	And Click on Add Button
	Then Skill should be added to my profile

Scenario Outline: 
	Given 
	When 
	And 
	Then 