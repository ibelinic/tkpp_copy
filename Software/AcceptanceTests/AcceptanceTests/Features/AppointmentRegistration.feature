Feature: AppointmentRegistration

As a owner
I should be able to register an appoitment

Background: 
	Given I launched the System
	And I am on the welcome form
	When I click on the button prijava
	Then I am on the login form
	And I need to Enter:
		| korisnickoIme | lozinka |
		| stjepan       | stjepan |
	And I Login
	Then I will be successfully redirected to the form for owner

Scenario: Appointment registration without changing the appointment and pet
	When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Klara Klaric from the dropdown list of veterinarians
	And I click the button Prijavi termin
	Then I should receive a message stating Ne mozete prijaviti termin u trenutnom vremenu

Scenario: Registration of an appointment that is taken
	When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Klara Klaric from the dropdown list of veterinarians
	And I then fill with the following details:
	| datum      | vrijeme_pocetka | vrijeme_zavrsetka | ljubimac         |
	| 15.4.2023. | 21:00:00        | 21:30:00          | Mela Stjepanovic |
	And I click the button Prijavi termin
	Then I should receive a message stating Veterinar je u tom vremenu zauzet

Scenario: Registration of an appointment with a good date and time
	When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Klara Klaric from the dropdown list of veterinarians
	And I then fill with the following details:
	| datum      | vrijeme_pocetka | vrijeme_zavrsetka | ljubimac         |
	| 13.4.2023. | 12:00:00        | 12:30:00          | Mela Stjepanovic |
	And I click the button Prijavi termin
	Then I should see the appoitment in the busy section

Scenario: Signing up for an appointment that lasts less than 30 minutes
When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Klara Klaric from the dropdown list of veterinarians
	And I then fill with the following details:
	| datum      | vrijeme_pocetka | vrijeme_zavrsetka | ljubimac         |
	| 13.4.2023. | 12:00:00        | 12:10:00          | Mela Stjepanovic |
	And I click the button Prijavi termin
	Then I should receive a message stating Ne mozete prijaviti termin kraci od 30 minuta