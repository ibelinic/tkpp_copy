Feature: CreateDigitalCard

As a veterinarian 
Should be able to create pets digital card
So that I can see each pets visit

Background: 
 Given I launched the system
 And I am on the welcome form
 When I click on the button Prijava
 Then I am on the Login form
 And I need to enter:
	| korisnickoIme | lozinka   |
	| veterinar     | veterinar |
 And I login
 And I will be redirected to the initial form for the veterinarian

Scenario: Creating digital card if the pet alredy has one
	When I click on the button Izradi karton
	And I am on the form Digitalni karton
	And I select the pet Rio Anic from the dropdown list of pets
	Then I need to see all previous appointments

Scenario: Creating digital card if the pet does not have one
	When I click on the button Izradi karton
	And I am on the form Digitalni karton
	And I select the pet Anito Stjepanovic from the dropdown list of pets
	Then I should receive a message stating "Digitalno karton je trenutno prazan"

Scenario: When creating a digital card the user registers a new visit
	When I click on the button Izradi karton
	And I am on the form Digitalni karton
	And I select the pet Missy Anic from the dropdown list of pets
	And I click on the button Evidentiraj posjet
	Then I should be redirected to form "Evidentiraj"
