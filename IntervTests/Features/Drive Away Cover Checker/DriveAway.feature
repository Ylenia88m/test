Feature: DriveAway
	As a customer
	I want to use the Drive Away Checker
	In order to find out if a car is covered by Drive Away Insurance

Background: 
Given the user is on the DACC page
And the test Db is empty
And the table x has a record for 'OV12UYY' for StartDate '2022-02-09 16:26:00' and EndDate '2022-02-18 23:59:00'

@happyPath
Scenario Outline: search for valid registration Number displays results
	Given I enter <registrationNumbers>
	When I click Find Vehicle
	Then the search will produce a result
	And the result will have a cover Start and End date 

Examples: 
| registrationNumbers |
| OV12UYY             |
| OV12 UYY            |
| ov12uyy             |
	

@negative
Scenario: Inserting a null value gives no results
	When I click Find Vehicle
	Then the red error message is displayed
	

@negative
Scenario Outline: Insert a non existing registration numbers gives no results
	Given I enter <registrationNumbers>
	When I click Find Vehicle
	Then the error message is displayed

Examples: 
| registrationNumbers |
| OV12UYZ             |


@negative
Scenario Outline: Insert Invalid registration numbers gives no results
	Given I enter <registrationNumbers>
	When I click Find Vehicle
	Then the red error message is displayed

Examples: 
| registrationNumbers |
| LN1-2UY             |
| -OV12UYY            |
| ;OV12UYY            |


@positive
Scenario Outline: Searching sequence does not break the functionality
	Given I enter <registrationNumbers>
	When I click Find Vehicle
	Then the results boolean <hasResult> matches expectations


Examples: 
| registrationNumbers | hasResult |
| OV12UYZ             | False     |
| OV12UYY             | True      |
| LN12UYY             | False     |
| OV12UYY             | True      |











