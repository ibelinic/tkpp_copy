Feature: BusyAppoitments

As a owner
I should be able to see veterinarians busy appoitments

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

Scenario: Overview of busy appointments
	When I click on the button Pregled dostupnih
	And I am on the form Dostupni veterinari
	And I select the veterinarian Franka Frankic from the dropdown list of veterinarians
	Then I shoud see all busy appoitments for that veterinarian