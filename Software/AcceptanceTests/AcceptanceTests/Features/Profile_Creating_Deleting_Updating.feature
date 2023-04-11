Feature: Profile_Creating_Deleting_Updating

As a pet owner,
The user wants to have the ability to create a new pet profile, delete an existing pet profile, and edit data about an existing pet
So that he can manage profiles.

As a pet owner,
The user wants to have the ability to create a new pet profile, delete an existing pet profile, and edit data about an existing pet
So that he can manage profiles.

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
	And the user selects Profile
	And the user is on the Profile form

Scenario Outline: Creating a new pet profile with missing "<field>" field
	When the user selects the "Create new profile" option
	And the user fills out the required fields except for one field:
		| Ime  | Broj iskaznice | Pasmina ljubimca | BrojChipa | Tezina_Kg | Visina_Cm | Bilješke     |
		| Lana | 89076548       | Macka            | 78090907  | 5         | 10        | Zdrava macka |
	And the user clicks on "Create profile and digital card" button of feature A
	Then an error message "Nisu uneseni svi podaci!" should be displayed to the user to enter the required information

Scenario Outline: Entering invalid field values when creating a new pet profile
	When the user selects the "Create new profile" option
	And the user fills out the fields with the following information:
		| Ime     | Prezime     | Broj iskaznice | Pasmina ljubimca | BrojChipa | Tezina_Kg | Visina_Cm | Bilješke      |
		| Petrica | Stjepanovic | 1234567u       | Macka            | 76543210  | 6         | 10        | Debela macka. |
	And the user clicks on the "Create profile and digital card" button of feature B
	Then the user should see an error message indicating that some fields contain invalid values

Scenario: Fill out all fields correctly and create a new pet profile
	When the user selects the "Create new profile" option
	And the user fills out all fields with valid data:
		| Ime  | Prezime     | Broj iskaznice | Pasmina ljubimca | BrojChipa | Tezina_Kg | Visina_Cm | Bilješke          |
		| Beta | Stjepanovic | 12345676       | Macka            | 76543210  | 6         | 10        | Debela macketina. |
	And the user clicks on the "Create profile and digital card" button of feature C
	Then the new pet is visible in the drop-down menu of pet list

Scenario: Deleting a pet profile without selecting a pet
	When the user clicks on "Delete profile" without selecting a pet from the dropdown
	Then the user should be notified that he need to select a pet to delete

Scenario: Deleting the selected pet profile with no existing health records
	When the user selects the pet "Fleksi Stjepanovic" from the dropdown list of feature
	And the user clicks on the "Delete profile" button of feature D
	Then the deleted pet profile is no longer available in the dropdown list

Scenario: User updates pet information in their profile
	When the user selects the pet "Mara Stjepanovic" from the dropdown menu
	And the user updates certain enabled fields with the following information:
		| Ime  | Prezime     | Tezina_Kg | Visina_Cm |
		| Mela | Stjepanovic | 4         | 15        |
	And the user clicks the "Update profile" button
	Then the updated pet is automatically visible in the dropdown menu

Scenario: Newly registered user cannot select pet from dropdown
	When the user clicks logout
	Then the user is on the welcome form of feature
	And the user clicks button for login
	Then the user entering valid credentials:
		| Korisnicko | Lozinka |
		| ime1       | ime1    |
	And the user clicks button for login-homeForm
	And the user selects Profile form
	When the user clicks on the dropdown to select a pet
	Then the user should receive a message stating that at least one pet profile needs to be created before selecting a pet