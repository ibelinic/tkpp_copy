using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Threading;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class UserLoginStepDefinitions
    {
    

        [Then(@"User is on login form")]
        public void ThenUserIsOnLoginForm()
        {
            var loginDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {loginDriver.WindowHandles.Count}");
            foreach (var handle in loginDriver.WindowHandles)
            {
                loginDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {loginDriver.Title}");
            }

            var isCorrectTitle = loginDriver.Title == "FrmPrijava";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var registrationFormButton = loginDriver.FindElementByAccessibilityId("txtKorisnickoIme");
            Assert.IsTrue(registrationFormButton.Displayed, "Gumb za registraciju nije prikazan");
        }

      

        [When(@"User clicks on button prijava")]
        public void WhenUserClicksOnButtonPrijava()
        {//gumb kod forme za pocetnu formu
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPocetna = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonPrijava = formPocetna.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Given(@"User login")]
        public void GivenUserLogin()
        {//gumb forme za prijavu
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Then(@"User will be successfully redirected to the initial form for owner")]
        public void ThenUserWillBeSuccessfullyRedirectedToTheInitialFormForOwner()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var welcomeOwner = driver.FindElementByAccessibilityId("FrmKorisnik");
            Assert.IsTrue(welcomeOwner.Displayed);
        }

     

        [Then(@"User will be successfully redirected to the initial form for veterinarian")]
        public void ThenUserWillBeSuccessfullyRedirectedToTheInitialFormForVeterinarian()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var welcomeOwner = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            Assert.IsTrue(welcomeOwner.Displayed);
        }

        [Given(@"User needs to enter details:")]
        public void GivenUserNeedsToEnterDetails(Table table)
        {//unos detalja na formu za prijavu
            var driverLogin = GuiDriver.GetDriver();

            var formLoginVeterinarian = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginVeterinarian.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginVeterinarian.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }


        [Then(@"System will display error message ""([^""]*)"" on form")]
        public void ThenSystemWillDisplayErrorMessageOnForm(string p0)
        {
            var driver = GuiDriver.GetOrCreateDriver();

            var label = driver.FindElementByAccessibilityId("label3");
            Thread.Sleep(1000);

            if (label.Displayed)
            {
                Assert.IsTrue(label.Displayed && label.Text == "Lozinka nije ispravna");
            }

        }
    }
}
