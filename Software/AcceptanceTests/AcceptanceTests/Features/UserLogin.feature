Feature: UserLogin

Application needs to provide login for user
because it will give the user certain priviliges.


Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form

Scenario: Login user in role of owner 
	Given User needs to enter details:
	| korisnickoIme | lozinka |
	| anastayija    | anastayija |
	And User login
	Then User will be successfully redirected to the initial form for owner

Scenario: Login user in role of veterinarian 
	Given User needs to enter details:
	| korisnickoIme | lozinka |
	| franka    | franka |
	And User login
	Then User will be successfully redirected to the initial form for veterinarian

Scenario: Invalid password
	Given User needs to enter details:
	| korisnickoIme | lozinka |
	| anastayija    | ana     |
	And User login
	Then System will display error message "Lozinka nije ispravna" on form 