using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class BusyAppoitmentsStepDefinitions
    {
        [Given(@"I launched the System")]
        public void GivenILaunchedTheSystem()
        {
            GuiDriver.GetOrCreateDriver();
        }

        [Given(@"I am on the Welcome form")]
        public void GivenIAmOnTheWelcomeForm()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            bool isFormOpen = driver.FindElementByAccessibilityId("FrmPocetna") != null;
            bool isCorrectTitle = driver.Title == "Dobrodošli!";
            Assert.IsTrue(isFormOpen && isCorrectTitle);
        }

        [When(@"I click on the button prijava")]
        public void WhenIClickOnTheButtonPrijava()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var pocetnaForm = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonElement = pocetnaForm.FindElementByAccessibilityId("btnPrijava");
            buttonElement.Click();
        }

        [Then(@"I am on the login form")]
        public void ThenIAmOnTheLoginForm()
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

        [Then(@"I need to Enter:")]
        public void ThenINeedToEnter(Table table)
        {
            var driverLogin = GuiDriver.GetOrCreateDriver();
            var formLoginUser = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginUser.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginUser.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }

        [Then(@"I Login")]
        public void ThenILogin()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Then(@"I will be successfully redirected to the form for owner")]
        public void ThenIWillBeSuccessfullyRedirectedToTheFormForOwner()
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

        [When(@"I click on the button Pregled dostupnih")]
        public void WhenIClickOnTheButtonPregledDostupnih()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmKorisnik");
            var btnDostupni = frmKorisnik.FindElementByAccessibilityId("btnDostupniVeterinari");
            btnDostupni.Click();
        }

        [When(@"I am on the form Dostupni veterinari")]
        public void WhenIAmOnTheFormDostupniVeterinari()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var veterinar = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");
            Assert.IsTrue(veterinar.Displayed);
        }

        [When(@"I select the veterinarian Franka Frankic from the dropdown list of veterinarians")]
        public void WhenISelectTheVeterinarianFrankaFrankicFromTheDropdownListOfVeterinarians()
        {
            var driver = GuiDriver.GetDriver();
            var formVeterinar = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");

            var veterinari = formVeterinar.FindElementByAccessibilityId("cmbVeterinari");
            Actions action = new Actions(driver);
            action.MoveToElement(veterinari, veterinari.Size.Width - 10, veterinari.Size.Height / 2).Click().Perform();

            var valueToSelect = "Franka Frankic";
            var itemToSelect = driver.FindElement(By.Name(valueToSelect));
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, veterinari.GetAttribute("Value.Value"));
        }

        [Then(@"I shoud see all busy appoitments for that veterinarian")]
        public void ThenIShoudSeeAllBusyAppoitmentsForThatVeterinarian()
        {
            var driver = GuiDriver.GetDriver();
            var dgvDostupni = driver.FindElementByAccessibilityId("dgvDostupniVeterinari");
            Assert.IsTrue(dgvDostupni.Displayed);

            var selectedVet = "Franka Frankic";
            var appointments = new List<string>();
            var rows = dgvDostupni.FindElementsByClassName("DataGridViewRow");
            foreach (var row in rows)
            {
                var cells = row.FindElementsByClassName("DataGridViewCell");
                if (cells[0].Text == selectedVet)
                {
                    appointments.Add(cells[1].Text);
                }
            }
        }
    }
}
