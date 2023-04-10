Feature: CreatingReportOfDigitalCartonOwner

User as a veterinarian should be able to create report of the pets digital carton.


Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	And User needs to enter details:
		| korisnickoIme | lozinka |
		| ana         | ana  |
	And User login
	Then User will be successfully redirected to the initial form for owner

Scenario: Creating report as a Owner
	Given User need to go to profil
	When User selects pet:
	| ljubimac |
	| Rio Anic |
	And User goes to digital carton
	And User selects pet appointment
	And User goes to report
	Then User will be able to see form with report of selected pet
