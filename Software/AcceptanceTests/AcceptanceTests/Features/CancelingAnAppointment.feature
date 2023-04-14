Feature: CancelingAnAppointment

As a owner
I should be able to cancle an appoitment


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

Scenario: Canceling an appointment that was not registered by the registered user
	When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Klara Klaric from the dropdown list of veterinarians
	And I select the first row in data grid view 
	And I click the button Odjavi termin
	Then I should should receive a message stating Nemate pravo odjaviti ovaj termin

Scenario: Cancellation of an appointment reported by a registered user
	When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Klara Klaric from the dropdown list of veterinarians
	And I select the first row in data grid view 
	And I click the button Odjavi termin
	Then I should no longer see that appoitment
	And I should should receive a message Termin uspješno odjavljen