Feature: UserRegistration

Application needs to provide registration for user
because it will have priviligies based on his role.

Background:
   Given User is on welcome form
   When User clicks on the button "Registracija"
   Then User is on the registration form

Scenario: Valid registration
    Given User enters the following details:
    | ime      | prezime  | adresa            | email                       | broj       | korisnik   | lozinka     | uloga    |
  | Anastayija | Stayić   | Kolodvorska 60 | anastayija.stayic@gmail.com | 0911234567 | anastayija | anastayija | Vlasnik |
    And User clicks button
    Then User should be successfully redirected to the welcome form of the application


Scenario: Registration cancellation
Given user clicks "Odustani" button
Then User should be successfully redirected to the welcome form of the application
