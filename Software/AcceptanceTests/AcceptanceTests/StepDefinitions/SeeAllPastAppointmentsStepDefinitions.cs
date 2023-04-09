using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class SeeAllPastAppointmentsStepDefinitions
    {
        [When(@"User selects button for past appointments")]
        public void WhenUserSelectsButtonForPastAppointments()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var loginDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {loginDriver.WindowHandles.Count}");
            foreach (var handle in loginDriver.WindowHandles)
            {
                loginDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {loginDriver.Title}");
            }

            var isCorrectTitle = loginDriver.Title == "Raspored";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var formRaspored=driver.FindElementByAccessibilityId("FrmRaspored");
            var btnPastAppointments=formRaspored.FindElementByAccessibilityId("btnPastAppointment");
            btnPastAppointments.Click();
        }
        [When(@"User need to select button for going back")]
        public void WhenUserNeedToSelectButtonForGoingBack()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var loginDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {loginDriver.WindowHandles.Count}");
            foreach (var handle in loginDriver.WindowHandles)
            {
                loginDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {loginDriver.Title}");
            }

            var isCorrectTitle = loginDriver.Title == "FrmProsliTermini";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var formRaspored = driver.FindElementByAccessibilityId("FrmProsliTermini");
            var btnBack = formRaspored.FindElementByAccessibilityId("btnBack");
            btnBack.Click();
        }

    }
}
