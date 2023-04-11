Feature: RecordingTreatments

As a veterinarian,
The user wants to have the ability to record pet treatments in a digital card,
So that he can track the health status of pets.

Background:
	Given the user has launched the system of feature A
	And the user is on the welcome form
	When the user clicks on the button "Prijava"
	Then the user is on the login form
	And the user needs to enter vet details:
		| korisnickoIme | lozinka   |
		| veterinar     | veterinar |
	And the user login
	Then the user will be successfully redirected to the initial form for vet
	And the user selects Recording
	And the user is on the Recording form

Scenario: User doesn't select a pet from the dropdown
	When the user doesn't select a pet from the dropdown
	Then the form's functionalities should be disabled

Scenario: Update existing visit with disease and medicine
	When the user selects a desired pet from the dropdown menu: "Rio Anic"
	And the user selects an existing visit date from the dropdown menu of featuring
	And the user fills in all remaining fields with meaningful data:
		| Bolest       | OpisB              | DatumB     | Lijek       | OpisL              |
		| slaba bolest | opis slabe bolesti | 5.11.2022 | slabi lijek | opis slabog lijeka |
	And the user clicks on the "Update existing visit" button
	Then the system should successfully update the selected appointment and clear all fields

Scenario: Saving a new pet visit without filling in the field "Reason for visit"
	When the user selects the pet "Rio Anic" from the dropdown menu of feature
	And the user selects a new visit date of his choice:
		| datum      |
		| 12.4.2022. |
	And the user does not fill in the "Reason for visit" field
	And the user clicks on "Save visit" button of feature
	Then the user should receive an error message indicating that all fields are required to save the visit

Scenario: Adding a new visit record for a pet without adding disease and medication
	When the user selects the pet "Rio Anic" from the dropdown list
	And the user selects a new visit date of his choice of feature:
		| datum      |
		| 17.4.2022. |
	And the user fills in the reason field with any reason:
		| razlog            |
		| jako dobar razlog |
	And the user clicks saving button of feature
	Then the previous data in the fields should be cleared automatically because visit is saved

Scenario: Record a new visit of a pet with disease and medication
	When the user selects a pet "Rio Anic" from the dropdown menu
	And the user selects a date and reason for the visit:
		| datumPosjete | razlog       |
		| 13.12.2023   | dobar razlog |
	And the user clicks on "Save visit" checkbox
	Then a new visit is successfully recorded so the fields for disease and medication are enabled
	And the user fills in the fields for disease and medication with valid data and selects a date for the start of symptoms:
		| Bolest             | OpisB                 | DatumB     | Lijek          | OpisL                 |
		| slabasnasta bolest | opis slabasne bolesti | 11.12.2022 | slabasni lijek | opis slabasnog lijeka |
	And the user clicks on "Record a new visit" button
	Then the new visit is successfully recorded so all fields are cleared

Scenario: Symptom onset date is later than the visit date
	Given the user selects the desired pet from the dropdown menu: "Rio Anic"
	When the user selects existing visit date of pet
	Then the fields for diseases and medications are enabled
	And the user fills in the fields for disease and medication with valid data:
		| Bolest       | OpisB       | Lijek       | OpisL      |
		| naziv bolest | opis bolest | naziv lijek | opis lijek |
	And the user selects the symptom onset date:
		| datumSimptoma |
		| 23.12.2022.    |
	And the user clicks on "Update existing visit" button of feature Recording
	Then the system should display an error message saying that the symptom onset date must be earlier than the visit date

Scenario: Cancel selection of an existing date
	When the user selects the desired pet from the dropdown list: "Rio Anic"
	And the user selects an existing date by mistake
	And the user clicks on cancellation button
	Then the system should automatically clear the previous data and the selected date