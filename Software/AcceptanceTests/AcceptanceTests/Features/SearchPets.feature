Feature: SearchPets

As an owner
I shoud be able to search other pets and their owners

Background:
	Given the user has launched the system of feature A
	And the user is on the Welcome form
	When the user clicks on the button Prijava
	Then the user is on the Login form
	And the user needs to enter:
		| korisnickoIme | lozinka |
		| stjepan       | stjepan |
	And the user Login
	Then the user will be successfully redirected to the form for owner

Scenario: Opening the form pronadi korisnika
	When I click on the button Nadi korisnika i njegovog ljubimca 
	And I am on the form Pronadi korisnika
	Then I should not see any pets

Scenario: Enter the first letter of the pet's name for which there is no profile
	When I click on the button Nadi korisnika i njegovog ljubimca 
	And I am on the form Pronadi korisnika
	And I enter letter k in the text box
	Then I should not see any pets

Scenario: Enter the first letter of the pet's name for which there is profile
	When I click on the button Nadi korisnika i njegovog ljubimca 
	And I am on the form Pronadi korisnika
	And I enter letter m in the text box
	Then I should see pets witch name start with the letter m

Scenario: Enter the full name of the pet for which he does not have a profile
	When I click on the button Nadi korisnika i njegovog ljubimca 
	And I am on the form Pronadi korisnika
	And I enter kala in the text box
	Then I should not see any pets

Scenario: Enter the full name of the pet for which he does have a profile
	When I click on the button Nadi korisnika i njegovog ljubimca 
	And I am on the form Pronadi korisnika
	And I enter masa in the text box
	Then I should see pets with that name 

Scenario: After deletion, we see a list of all profiles
	When I click on the button Nadi korisnika i njegovog ljubimca 
	And I am on the form Pronadi korisnika
	And I enter the letter k
	And I delete the letter k
	Then I should see all pets profiles
