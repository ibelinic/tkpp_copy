Feature: Profile_Creating_Deleting_Updating

As a pet owner,
The user wants to have the ability to create a new pet profile, delete an existing pet profile, and edit data about an existing pet
So that he can manage profiles.

Background:
	Given the user has launched the system
	And the user has logged in successfully as a pet owner with username "stjepan" and password "stjepan"
	And the user is on the "Profile" page

Scenario Outline: Creating a new pet profile with missing "<field>" field
	When the user selects the "Create new profile" option
	And the user fills out the required fields except for the "<field>" field
	And the user clicks on "Create profile and digital card" button
	Then an error message should be displayed to the user to enter the required "<field>" information
Examples:
	| Ime | Prezime | Broj iskaznice | Pasmina ljubimca | BrojChipa | Tezina_Kg | Visina_Cm | Bilješke |
	|     |         |                |                  |           |           |           |          |

Scenario: Entering invalid field values when creating a new pet profile
	When the user selects the "Create new profile" option
	And the user fills out the fields with the following information:
		| Ime     | Prezime     | Broj iskaznice | Pasmina ljubimca | BrojChipa | Tezina_Kg | Visina_Cm | Bilješke      |
		| Petrica | Stjepanovic | 1234567u       | Macka            | 76543210  | 6         | 10        | Debela macka. |
	And the user clicks the "Create profile and digital card" button
	Then the user should see an error message indicating that some fields contain invalid values
	And the pet profile should not be created

Scenario: Fill out all fields correctly and create a new pet profile
	When the user selects the "Create new profile" option
	And the user fills out all fields with valid data
	And the user clicks on the "Create profile and digital card" button
	Then the new pet profile is successfully created
	And the new pet is visible in the drop-down menu of pet list
Examples:
	| Ime     | Prezime     | Broj iskaznice | Pasmina ljubimca | BrojChipa | Tezina_Kg | Visina_Cm | Bilješke      |
	| Petrica | Stjepanovic | 12345677       | 76543210         | Macka     | 6         | 10        | Debela macka. |

Scenario: Deleting a pet profile without selecting a pet
	When the user clicks on "Delete profile" without selecting a pet from the dropdown
	Then the user should be notified that he need to select a pet to delete


Scenario: Attempting to delete a pet profile with existing health records
	When the user selects the pet "Mara Stjepanovic" from the dropdown list
	And the user clicks on the "Delete profile" button
	Then the system displays an error message saying "Cannot delete the selected pet profile as there are health records associated with it"
	And the system does not delete the pet profile

Scenario: Deleting the selected pet profile with no existing health records
	When the user selects the pet "Petrica Stjepanovic" from the dropdown list
	And the user clicks on the "Delete profile" button
	Then the system displays a confirmation message saying "Are you sure you want to delete this pet profile?"
	And the user clicks on the "Confirm" button in the confirmation message
	And the system displays a success message saying "The selected pet profile has been deleted"
	Then the system redirects the user to the Profile page
	And the deleted pet profile is no longer available in the dropdown list

Scenario: User updates pet information in their profile
	When the user selects the pet "Mara Stjepanovic" from the dropdown menu
	And the user updates certain enabled fields with the following information:
		| Ime  | Prezime     | Tezina_Kg | Visina_Cm |
		| Maza | Stjepanovic | 5         | 10        |
	And the user clicks the "Update profile" button
	Then the pet information is successfully updated and displayed on the form
	And the updated pet is automatically visible in the dropdown menu
	And the user receives a success message stating that the pet information was updated successfully

Scenario: Newly registered user cannot select pet from dropdown
	Given the user has launched the system from the beginning
	And the user has logged in successfully as a pet owner with username "ime1" and password "ime1"
	And the user is on the Profile page
	When the user clicks on the dropdown to select a pet
	Then the user should receive a message stating that at least one pet profile needs to be created before selecting a pet
	And the user should be given an option to "Cancel", which redirects them to the home screen
	And the user should be given an option to "Create new profile", which redirects them to the profile creation form