using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class AvailableVeterinariansStepDefinitions
    {
        [Given(@"the user has launched the system")]
        public void GivenTheUserHasLaunchedTheSystem()
        {
            throw new PendingStepException();
        }

        [Given(@"the user has logged in successfully as a pet owner with username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenTheUserHasLoggedInSuccessfullyAsAPetOwnerWithUsernameAndPassword(string stjepan, string stjepan1)
        {
            throw new PendingStepException();
        }

        [Given(@"the user is on the ""([^""]*)"" page")]
        public void GivenTheUserIsOnThePage(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user does not select a veterinarian from the dropdown menu")]
        public void WhenTheUserDoesNotSelectAVeterinarianFromTheDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"the system should not display any feedback to the user")]
        public void ThenTheSystemShouldNotDisplayAnyFeedbackToTheUser()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should only see an empty table of data")]
        public void ThenTheUserShouldOnlySeeAnEmptyTableOfData()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects ""([^""]*)"" from the ""([^""]*)"" dropdown")]
        public void WhenTheUserSelectsFromTheDropdown(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"the user should see a list of appointments for ""([^""]*)"" with the following columns: ID, Date, Start, End")]
        public void ThenTheUserShouldSeeAListOfAppointmentsForWithTheFollowingColumnsIDDateStartEnd(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the list should only include appointments for today or later")]
        public void ThenTheListShouldOnlyIncludeAppointmentsForTodayOrLater()
        {
            throw new PendingStepException();
        }

        [When(@"the user selects ""([^""]*)"" from the dropdown list")]
        public void WhenTheUserSelectsFromTheDropdownList(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"the user wants to go back to the home screen")]
        public void WhenTheUserWantsToGoBackToTheHomeScreen()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be able to click the back button and return to the home screen")]
        public void ThenTheUserShouldBeAbleToClickTheBackButtonAndReturnToTheHomeScreen()
        {
            throw new PendingStepException();
        }
    }
}
