Feature: AvailableVeterinarians

As a pet owner,
The user wants to have the ability to view all available veterinarians within the calendar
So that he can independently schedule an appointment for his pet.

Background:
	Given the user has launched the system of feature A
	And the user is on the welcome form
	When the user clicks on the button "Prijava"
	Then the user is on the login form
	And the user needs to enter details:
		| korisnickoIme | lozinka |
		| stjepan       | stjepan |
	And the user login
	Then the user will be successfully redirected to the initial form for owner
	And the user selects Available veterinarians
	And the user is on the View available veterinarians form

Scenario: Veterinarian not selected from the dropdown menu
	When the user select a veterinarian without termins
	Then the user should only see an empty table of data

Scenario: Veterinarian is selected from the dropdown menu
	When the user selects "Klara Klaric" from the "Vet Selection" dropdown
	Then the user should see a list of appointments for "Klara Klaric" with the following columns: ID, Date, Start, End