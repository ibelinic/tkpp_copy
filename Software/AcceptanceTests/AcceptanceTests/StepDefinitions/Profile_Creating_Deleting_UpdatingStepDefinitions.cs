using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class Profile_Creating_Deleting_UpdatingStepDefinitions
    {
        [When(@"the user selects the ""([^""]*)"" option")]
        public void WhenTheUserSelectsTheOption(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user fills out the required fields except for the ""([^""]*)"" field")]
        public void WhenTheUserFillsOutTheRequiredFieldsExceptForTheField(string field)
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on ""([^""]*)"" button")]
        public void WhenTheUserClicksOnButton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"an error message should be displayed to the user to enter the required ""([^""]*)"" information")]
        public void ThenAnErrorMessageShouldBeDisplayedToTheUserToEnterTheRequiredInformation(string field)
        {
            throw new PendingStepException();
        }

        [When(@"the user fills out the fields with the following information:")]
        public void WhenTheUserFillsOutTheFieldsWithTheFollowingInformation(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks the ""([^""]*)"" button")]
        public void WhenTheUserClicksTheButton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the user should see an error message indicating that some fields contain invalid values")]
        public void ThenTheUserShouldSeeAnErrorMessageIndicatingThatSomeFieldsContainInvalidValues()
        {
            throw new PendingStepException();
        }

        [Then(@"the pet profile should not be created")]
        public void ThenThePetProfileShouldNotBeCreated()
        {
            throw new PendingStepException();
        }

        [When(@"the user fills out all fields with valid data")]
        public void WhenTheUserFillsOutAllFieldsWithValidData()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on the ""([^""]*)"" button")]
        public void WhenTheUserClicksOnTheButton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the new pet profile is successfully created")]
        public void ThenTheNewPetProfileIsSuccessfullyCreated()
        {
            throw new PendingStepException();
        }

        [Then(@"the new pet is visible in the drop-down menu of pet list")]
        public void ThenTheNewPetIsVisibleInTheDrop_DownMenuOfPetList()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on ""([^""]*)"" without selecting a pet from the dropdown")]
        public void WhenTheUserClicksOnWithoutSelectingAPetFromTheDropdown(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be notified that he need to select a pet to delete")]
        public void ThenTheUserShouldBeNotifiedThatHeNeedToSelectAPetToDelete()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects the pet ""([^""]*)"" from the dropdown list")]
        public void WhenTheUserSelectsThePetFromTheDropdownList(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the system displays an error message saying ""([^""]*)""")]
        public void ThenTheSystemDisplaysAnErrorMessageSaying(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the system does not delete the pet profile")]
        public void ThenTheSystemDoesNotDeleteThePetProfile()
        {
            throw new PendingStepException();
        }

        [Then(@"the system displays a confirmation message saying ""([^""]*)""")]
        public void ThenTheSystemDisplaysAConfirmationMessageSaying(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the user clicks on the ""([^""]*)"" button in the confirmation message")]
        public void ThenTheUserClicksOnTheButtonInTheConfirmationMessage(string confirm)
        {
            throw new PendingStepException();
        }

        [Then(@"the system displays a success message saying ""([^""]*)""")]
        public void ThenTheSystemDisplaysASuccessMessageSaying(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the system redirects the user to the Profile page")]
        public void ThenTheSystemRedirectsTheUserToTheProfilePage()
        {
            throw new PendingStepException();
        }

        [Then(@"the deleted pet profile is no longer available in the dropdown list")]
        public void ThenTheDeletedPetProfileIsNoLongerAvailableInTheDropdownList()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects the pet ""([^""]*)"" from the dropdown menu")]
        public void WhenTheUserSelectsThePetFromTheDropdownMenu(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user updates certain enabled fields with the following information:")]
        public void WhenTheUserUpdatesCertainEnabledFieldsWithTheFollowingInformation(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"the pet information is successfully updated and displayed on the form")]
        public void ThenThePetInformationIsSuccessfullyUpdatedAndDisplayedOnTheForm()
        {
            throw new PendingStepException();
        }

        [Then(@"the updated pet is automatically visible in the dropdown menu")]
        public void ThenTheUpdatedPetIsAutomaticallyVisibleInTheDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"the user receives a success message stating that the pet information was updated successfully")]
        public void ThenTheUserReceivesASuccessMessageStatingThatThePetInformationWasUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given(@"the user has launched the system from the beginning")]
        public void GivenTheUserHasLaunchedTheSystemFromTheBeginning()
        {
            throw new PendingStepException();
        }

        [Given(@"the user is on the Profile page")]
        public void GivenTheUserIsOnTheProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on the dropdown to select a pet")]
        public void WhenTheUserClicksOnTheDropdownToSelectAPet()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should receive a message stating that at least one pet profile needs to be created before selecting a pet")]
        public void ThenTheUserShouldReceiveAMessageStatingThatAtLeastOnePetProfileNeedsToBeCreatedBeforeSelectingAPet()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be given an option to ""([^""]*)"", which redirects them to the home screen")]
        public void ThenTheUserShouldBeGivenAnOptionToWhichRedirectsThemToTheHomeScreen(string cancel)
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be given an option to ""([^""]*)"", which redirects them to the profile creation form")]
        public void ThenTheUserShouldBeGivenAnOptionToWhichRedirectsThemToTheProfileCreationForm(string p0)
        {
            throw new PendingStepException();
        }
    }
}
