using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class RecordingTreatmentsStepDefinitions
    {
        [Given(@"the user has logged in successfully as a veterinarian with username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenTheUserHasLoggedInSuccessfullyAsAVeterinarianWithUsernameAndPassword(string veterinar, string veterinar1)
        {
            throw new PendingStepException();
        }

        [Given(@"the user doesn't select a pet from the dropdown")]
        public void GivenTheUserDoesntSelectAPetFromTheDropdown()
        {
            throw new PendingStepException();
        }

        [Then(@"the form's functionalities should be disabled")]
        public void ThenTheFormsFunctionalitiesShouldBeDisabled()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be informed to select a pet before proceeding")]
        public void ThenTheUserShouldBeInformedToSelectAPetBeforeProceeding()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects the desired pet ""([^""]*)"" from the dropdown")]
        public void WhenTheUserSelectsTheDesiredPetFromTheDropdown(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user selects the existing appointment ""([^""]*)"" from the dropdown")]
        public void WhenTheUserSelectsTheExistingAppointmentFromTheDropdown(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user leaves the fields for illness and medication empty")]
        public void WhenTheUserLeavesTheFieldsForIllnessAndMedicationEmpty()
        {
            throw new PendingStepException();
        }

        [Then(@"the system should prompt the user that the fields for illness and medication are required")]
        public void ThenTheSystemShouldPromptTheUserThatTheFieldsForIllnessAndMedicationAreRequired()
        {
            throw new PendingStepException();
        }

        [Then(@"the system should not successfully complete adding to the existing visit")]
        public void ThenTheSystemShouldNotSuccessfullyCompleteAddingToTheExistingVisit()
        {
            throw new PendingStepException();
        }

        [Given(@"the user launches the system and successfully logs in as a veterinarian with valid credentials")]
        public void GivenTheUserLaunchesTheSystemAndSuccessfullyLogsInAsAVeterinarianWithValidCredentials()
        {
            throw new PendingStepException();
        }

        [Given(@"the user is on the ""([^""]*)"" form")]
        public void GivenTheUserIsOnTheForm(string record)
        {
            throw new PendingStepException();
        }

        [When(@"the user selects a desired pet from the dropdown menu: ""([^""]*)""")]
        public void WhenTheUserSelectsADesiredPetFromTheDropdownMenu(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user selects an existing visit date from the dropdown menu: ""([^""]*)""")]
        public void WhenTheUserSelectsAnExistingVisitDateFromTheDropdownMenu(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user fills in all remaining fields with meaningful data")]
        public void WhenTheUserFillsInAllRemainingFieldsWithMeaningfulData()
        {
            throw new PendingStepException();
        }

        [When(@"the user enters the disease for the selected visit and its medicine")]
        public void WhenTheUserEntersTheDiseaseForTheSelectedVisitAndItsMedicine()
        {
            throw new PendingStepException();
        }

        [Then(@"the system should successfully update the selected appointment and clear all fields")]
        public void ThenTheSystemShouldSuccessfullyUpdateTheSelectedAppointmentAndClearAllFields()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should receive a confirmation message about the successful update")]
        public void ThenTheUserShouldReceiveAConfirmationMessageAboutTheSuccessfulUpdate()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects a new visit date of his choice")]
        public void WhenTheUserSelectsANewVisitDateOfHisChoice()
        {
            throw new PendingStepException();
        }

        [When(@"the user does not fill in the ""([^""]*)"" field")]
        public void WhenTheUserDoesNotFillInTheField(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the system should not save the new visit")]
        public void ThenTheSystemShouldNotSaveTheNewVisit()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should receive an error message indicating that all fields are required to save the visit")]
        public void ThenTheUserShouldReceiveAnErrorMessageIndicatingThatAllFieldsAreRequiredToSaveTheVisit()
        {
            throw new PendingStepException();
        }

        [When(@"the user fills in the ""([^""]*)"" field with any reason")]
        public void WhenTheUserFillsInTheFieldWithAnyReason(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"a new visit record should be saved successfully")]
        public void ThenANewVisitRecordShouldBeSavedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then(@"the previous data in the fields should be cleared automatically")]
        public void ThenThePreviousDataInTheFieldsShouldBeClearedAutomatically()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should see a success message")]
        public void ThenTheUserShouldSeeASuccessMessage()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects ""([^""]*)"" from the dropdown list of pets")]
        public void WhenTheUserSelectsFromTheDropdownListOfPets(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user selects a desired date and reason for the visit")]
        public void WhenTheUserSelectsADesiredDateAndReasonForTheVisit()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on the ""([^""]*)"" checkbox")]
        public void WhenTheUserClicksOnTheCheckbox(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the visit should be saved successfully")]
        public void ThenTheVisitShouldBeSavedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then(@"the fields for disease and medication should be enabled")]
        public void ThenTheFieldsForDiseaseAndMedicationShouldBeEnabled()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on ""([^""]*)"" without filling in the fields for disease and medication")]
        public void WhenTheUserClicksOnWithoutFillingInTheFieldsForDiseaseAndMedication(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the user should receive an error message stating that it is not possible to record a new visit without filling in the fields for disease and medication")]
        public void ThenTheUserShouldReceiveAnErrorMessageStatingThatItIsNotPossibleToRecordANewVisitWithoutFillingInTheFieldsForDiseaseAndMedication()
        {
            throw new PendingStepException();
        }

        [Then(@"the new visit should not be recorded")]
        public void ThenTheNewVisitShouldNotBeRecorded()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects a pet ""([^""]*)"" from the dropdown menu")]
        public void WhenTheUserSelectsAPetFromTheDropdownMenu(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user selects a date and reason for the visit")]
        public void WhenTheUserSelectsADateAndReasonForTheVisit()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on ""([^""]*)"" checkbox")]
        public void WhenTheUserClicksOnCheckbox(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"a new visit is successfully recorded")]
        public void ThenANewVisitIsSuccessfullyRecorded()
        {
            throw new PendingStepException();
        }

        [Then(@"the fields for disease and medication are enabled")]
        public void ThenTheFieldsForDiseaseAndMedicationAreEnabled()
        {
            throw new PendingStepException();
        }

        [Then(@"the user fills in the fields for disease and medication with valid data and selects a date for the start of symptoms")]
        public void ThenTheUserFillsInTheFieldsForDiseaseAndMedicationWithValidDataAndSelectsADateForTheStartOfSymptoms()
        {
            throw new PendingStepException();
        }

        [Then(@"the user clicks on ""([^""]*)"" button")]
        public void ThenTheUserClicksOnButton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the new visit is successfully recorded and all fields are cleared")]
        public void ThenTheNewVisitIsSuccessfullyRecordedAndAllFieldsAreCleared()
        {
            throw new PendingStepException();
        }

        [Then(@"the user receives a visible confirmation of the successful recording of the new visit")]
        public void ThenTheUserReceivesAVisibleConfirmationOfTheSuccessfulRecordingOfTheNewVisit()
        {
            throw new PendingStepException();
        }

        [Given(@"the user selects the desired pet from the dropdown menu: ""([^""]*)""")]
        public void GivenTheUserSelectsTheDesiredPetFromTheDropdownMenu(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user selects the date ""([^""]*)"" while filling in the visit reason with desired, but valid data")]
        public void GivenTheUserSelectsTheDateWhileFillingInTheVisitReasonWithDesiredButValidData(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user clicks on the ""([^""]*)"" checkbox")]
        public void GivenTheUserClicksOnTheCheckbox(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the visit is saved and the fields for diseases and medications are enabled")]
        public void ThenTheVisitIsSavedAndTheFieldsForDiseasesAndMedicationsAreEnabled()
        {
            throw new PendingStepException();
        }

        [Then(@"the user fills in the fields for disease and medication with valid data")]
        public void ThenTheUserFillsInTheFieldsForDiseaseAndMedicationWithValidData()
        {
            throw new PendingStepException();
        }

        [Then(@"the user selects the symptom onset date as ""([^""]*)""")]
        public void ThenTheUserSelectsTheSymptomOnsetDateAs(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the system should display an error message saying that the symptom onset date must be earlier than the visit date")]
        public void ThenTheSystemShouldDisplayAnErrorMessageSayingThatTheSymptomOnsetDateMustBeEarlierThanTheVisitDate()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects the desired pet from the dropdown list: ""([^""]*)""")]
        public void WhenTheUserSelectsTheDesiredPetFromTheDropdownList(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user selects an existing date by mistake")]
        public void WhenTheUserSelectsAnExistingDateByMistake()
        {
            throw new PendingStepException();
        }

        [Then(@"the system should automatically clear the previous data and the selected date")]
        public void ThenTheSystemShouldAutomaticallyClearThePreviousDataAndTheSelectedDate()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be returned to the initial state of the form")]
        public void ThenTheUserShouldBeReturnedToTheInitialStateOfTheForm()
        {
            throw new PendingStepException();
        }

        [Then(@"the selection should be successfully cancelled")]
        public void ThenTheSelectionShouldBeSuccessfullyCancelled()
        {
            throw new PendingStepException();
        }
    }
}
