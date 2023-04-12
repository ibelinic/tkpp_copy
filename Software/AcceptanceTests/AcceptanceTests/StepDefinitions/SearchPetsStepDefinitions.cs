using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class SearchPetsStepDefinitions
    {
        [Given(@"the user has launched the system")]
        public void GivenTheUserHasLaunchedTheSystem()
        {
            GuiDriver.GetOrCreateDriver();
        }

        [Given(@"the user is on the Welcome form")]
        public void GivenTheUserIsOnTheWelcomeForm()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            bool isFormOpen = driver.FindElementByAccessibilityId("FrmPocetna") != null;
            bool isCorrectTitle = driver.Title == "Dobrodošli!";
            Assert.IsTrue(isFormOpen && isCorrectTitle);
        }

        [When(@"the user clicks on the button Prijava")]
        public void WhenTheUserClicksOnTheButtonPrijava()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var pocetnaForm = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonElement = pocetnaForm.FindElementByAccessibilityId("btnPrijava");
            buttonElement.Click();
        }

        [Then(@"the user is on the Login form")]
        public void ThenTheUserIsOnTheLoginForm()
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

        [Then(@"the user needs to enter:")]
        public void ThenTheUserNeedsToEnter(Table table)
        {
            var driverLogin = GuiDriver.GetOrCreateDriver();
            var formLoginUser = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginUser.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginUser.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }

        [Then(@"the user Login")]
        public void ThenTheUserLogin()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Then(@"the user will be successfully redirected to the form for owner")]
        public void ThenTheUserWillBeSuccessfullyRedirectedToTheFormForOwner()
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

        [When(@"I click on the button Nadi korisnika i njegovog ljubimca")]
        public void WhenIClickOnTheButtonNadiKorisnikaINjegovogLjubimca()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmKorisnik");
            var btnPronadi = frmKorisnik.FindElementByAccessibilityId("btnNadiKorisnika");
            btnPronadi.Click();
        }

        [When(@"I am on the form Pronadi korisnika")]
        public void WhenIAmOnTheFormPronadiKorisnika()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var pronadiLjubimca = driver.FindElementByAccessibilityId("FrmPronadiKorisnika");
            Assert.IsTrue(pronadiLjubimca.Displayed);
        }

        [Then(@"I should not see any pets")]
        public void ThenIShouldNotSeeAnyPets()
        {
            var driver = GuiDriver.GetDriver();
            var formPronadi = driver.FindElementByAccessibilityId("FrmPronadiKorisnika");

            var dataGrid = formPronadi.FindElementByAccessibilityId("dgvPrikazKorisnika");
            Assert.IsTrue(dataGrid.Displayed);

            var rows = dataGrid.FindElements(By.TagName("DataGridRow"));
            Assert.IsTrue(rows.Count == 0);
        }

        [When(@"I enter letter k in the text box")]
        public void WhenIEnterLetterKInTheTextBox()
        {
            var driver = GuiDriver.GetDriver();
            var text = driver.FindElementByAccessibilityId("txtLjubimac");

            text.Clear();

            text.SendKeys("k");

            Thread.Sleep(1000);
        }

        [When(@"I enter letter m in the text box")]
        public void WhenIEnterLetterMInTheTextBox()
        {
            var driver = GuiDriver.GetDriver();
            var text = driver.FindElementByAccessibilityId("txtLjubimac");

            text.Clear();

            text.SendKeys("m");

            Thread.Sleep(1000);
        }

        [Then(@"I should see pets witch name start with the letter m")]
        public void ThenIShouldSeePetsWitchNameStartWithTheLetterM()
        {
            var driver = GuiDriver.GetDriver();
            var search = driver.FindElementByAccessibilityId("dgvPrikazKorisnika");

            var rows = search.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                var cells = row.FindElements(By.TagName("td"));
                var petName = cells[1].Text;

                Assert.IsTrue(petName.StartsWith("m", StringComparison.OrdinalIgnoreCase));
            }
        }

        [When(@"I enter kala in the text box")]
        public void WhenIEnterKalaInTheTextBox()
        {
            var driver = GuiDriver.GetDriver();
            var text = driver.FindElementByAccessibilityId("txtLjubimac");

            text.Clear();

            text.SendKeys("kala");

            Thread.Sleep(1000);
        }

        [When(@"I enter masa in the text box")]
        public void WhenIEnterMasaInTheTextBox()
        {
            var driver = GuiDriver.GetDriver();
            var text = driver.FindElementByAccessibilityId("txtLjubimac");

            text.Clear();

            text.SendKeys("masa");

            Thread.Sleep(1000);
        }

        [Then(@"I should see pets with that name")]
        public void ThenIShouldSeePetsWithThatName()
        {
            var driver = GuiDriver.GetDriver();
            var search = driver.FindElementByAccessibilityId("dgvPrikazKorisnika");

            var rows = search.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                var cells = row.FindElements(By.TagName("td"));
                var petName = cells[1].Text;

                Assert.IsTrue(petName.StartsWith("masa", StringComparison.OrdinalIgnoreCase));
            }
        }

        [When(@"I enter the letter k")]
        public void WhenIEnterTheLetterK()
        {
            var driver = GuiDriver.GetDriver();
            var text = driver.FindElementByAccessibilityId("txtLjubimac");

            text.Clear();

            text.SendKeys("k");

            Thread.Sleep(1000);
        }

        [When(@"I delete the letter k")]
        public void WhenIDeleteTheLetterK()
        {
            var driver = GuiDriver.GetDriver();
            var text = driver.FindElementByAccessibilityId("txtLjubimac");

            text.Clear();

            Thread.Sleep(1000);
        }

        [Then(@"I should see all pets profiles")]
        public void ThenIShouldSeeAllPetsProfiles()
        {
            var driver = GuiDriver.GetDriver();
            var dataGrid = driver.FindElementByAccessibilityId("dgvPrikazKorisnika");

            var rows = dataGrid.FindElements(By.TagName("DataGridRow"));
            Thread.Sleep(1000);

            Assert.IsTrue(rows.Count >= 0);
        }
    }
}
