Feature: TMFeature

As a Turnup portal user
I would like to create, edit and delete time and material records
So that I can manaage employees time and material successfully

@tag1
Scenario: create time record with valid datails
	Given I logged into TurnUp portal successfully
	When I navigate to time and material page
	When I create a new time record
	Then the recrd should be created successfully
