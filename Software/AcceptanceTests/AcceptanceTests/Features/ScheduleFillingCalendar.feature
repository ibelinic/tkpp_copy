Feature: ScheduleFillingCalendar

Application should provide user in the role of Veterinarian
a possibility to make his own schedule for work inside of the calendar.

Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	And User needs to enter details:
		| korisnickoIme | lozinka |
		| franka         | franka  |
	And User login
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Filling schedule with appointment for a week
	Given User clicks button his Schedule
	When User select button for adding to the schedule
	And Form for adding schedule is open
	And User then fill with the following details:
	| datum      | vrijeme_pocetka | vrijeme_zavrsetka | opis             | ljubimac   |
	| 14.4.2023. | 12:00           | 13:00             | Pregled ljubimca | Missy Anic |
	And Select button for adding
	Then User should be able to view new appointment on the Schedule form

Scenario: Quit adding new appointment
	Given User clicks button his Schedule
	When User select button for adding to the schedule
	And Form for adding schedule is open
	And Select button for canceling
	Then User should be able to view new appointment on the Schedule form
