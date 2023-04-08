Feature: UserLogin

Application needs to provide login for user
because it will give the user certain priviliges.


Background: 
	Given User is on welcome form
	When User clicks on "Prijava"
	Then User is on login form

Scenario: Login user in role of owner 
	Given User needs to enter following details of owner:
	| korisnickoIme | lozinka |
	| anastayija    | anastayja |
	When User clicks on button "Prijava"
	Then User will be successfully redirected to the initial form for owner

Scenario: Login user in role of veterinarian 
	Given User needs to enter details for veterinarian:
	| korisnickoIme | lozinka |
	| franka    | franka |
	When User clicks on button "Prijava"
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Invalid password
	Given User needs to entet details:
	| korisnickoIme | lozinka |
	| anastazija    | ana     |
	When User clicks on the button "Prijava"
	Then System will display error message "Lozinka nije ispravna" on form 