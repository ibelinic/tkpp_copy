using AcceptanceTests.Support;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class DeleteAppointmentStepDefinitions
    {
        [When(@"User selects button for deleting appointment")]
        public void WhenUserSelectsButtonForDeletingAppointment()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmRaspored");
            var btnAžuriraj = formRaspored.FindElementByAccessibilityId("btnIzbrisi");
            btnAžuriraj.Click();
        }


    }
}
