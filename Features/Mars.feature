Feature: MarsFeature1

@mytag
Scenario:Test 1 - Adding Profile Details
	Given I Logged Into Mars Portal Successfully
	When Add all details to profile page
	Then Profile is updated successfully
	

Scenario:Test 2 -  Edit Following 4 records successfully: Language, Skill, Education, Certificate
	Given I Logged Into Mars Portal Successfully
	When Edit Following Records:Language, Skill, Education, Certificate
	Then Following records are updated successfully:Language, Skill, Education, Certificate

Scenario:Test 3 -  Following 4 records should be deleted successfully: Language, Skill, Education, Certificate
	Given I Logged Into Mars Portal Successfully
	When Delete following records:Language, Skill, Education, Certificate
	Then Following records are deleted successfully:Language, Skill, Education, Certificate

Scenario:Test 4 -  Skill Listing Creation
Given I Logged Into Mars Portal Successfully
When I Click on Share Skill
And I Update all necessary fields
Then A skill listing is created successfully

Scenario:Test 5 -  Skills Listing search
Given I Logged Into Mars Portal Successfully
When Enter Skill to be searched and Click on Search
Then Results should be filtered based on search

Scenario:Test 6 -  Adding new Language Record
Given I Logged Into Mars Portal Successfully
When Pre Existing record is entered
And Click on Add
Then A new Record should not be created
And Should result in a notification "Duplicated data"

Scenario:Test 7 -  Adding new Skill Record
Given I Logged Into Mars Portal Successfully
When Pre Existing record is entered
And Click on Add
Then A new Record should not be created
And Should result in a notification "This skill is already exist in your skill list."

Scenario:Test 8 -  Adding new Education Record
Given I Logged Into Mars Portal Successfully
When Pre Existing record is entered
And Click on Add
Then A new Record should not be created
And Should result in a notification "This information is already exist."

Scenario:Test 9 -  Adding new Certificate Record
Given I Logged Into Mars Portal Successfully
When Pre Existing record is entered
And Click on Add
Then A new Record should not be created
And Should result in a notification "This information is already exist."