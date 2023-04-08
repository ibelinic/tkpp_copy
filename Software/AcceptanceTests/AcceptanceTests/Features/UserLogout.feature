Feature: UserLogout

User should be able to logout from application.

Background: 
	Given User is on welcome form
	When User clicks on button prijava
	Then User is on login form
	 
Scenario: User Owner logout
	Given User needs to enter details:
	| korisnickoIme | lozinka |
	| anastayija    | anastayija |
	And User login
	And User would click button for logout
	Then  User should be successfully redirected to the welcome form of the application


Scenario: User Veterinarian logout
	Given User needs to enter details:
	| korisnickoIme | lozinka |
	| franka    | franka |
	And User login
	And User would click button for logout as veterinarian
	Then  User should be successfully redirected to the welcome form of the application