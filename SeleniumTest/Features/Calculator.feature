Feature: WebApp

Scenario: Try testing
	Given launch url
	Given Systolic value 110
	Given Diastolic value 70
	When Click submit
	Then Verfiy the actual value of message is equal to Ideal Blood Pressure