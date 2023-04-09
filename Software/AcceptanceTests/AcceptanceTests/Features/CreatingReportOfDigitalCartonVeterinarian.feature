Feature: CreatingReportOfDigitalCarton

User as a veterinarian or as a owner should be able to create report of the pets digital carton.

Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	And User needs to enter details:
		| korisnickoIme | lozinka |
		| franka         | franka  |
	And User login
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Creating report as a veterinarian
	Given User on the form for veterinarian should press button for report
	When User selects pet from right corner:
	| ljubimac |
	| Rio Anic |
	And User selects appointment of pet
	And User selects button for report
	Then User will be able to see form with report of selected pet
