using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CreateDigitalCardStepDefinitions
    {
        [Given(@"I launched the system")]
        public void GivenILaunchedTheSystem()
        {
            GuiDriver.GetOrCreateDriver();
        }

        [Given(@"I am on the welcome form")]
        public void GivenIAmOnTheWelcomeForm()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            bool isFormOpen = driver.FindElementByAccessibilityId("FrmPocetna") != null;
            bool isCorrectTitle = driver.Title == "Dobrodošli!";
            Assert.IsTrue(isFormOpen && isCorrectTitle);
        }

        [When(@"I click on the button Prijava")]
        public void WhenIClickOnTheButtonPrijava()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var pocetnaForm = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonElement = pocetnaForm.FindElementByAccessibilityId("btnPrijava");
            buttonElement.Click();
        }

        [Then(@"I am on the Login form")]
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

        [Then(@"I need to enter:")]
        public void ThenINeedToEnter(Table table)
        {
            var driverLogin = GuiDriver.GetOrCreateDriver();
            var formLoginUser = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginUser.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginUser.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }

        [Then(@"I login")]
        public void ThenILogin()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Then(@"I will be redirected to the initial form for the veterinarian")]
        public void ThenIWillBeRedirectedToTheInitialFormForTheVeterinarian()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var welcomeVet = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            Assert.IsTrue(welcomeVet.Displayed);
        }

        [When(@"I click on the button Izradi karton")]
        public void WhenIClickOnTheButtonIzradiKarton()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            var btnIzradiKarton = frmKorisnik.FindElementByAccessibilityId("btnIzradiKarton");
            btnIzradiKarton.Click();
        }

        [When(@"I am on the form Digitalni karton")]
        public void WhenIAmOnTheFormDigitalniKarton()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var digitalniKarton = driver.FindElementByAccessibilityId("FrmDigitalniKartonVeterinar");
            Assert.IsTrue(digitalniKarton.Displayed);
        }

        [When(@"I select the pet Rio Anic from the dropdown list of pets")]
        public void WhenISelectThePetRioAnicFromTheDropdownListOfPets()
        {
            var driver = GuiDriver.GetDriver();
            var formDigitalniKarton = driver.FindElementByAccessibilityId("FrmDigitalniKartonVeterinar");

            var ljubimac = formDigitalniKarton.FindElementByAccessibilityId("cmbLjubimac");
            Actions action = new Actions(driver);
            action.MoveToElement(ljubimac, ljubimac.Size.Width - 10, ljubimac.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic";
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, ljubimac.GetAttribute("Value.Value"));
        }

        [Then(@"I need to see all previous appointments")]
        public void ThenINeedToSeeAllPreviousAppointments()
        {
            var driver = GuiDriver.GetDriver();
            var formDigitalniKarton = driver.FindElementByAccessibilityId("FrmDigitalniKartonVeterinar");

            var dataGrid = formDigitalniKarton.FindElementByAccessibilityId("dgvPosjeta");
            Assert.IsTrue(dataGrid.Displayed);

            var rows = dataGrid.FindElements(By.TagName("DataGridRow"));
            //Assert.IsTrue(rows.Count > 0);
        }

        [When(@"I select the pet Anito Stjepanovic from the dropdown list of pets")]
        public void WhenISelectThePetAnitoStjepanovicFromTheDropdownListOfPets()
        {
            var driver = GuiDriver.GetDriver();
            var formDigitalni = driver.FindElementByAccessibilityId("FrmDigitalniKartonVeterinar");

            var ljubimac = formDigitalni.FindElementByAccessibilityId("cmbLjubimac");
            Actions action = new Actions(driver);
            action.MoveToElement(ljubimac, ljubimac.Size.Width - 10, ljubimac.Size.Height / 2).Click().Perform();

            Thread.Sleep(2000);

            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Down);
            ljubimac.SendKeys(Keys.Enter);
        }

        [Then(@"I should receive a message stating ""([^""]*)""")]
        public void ThenIShouldReceiveAMessageStating(string p0)
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var formDigitalniKarton = driver.FindElementByAccessibilityId("FrmDigitalniKartonVeterinar");

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                string expectedMessage = "Digitalni karton je trenutno prazan!";

                Thread.Sleep(500);

                var messageBox = driver.FindElement(By.Name("Digitalni karton je trenutno prazan!"));

                Assert.AreEqual(expectedMessage, messageBox.Text);
            }
        }

        [When(@"I click on the button Evidentiraj posjet")]
        public void WhenIClickOnTheButtonEvidentirajPosjet()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmDigitalniKarton = driver.FindElementByAccessibilityId("FrmDigitalniKartonVeterinar");
            var btnIzradiKarton = frmDigitalniKarton.FindElementByAccessibilityId("btnEvidentirajPosjet");
            btnIzradiKarton.Click();
        }

        [Then(@"I should be redirected to form ""([^""]*)""")]
        public void ThenIShouldBeRedirectedToForm(string evidentiraj)
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var evidentira = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            Assert.IsTrue(evidentira.Displayed);
        }
    }
}
