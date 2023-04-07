Feature: RecordingTreatments

As a veterinarian,
The user wants to have the ability to record pet treatments in a digital card,
So that he can track the health status of pets.

Background:
	Given the user has launched the system
	And the user has logged in successfully as a veterinarian with username "veterinar" and password "veterinar"
	And the user is on the "Record" page

Scenario: User doesn't select a pet from the dropdown
	And the user doesn't select a pet from the dropdown
	Then the form's functionalities should be disabled
	And the user should be informed to select a pet before proceeding

Scenario: Adding to existing visit without illness and medication
	When the user selects the desired pet "Rio Anic" from the dropdown
	And the user selects the existing appointment "21/12/2022" from the dropdown
	And the user leaves the fields for illness and medication empty
	And the user clicks on "Update existing visit" button
	Then the system should prompt the user that the fields for illness and medication are required
	And the system should not successfully complete adding to the existing visit

Scenario: Update existing visit with disease and medicine
	Given the user launches the system and successfully logs in as a veterinarian with valid credentials
	And the user is on the "Record" form
	When the user selects a desired pet from the dropdown menu: "Rio Anic"
	And the user selects an existing visit date from the dropdown menu: "21/12/2022"
	And the user fills in all remaining fields with meaningful data
	And the user enters the disease for the selected visit and its medicine
	And the user clicks on the "Update existing visit" button
	Then the system should successfully update the selected appointment and clear all fields
	And the user should receive a confirmation message about the successful update

Scenario: Saving a new pet visit without filling in the field "Reason for visit"
	When the user selects the pet "Arno Anic" from the dropdown menu
	And the user selects a new visit date of his choice
	And the user does not fill in the "Reason for visit" field
	And the user clicks on the "Save visit" button
	Then the system should not save the new visit
	And the user should receive an error message indicating that all fields are required to save the visit

Scenario: Adding a new visit record for a pet without adding disease and medication
	When the user selects the pet "Arno Anic" from the dropdown list
	And the user selects a new visit date of his choice
	And the user fills in the "Reason for visit" field with any reason
	And the user clicks the "Save visit" button
	Then a new visit record should be saved successfully
	And the previous data in the fields should be cleared automatically
	And the user should see a success message

Scenario: Cannot record new visit without filling in disease and medication fields
	When the user selects "Ratko Stjepanovic" from the dropdown list of pets
	And the user selects a desired date and reason for the visit
	And the user clicks on the "Save visit" checkbox
	Then the visit should be saved successfully
	And the fields for disease and medication should be enabled
	When the user clicks on "Record new visit" without filling in the fields for disease and medication
	Then the user should receive an error message stating that it is not possible to record a new visit without filling in the fields for disease and medication
	And the new visit should not be recorded

Scenario: Record a new visit of a pet with disease and medication
	When the user selects a pet "Ratko Stjepanovic" from the dropdown menu
	And the user selects a date and reason for the visit
	And the user clicks on "Save visit" checkbox
	Then a new visit is successfully recorded
	And the fields for disease and medication are enabled
	And the user fills in the fields for disease and medication with valid data and selects a date for the start of symptoms
	And the user clicks on "Record a new visit" button
	Then the new visit is successfully recorded and all fields are cleared
	And the user receives a visible confirmation of the successful recording of the new visit

Scenario: Symptom onset date is later than the visit date
	And the user selects the desired pet from the dropdown menu: "Ratko Stjepanovic"
	And the user selects the date "6.4.2023" while filling in the visit reason with desired, but valid data
	And the user clicks on the "Save visit" checkbox
	Then the visit is saved and the fields for diseases and medications are enabled
	And the user fills in the fields for disease and medication with valid data
	And the user selects the symptom onset date as "12.4.2023"
	And the user clicks on "Record new visit" button
	Then the system should display an error message saying that the symptom onset date must be earlier than the visit date

Scenario: Cancel selection of an existing date
	When the user selects the desired pet from the dropdown list: "Ratko Stjepanovic"
	And the user selects an existing date by mistake
	And the user clicks on "Cancel Selection" button
	Then the system should automatically clear the previous data and the selected date
	And the user should be returned to the initial state of the form
	And the selection should be successfully cancelled