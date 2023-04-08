using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class UserLoginStepDefinitions
    {
        [When(@"User clicks on ""([^""]*)""")]
        public void WhenUserClicksOn(string prijava)
        {
            throw new PendingStepException();
        }

        [Then(@"User is on login form")]
        public void ThenUserIsOnLoginForm()
        {
            throw new PendingStepException();
        }

        [Given(@"User needs to enter following details of owner:")]
        public void GivenUserNeedsToEnterFollowingDetailsOfOwner(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"User clicks on button ""([^""]*)""")]
        public void WhenUserClicksOnButton(string prijava)
        {
            throw new PendingStepException();
        }

        [Then(@"User will be successfully redirected to the initial form for owner")]
        public void ThenUserWillBeSuccessfullyRedirectedToTheInitialFormForOwner()
        {
            throw new PendingStepException();
        }

        [Given(@"User needs to enter details for veterinarian:")]
        public void GivenUserNeedsToEnterDetailsForVeterinarian(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"User will be successfully redirected to the initial form for veterinarian")]
        public void ThenUserWillBeSuccessfullyRedirectedToTheInitialFormForVeterinarian()
        {
            throw new PendingStepException();
        }

        [Given(@"User needs to entet details:")]
        public void GivenUserNeedsToEntetDetails(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"System will display error message ""([^""]*)"" on form")]
        public void ThenSystemWillDisplayErrorMessageOnForm(string p0)
        {
            throw new PendingStepException();
        }
    }
}
