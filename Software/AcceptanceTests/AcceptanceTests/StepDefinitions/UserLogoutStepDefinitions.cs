using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class UserLogoutStepDefinitions
    {
        [Given(@"User would click button for logout")]
        public void GivenUserWouldClickButtonForLogout()
        {//gumb u formi za odjavu-> vlasnik
            var logoutDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {logoutDriver.WindowHandles.Count}");
            foreach (var handle in logoutDriver.WindowHandles)
            {
                logoutDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {logoutDriver.Title}");
            }

            var isCorrectTitle = logoutDriver.Title == "Poèetna Korisnik";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var formPocetna = logoutDriver.FindElementByAccessibilityId("FrmKorisnik");
            var btnOdjava = formPocetna.FindElementByAccessibilityId("btnOdjava");
            btnOdjava.Click();
        }

        [Given(@"User would click button for logout as veterinarian")]
        public void GivenUserWouldClickButtonForLogoutAsVeterinarian()
        {//gumb u formi za odjavu-> veterinar
            var logoutDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {logoutDriver.WindowHandles.Count}");
            foreach (var handle in logoutDriver.WindowHandles)
            {
                logoutDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {logoutDriver.Title}");
            }

            var isCorrectTitle = logoutDriver.Title == "Poèetna veterinar";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var formPocetnaVeterinar = logoutDriver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            var btnOdjavaVet = formPocetnaVeterinar.FindElementByAccessibilityId("btnOdjava");
            btnOdjavaVet.Click();
        }

    }
}
