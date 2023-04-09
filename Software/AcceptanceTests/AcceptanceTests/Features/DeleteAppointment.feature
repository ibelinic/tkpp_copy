Feature: DeleteAppointment

User in a role of veterinarian should be able to delete appointment.

Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	And User needs to enter details:
		| korisnickoIme | lozinka |
		| franka         | franka  |
	And User login
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Deleting appointment from schedule
	Given User clicks button his Schedule
	When User selects appointment
	When User selects button fo deleting appointment
	Then User should be able to view new appointment on the Schedule form
