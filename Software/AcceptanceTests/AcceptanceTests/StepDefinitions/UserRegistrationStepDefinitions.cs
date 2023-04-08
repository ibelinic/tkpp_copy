using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class UserRegistrationStepDefinitions
    {
        [Given(@"User is on welcome form")]
        public void GivenUserIsOnWelcomeForm()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();//trebam driver
            bool isFormOpen = driver.FindElementByAccessibilityId("FrmPocetna") != null;//provjera da li je prozor otvoren
            bool isCorrectTitle = driver.Title == "Dobrodošli!";//onaj naziv prozora u lijevom gornjem kutu

            Assert.IsTrue(isFormOpen && isCorrectTitle);
        }

        [When(@"User clicks on the button ""([^""]*)""")]
        public void WhenUserClicksOnTheButton(string registracija)
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var pocetnaForm = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonElement = pocetnaForm.FindElementByAccessibilityId("btnRegistracija");
            
            buttonElement.Click();
            
        }
        [Then(@"User is on the registration form")]
        public void ThenUserIsOnTheRegistrationForm()
        {
            var registrationDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {registrationDriver.WindowHandles.Count}");
            foreach (var handle in registrationDriver.WindowHandles)
            {
                registrationDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {registrationDriver.Title}");
            }

            var isCorrectTitle = registrationDriver.Title == "FrmRegistracija";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var registrationFormButton = registrationDriver.FindElementByAccessibilityId("button1");
            Assert.IsTrue(registrationFormButton.Displayed, "Gumb za registraciju nije prikazan");
        }

        [Given(@"User enters the following details:")]
        public void GivenUserEntersTheFollowingDetails(Table table)
        {
            //valid registration
            var driverRegistration = GuiDriver.GetDriver();

            var registrationForm = driverRegistration.FindElementByAccessibilityId("FrmRegistracija");

            var rows = table.Rows;
            registrationForm.FindElementByAccessibilityId("txtIme").SendKeys(rows[0]["ime"]);
            registrationForm.FindElementByAccessibilityId("txtPrezime").SendKeys(rows[0]["prezime"]);
            registrationForm.FindElementByAccessibilityId("txtAdresa").SendKeys(rows[0]["adresa"]);
            registrationForm.FindElementByAccessibilityId("txtEmail").SendKeys(rows[0]["email"]);
            registrationForm.FindElementByAccessibilityId("txtBrojMobitela").SendKeys(rows[0]["broj"]);
            registrationForm.FindElementByAccessibilityId("txtKorisnicko").SendKeys(rows[0]["korisnik"]);
            registrationForm.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
            var comboBox = registrationForm.FindElementByAccessibilityId("cmbUloga");
            comboBox.Click();
            var uloga = rows[0]["uloga"].ToString();
            new SelectElement(comboBox).SelectByText(uloga);

          
            var selectedOption = new SelectElement(comboBox).SelectedOption.Text;
            Assert.AreEqual(rows[0]["uloga"], selectedOption);//provjera vrijednosti-combobox
        }


        [Given(@"User clicks button")]
        public void WhenUserClicksButton()
        {
            
            var driver = GuiDriver.GetDriver();
            var registrationForm = driver.FindElementByAccessibilityId("FrmRegistracija");

            var button = registrationForm.FindElementByAccessibilityId("button1");
            button.Click();
        }

        [Given(@"user clicks ""([^""]*)"" button")]
        public void GivenUserClicksButton(string odustani)
        {
            //gumb odustani
            var driver = GuiDriver.GetDriver();
            var registrationForm = driver.FindElementByAccessibilityId("FrmRegistracija");

            var button = registrationForm.FindElementByAccessibilityId("btnOdustani");
            button.Click();
        }


        [Then(@"User should be successfully redirected to the welcome form of the application")]
        public void ThenUserShouldBeSuccessfullyRedirectedToTheWelcomeFormOfTheApplication()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var welcomeForm = driver.FindElementByAccessibilityId("FrmPocetna");
            Assert.IsTrue(welcomeForm.Displayed);
        }

    }
}
