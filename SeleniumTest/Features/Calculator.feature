Feature: WebApp

	Scenario: Test ideal Blood Preesure
		Given launch url
		Given Systolic value 110
		Given Diastolic value 70
		When Click submit
		Then Verfiy the actual value of message is equal to Ideal Blood Pressure

	Scenario: Test Low Blood Pressure
		Given launch url
		Given Systolic value 80
		Given Diastolic value 50
		When Click submit
		Then Verfiy the actual value of message is equal to Low Blood Pressure

	Scenario: Test Pre-High Blood Pressure
		Given launch url
		Given Systolic value 130
		Given Diastolic value 85
		When Click submit
		Then Verfiy the actual value of message is equal to Pre-High Blood Pressure

	Scenario: Test High Blood Pressure
		Given launch url
		Given Systolic value 170
		Given Diastolic value 95
		When Click submit
		Then Verfiy the actual value of message is equal to High Blood Pressure

