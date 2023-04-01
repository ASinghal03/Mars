Feature: MarsFeature1

@mytag
Scenario: Added New Skill to Profile Successfully
	Given I Logged Into Mars Portal Successfully
	When I Navigate to Skills Tab
	When Add New Skill
	Then New Skill Should Be Added

Scenario Outline: Edit an Existing Skill Record
Given I Logged Into Mars Portal Successfully
When I Navigate to Skills Tab
And I Update '<Skill>','<Level>' to an existing skill record
Then '<Skill>','<Level>' is modified successfully

Examples:
| Skill			| Level        |
| Team Player	| Beginner     |
| Communication | Expert       |

Scenario Outline: Record for skill Deletion successful
Given I Logged Into Mars Portal Successfully
When I Navigate to Skills Tab
And I Click Delete button
Then Record is deleted
