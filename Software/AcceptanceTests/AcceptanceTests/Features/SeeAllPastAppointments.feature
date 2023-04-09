Feature: SeeAllPastAppointments

User as a vetereniar should be able to see all his past appointments.

Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	And User needs to enter details:
		| korisnickoIme | lozinka |
		| franka         | franka  |
	And User login
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Viewing all past appointments from schedule
	Given User clicks button his Schedule
	When User selects button for past appointments
	And User need to select button for going back
	Then User should be able to view new appointment on the Schedule form
