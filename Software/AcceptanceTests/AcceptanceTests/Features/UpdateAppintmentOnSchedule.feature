Feature: UpdateAppintmentOnSchedule

User in role of Veterinarian should be able to update any appointment anytime.

Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	And User needs to enter details:
		| korisnickoIme | lozinka |
		| franka         | franka  |
	And User login
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Appointment date update
	Given User clicks button his Schedule
	When User selects appointment
	And User selects button for update
	And User enter details:
	| datum |
	| 10.4.2023. |
	And User press button "Update"
	Then User should be able to view new appointment on the Schedule form

Scenario: Cancelling update of appointment
	Given User clicks button his Schedule
	When User selects appointment
	And User selects button for update
	And User select button for canceling
	Then User should be able to view new appointment on the Schedule form