Feature: AvailableVeterinarians

As a pet owner,
The user wants to have the ability to view all available veterinarians within the calendar
So that he can independently schedule an appointment for his pet.

Background:
	Given the user has launched the system
	And the user has logged in successfully as a pet owner with username "stjepan" and password "stjepan"
	And the user is on the "View available veterinarians" page

Scenario: Veterinarian not selected from the dropdown menu
	When the user does not select a veterinarian from the dropdown menu
	Then the system should not display any feedback to the user
	And the user should only see an empty table of data

Scenario: Veterinarian is selected from the dropdown menu
	When the user selects "Klara Klaric" from the "Vet Selection" dropdown
	Then the user should see a list of appointments for "Klara Klaric" with the following columns: ID, Date, Start, End
	And the list should only include appointments for today or later

Scenario: Return to Main Screen
	When the user selects "Franka Frankic" from the dropdown list
	And the user wants to go back to the home screen
	Then the user should be able to click the back button and return to the home screen