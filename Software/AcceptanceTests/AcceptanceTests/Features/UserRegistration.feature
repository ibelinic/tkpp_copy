Feature: UserRegistration

Application needs to provide registration for user
because it will have priviligies based on his role.

Background:
   Given User is on welcome form
   When User clicks button "Registracija"

Given User is on the registration form
    When User enters the following details:
    | ime      | Anastazija                  |
    | prezime  | Stazić                      |
    | adresa   | Kolodvorska 60              |
    | email    | anastazija.stazic@gmail.com |
    | broj     | 0911234567                  |
    | korisnik | anastazija                  |
    | lozinka  | anastazija                  |
    | uloga    | Vlasnik                     |
    And User clicks the "Registriraj me"
    Then User should be successfully redirected to the welcome form of the application.

Scenario: Invalid e-mail address
   When User fills the form with data that follows:
    | ime      | Karlo         |
    | prezime  | Stazić        |
    | adresa   | Karlova ulica |
    | email    | karlo         |
    | broj     | 0911237654    |
    | korisnik | karlo         |
    | lozinka  | karlo         |
   And User click "Registriraj me"
   Then System will display "Neispravno unesena e-mail adresa" on form


  Scenario: Invalid Phone Number
    When user fills in the details as follows:
      | Field         | Value             |
      | Name          | Karlo             |
      | Surname       | Stazić            |
      | Address       | Karlova ulica     |
      | Email         | karlo@gmail.com   |
      | Phone number  | broj              |
      | Username      | karlo             |
      | Password      | karlo             |
      | Role          | Vlasnik           |
    And clicks the "Registriraj me" button
    Then system should display an error message in the form of a popup on the screen saying "Broj telefona mora sadržavati 10 znamenaka."

Scenario: Registration cancellation
When user clicks on the "Cancel" button
Then system should display the wlcome form of the application
