Feature: Blood Pressure calculator

Scenario: Verify that low blood pressure category is set
Given Set the systolic pressure as 85
When Set dystolic pressure as 55
Then verify the category is low

Scenario: Verify that ideal blood pressure category is set
Given Set the systolic pressure as 100
When Set dystolic pressure as 65
Then verify the category is ideal

Scenario: Verify that preHigh blood pressure category is set
Given Set the systolic pressure as 130
When Set dystolic pressure as 85
Then verify the category is preHigh

Scenario: Verify that high blood pressure category is set
Given Set the systolic pressure as 150
When Set dystolic pressure as 95
Then verify the category is High
