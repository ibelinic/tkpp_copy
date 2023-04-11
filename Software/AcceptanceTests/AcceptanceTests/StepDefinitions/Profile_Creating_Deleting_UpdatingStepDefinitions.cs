using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class Profile_Creating_Deleting_UpdatingStepDefinitions
    {
        [Given(@"the user has launched the system of feature A")]
        public void GivenTheUserHasLaunchedTheSystemOfFeatureA()
        {
            // Code to launch the system
            GuiDriver.GetOrCreateDriver();
        }

        [Given(@"the user is on the welcome form")]
        public void GivenTheUserIsOnTheWelcomeForm()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            bool isFormOpen = driver.FindElementByAccessibilityId("FrmPocetna") != null; //provjera je li prozor otvoren
            bool isCorrectTitle = driver.Title == "Dobrodošli!"; //naziv prozora u lijevom gornjem kutu
            Assert.IsTrue(isFormOpen && isCorrectTitle);
        }

        [When(@"the user clicks on the button ""([^""]*)""")]
        public void WhenTheUserClicksOnTheButton(string prijava)
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var pocetnaForm = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonElement = pocetnaForm.FindElementByAccessibilityId("btnPrijava");
            buttonElement.Click();
        }

        [Then(@"the user is on the login form")]
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

        [Then(@"the user needs to enter details:")]
        public void ThenTheUserNeedsToEnterDetails(Table table)
        {
            var driverLogin = GuiDriver.GetOrCreateDriver();
            var formLoginUser = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginUser.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginUser.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }

        [Then(@"the user login")]
        public void ThenTheUserLogin()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Then(@"the user will be successfully redirected to the initial form for owner")]
        public void ThenTheUserWillBeSuccessfullyRedirectedToTheInitialFormForOwner()
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

        [Then(@"the user selects Profile")]
        public void ThenTheUserSelectsProfile()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmKorisnik");
            var btnProfil = frmKorisnik.FindElementByAccessibilityId("btnProfil");
            btnProfil.Click();
        }

        [Then(@"the user is on the Profile form")]
        public void ThenTheUserIsOnTheProfileForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var profilOwner = driver.FindElementByAccessibilityId("FrmProfil");
            var isCorrectTitle = driver.Title == "FrmProfil";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            Assert.IsTrue(profilOwner.Displayed);
        }

        [When(@"the user selects the ""([^""]*)"" option")]
        public void WhenTheUserSelectsTheOption(string p0)
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Thread.Sleep(1000);
            var button = driver.FindElementByAccessibilityId("btnIzradiProfil");
            button.Click(); // kliknite na gumb / element koji otvara novu formu

        }

        [When(@"the user fills out the required fields except for one field:")]
        public void WhenTheUserFillsOutTheRequiredFieldsExceptForOneField(Table table)
        {
            var addingDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {addingDriver.WindowHandles.Count}");
            foreach (var handle in addingDriver.WindowHandles)
            {
                addingDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {addingDriver.Title}");
            }

            var formProfil = addingDriver.FindElementByAccessibilityId("FrmIzradaProfila");
            var textboxElement = addingDriver.FindElementByAccessibilityId("txtIme");
            Assert.IsTrue(textboxElement.Displayed, "Forma nije otvorena");

            var rows = table.Rows;

            var ime = formProfil.FindElementByAccessibilityId("txtIme");
            ime.SendKeys(rows[0]["Ime"]);

            var brojIskaznice = formProfil.FindElementByAccessibilityId("txtBrojIskaznice");
            brojIskaznice.SendKeys(rows[0]["Broj iskaznice"]);

            var pasminaLjubimca = formProfil.FindElementByAccessibilityId("cmbPasmina");
            var comboName = pasminaLjubimca.GetAttribute("LegacyIAccessiblePattern.Name");
            if (comboName == "Macka")
            {
                pasminaLjubimca.Click();
                Assert.AreEqual(rows[0]["Pasmina ljubimca"], pasminaLjubimca);
            }

            var brojChipa = formProfil.FindElementByAccessibilityId("txtBrojChipa");
            brojChipa.SendKeys(rows[0]["BrojChipa"]);

            var tezina = formProfil.FindElementByAccessibilityId("txtTezina");
            tezina.SendKeys(rows[0]["Tezina_Kg"]);

            var visina = formProfil.FindElementByAccessibilityId("txtVisina");
            visina.SendKeys(rows[0]["Visina_Cm"]);

            var biljeske = formProfil.FindElementByAccessibilityId("richtxtBiljeske");
            biljeske.SendKeys(rows[0]["Bilješke"]);
        }

        [When(@"the user clicks on ""([^""]*)"" button of feature A")]
        public void WhenTheUserClicksOnButtonOfFeatureA(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formIzradi = driver.FindElementByAccessibilityId("FrmIzradaProfila");

            var createProfileButton = formIzradi.FindElementByAccessibilityId("btnIzradiProfil");
            createProfileButton.Click();
        }

        [Then(@"an error message ""([^""]*)"" should be displayed to the user to enter the required information")]
        public void ThenAnErrorMessageShouldBeDisplayedToTheUserToEnterTheRequiredInformation(string p0)
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Nisu uneseni svi podaci!";

                // pričekajte da se prikaže dijaloški okvir
                Thread.Sleep(500); // pričekajte da se dijaloški okvir u potpunosti učita
                var messageBox = driver.FindElement(By.Name("Nisu uneseni svi podaci!"));
                var messageBoxText = messageBox.Text;

                // provjerite je li poruka ispravna
                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"the user fills out the fields with the following information:")]
        public void WhenTheUserFillsOutTheFieldsWithTheFollowingInformation(Table table)
        {
            var driver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var formProfil = driver.FindElementByAccessibilityId("FrmIzradaProfila");
            var textboxElement = driver.FindElementByAccessibilityId("txtIme");
            Assert.IsTrue(textboxElement.Displayed, "Forma nije otvorena");

            var rows = table.Rows;

            var ime = formProfil.FindElementByAccessibilityId("txtIme");
            ime.SendKeys(rows[0]["Ime"]);

            var prezime = formProfil.FindElementByAccessibilityId("txtPrezime");
            prezime.SendKeys(rows[0]["Prezime"]);

            var brojIskaznice = formProfil.FindElementByAccessibilityId("txtBrojIskaznice");
            brojIskaznice.SendKeys(rows[0]["Broj iskaznice"]);

            var pasminaLjubimca = formProfil.FindElementByAccessibilityId("cmbPasmina");
            var comboName = pasminaLjubimca.GetAttribute("LegacyIAccessiblePattern.Name");
            if (comboName == "Macka")
            {
                pasminaLjubimca.Click();
                Assert.AreEqual(rows[0]["Pasmina ljubimca"], pasminaLjubimca);
            }

            var brojChipa = formProfil.FindElementByAccessibilityId("txtBrojChipa");
            brojChipa.SendKeys(rows[0]["BrojChipa"]);

            var tezina = formProfil.FindElementByAccessibilityId("txtTezina");
            tezina.SendKeys(rows[0]["Tezina_Kg"]);

            var visina = formProfil.FindElementByAccessibilityId("txtVisina");
            visina.SendKeys(rows[0]["Visina_Cm"]);

            var biljeske = formProfil.FindElementByAccessibilityId("richtxtBiljeske");
            biljeske.SendKeys(rows[0]["Bilješke"]);
        }

        [When(@"the user clicks on the ""([^""]*)"" button of feature B")]
        public void WhenTheUserClicksOnTheButtonOfFeatureB(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formIzradi = driver.FindElementByAccessibilityId("FrmIzradaProfila");

            var createProfileButton = formIzradi.FindElementByAccessibilityId("btnIzradiProfil");
            createProfileButton.Click();
        }

        [Then(@"the user should see an error message indicating that some fields contain invalid values")]
        public void ThenTheUserShouldSeeAnErrorMessageIndicatingThatSomeFieldsContainInvalidValues()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Broj iskaznice ljubimca nije ispravan!";

                // pričekajte da se prikaže dijaloški okvir
                Thread.Sleep(500); // pričekajte da se dijaloški okvir u potpunosti učita
                var messageBox = driver.FindElement(By.Name("Broj iskaznice ljubimca nije ispravan!"));
                var messageBoxText = messageBox.Text;

                // provjerite je li poruka ispravna
                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"the user fills out all fields with valid data:")]
        public void WhenTheUserFillsOutAllFieldsWithValidData(Table table)
        {
            var driver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var formProfil = driver.FindElementByAccessibilityId("FrmIzradaProfila");
            var textboxElement = driver.FindElementByAccessibilityId("txtIme");
            Assert.IsTrue(textboxElement.Displayed, "Forma nije otvorena");

            var rows = table.Rows;

            var ime = formProfil.FindElementByAccessibilityId("txtIme");
            ime.SendKeys(rows[0]["Ime"]);

            var prezime = formProfil.FindElementByAccessibilityId("txtPrezime");
            prezime.SendKeys(rows[0]["Prezime"]);

            var brojIskaznice = formProfil.FindElementByAccessibilityId("txtBrojIskaznice");
            brojIskaznice.SendKeys(rows[0]["Broj iskaznice"]);

            var pasminaLjubimca = formProfil.FindElementByAccessibilityId("cmbPasmina");
            var comboName = pasminaLjubimca.GetAttribute("LegacyIAccessiblePattern.Name");
            if (comboName == "Macka")
            {
                pasminaLjubimca.Click();
                Assert.AreEqual(rows[0]["Pasmina ljubimca"], pasminaLjubimca);
            }

            var brojChipa = formProfil.FindElementByAccessibilityId("txtBrojChipa");
            brojChipa.SendKeys(rows[0]["BrojChipa"]);

            var tezina = formProfil.FindElementByAccessibilityId("txtTezina");
            tezina.SendKeys(rows[0]["Tezina_Kg"]);

            var visina = formProfil.FindElementByAccessibilityId("txtVisina");
            visina.SendKeys(rows[0]["Visina_Cm"]);

            var biljeske = formProfil.FindElementByAccessibilityId("richtxtBiljeske");
            biljeske.SendKeys(rows[0]["Bilješke"]);
        }

        [When(@"the user clicks on the ""([^""]*)"" button of feature C")]
        public void WhenTheUserClicksOnTheButtonOfFeatureC(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formIzradi = driver.FindElementByAccessibilityId("FrmIzradaProfila");

            var createProfileButton = formIzradi.FindElementByAccessibilityId("btnIzradiProfil");
            createProfileButton.Click();
        }

        [Then(@"the new pet is visible in the drop-down menu of pet list")]
        public void ThenTheNewPetIsVisibleInTheDrop_DownMenuOfPetList()
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var textboxElement = formProfil.FindElementByAccessibilityId("cmbProfili");
            Assert.IsTrue(textboxElement.Displayed, "Forma nije otvorena");

            Thread.Sleep(1000);
            textboxElement.Click();

        }

        [When(@"the user clicks on ""([^""]*)"" without selecting a pet from the dropdown")]
        public void WhenTheUserClicksOnWithoutSelectingAPetFromTheDropdown(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var deleteButton = formProfil.FindElementByAccessibilityId("btnObrisiProfil");
            deleteButton.Click();
        }

        [Then(@"the user should be notified that he need to select a pet to delete")]
        public void ThenTheUserShouldBeNotifiedThatHeNeedToSelectAPetToDelete()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Morate odabrati ljubimca";

                // pričekajte da se prikaže dijaloški okvir
                Thread.Sleep(500); // pričekajte da se dijaloški okvir u potpunosti učita
                var messageBox = driver.FindElement(By.Name("Morate odabrati ljubimca"));
                var messageBoxText = messageBox.Text;

                // provjerite je li poruka ispravna
                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"the user selects the pet ""Fleksi Stjepanovic"" from the dropdown list of feature")]
        public void WhenTheUserSelectsThePetFromTheDropdownListOfFeature()
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var profilLjubimca = formProfil.FindElementByAccessibilityId("cmbProfili");
            Actions action = new Actions(driver);
            action.MoveToElement(profilLjubimca, profilLjubimca.Size.Width - 10, profilLjubimca.Size.Height / 2).Click().Perform();

            var valueToSelect = "Fleksi Stjepanovic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, profilLjubimca.GetAttribute("Value.Value"));
        }

        [When(@"the user clicks on the ""([^""]*)"" button of feature D")]
        public void WhenTheUserClicksOnTheButtonOfFeatureD(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var deleteButton = formProfil.FindElementByAccessibilityId("btnObrisiProfil");
            deleteButton.Click();
        }

        [Then(@"the deleted pet profile is no longer available in the dropdown list")]
        public void ThenTheDeletedPetProfileIsNoLongerAvailableInTheDropdownList()
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");
            var profilLjubimca = formProfil.FindElementByAccessibilityId("cmbProfili");
            Actions action = new Actions(driver);
            action.MoveToElement(profilLjubimca, profilLjubimca.Size.Width - 10, profilLjubimca.Size.Height / 2).Click().Perform();
            Thread.Sleep(1000);
        }

        [When(@"the user selects the pet ""([^""]*)"" from the dropdown menu")]
        public void WhenTheUserSelectsThePetFromTheDropdownMenu(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var profilLjubimca = formProfil.FindElementByAccessibilityId("cmbProfili");
            Actions action = new Actions(driver);
            action.MoveToElement(profilLjubimca, profilLjubimca.Size.Width - 10, profilLjubimca.Size.Height / 2).Click().Perform();

            var valueToSelect = "Mara Stjepanovic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, profilLjubimca.GetAttribute("Value.Value"));
        }

        [When(@"the user updates certain enabled fields with the following information:")]
        public void WhenTheUserUpdatesCertainEnabledFieldsWithTheFollowingInformation(Table table)
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var rows = table.Rows;

            var ime = formProfil.FindElementByAccessibilityId("txtIme");
            ime.SendKeys(rows[0]["Ime"]);

            var prezime = formProfil.FindElementByAccessibilityId("txtPrezime");
            prezime.SendKeys(rows[0]["Prezime"]);

            var tezina = formProfil.FindElementByAccessibilityId("txtTezina");
            tezina.SendKeys(rows[0]["Tezina_Kg"]);

            var visina = formProfil.FindElementByAccessibilityId("txtVisina");
            visina.SendKeys(rows[0]["Visina_Cm"]);

        }

        [When(@"the user clicks the ""([^""]*)"" button")]
        public void WhenTheUserClicksTheButton(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            var urediButton = formProfil.FindElementByAccessibilityId("btnUredi");
            urediButton.Click();
        }

        [Then(@"the updated pet is automatically visible in the dropdown menu")]
        public void ThenTheUpdatedPetIsAutomaticallyVisibleInTheDropdownMenu()
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");
            var profilLjubimca = formProfil.FindElementByAccessibilityId("cmbProfili");
            Actions action = new Actions(driver);
            action.MoveToElement(profilLjubimca, profilLjubimca.Size.Width - 10, profilLjubimca.Size.Height / 2).Click().Perform();
            Thread.Sleep(5000);

        }

        [When(@"the user clicks logout")]
        public void WhenTheUserClicksLogout()
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");
            var logoutButton = formProfil.FindElementByAccessibilityId("btnBack");
            logoutButton.Click();

        }

        [Then(@"the user is on the welcome form of feature")]
        public void ThenTheUserIsOnTheWelcomeFormOfFeature()
        {
            var driverNew = GuiDriver.GetDriver();

            Console.WriteLine($"Number of open windows: {driverNew.WindowHandles.Count}");
            foreach (var handle in driverNew.WindowHandles)
            {
                driverNew.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driverNew.Title}");
            }

            bool isFormOpen = driverNew.FindElementByAccessibilityId("FrmPocetna") != null; //provjera je li prozor otvoren
            bool isCorrectTitle = driverNew.Title == "Dobrodošli!"; //naziv prozora u lijevom gornjem kutu
            Assert.IsTrue(isFormOpen && isCorrectTitle);
        }

        [Then(@"the user clicks button for login")]
        public void ThenTheUserClicksButtonForLogin()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var pocetnaForm = driver.FindElementByAccessibilityId("FrmPocetna");
            var buttonElement = pocetnaForm.FindElementByAccessibilityId("btnPrijava");
            buttonElement.Click();
        }

        [Then(@"the user entering valid credentials:")]
        public void ThenTheUserEnteringValidCredentials(Table table)
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

            var formLoginUser = loginDriver.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginUser.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["Korisnicko"]);
            formLoginUser.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["Lozinka"]);
        }

        [Then(@"the user clicks button for login-homeForm")]
        public void ThenTheUserClicksButtonForLogin_HomeForm()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

        [Then(@"the user selects Profile form")]
        public void ThenTheUserSelectsProfileForm()
        {
            var driver = GuiDriver.GetDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var frmKorisnik = driver.FindElementByAccessibilityId("FrmKorisnik");
            var btnProfil = frmKorisnik.FindElementByAccessibilityId("btnProfil");
            btnProfil.Click();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var profilOwner = driver.FindElementByAccessibilityId("FrmProfil");
            var isCorrectTitle = driver.Title == "FrmProfil";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            Assert.IsTrue(profilOwner.Displayed);
        }

        [When(@"the user clicks on the dropdown to select a pet")]
        public void WhenTheUserClicksOnTheDropdownToSelectAPet()
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");
            var profilLjubimca = formProfil.FindElementByAccessibilityId("cmbProfili");
            Actions action = new Actions(driver);
            action.MoveToElement(profilLjubimca, profilLjubimca.Size.Width - 10, profilLjubimca.Size.Height / 2).Click().Perform();
            Thread.Sleep(5000);
        }

        [Then(@"the user should receive a message stating that at least one pet profile needs to be created before selecting a pet")]
        public void ThenTheUserShouldReceiveAMessageStatingThatAtLeastOnePetProfileNeedsToBeCreatedBeforeSelectingAPet()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");

            // Klikni na gumb Spremi da bi se kliknulo izvan combobox-a
            var imeIme = formProfil.FindElementByAccessibilityId("txtIme");
            Actions action = new Actions(driver);
            action.MoveToElement(imeIme).Click().Perform();

            Thread.Sleep(2000);

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Odaberite ljubimca. Ako ga nemate, kreirajte ga!";

                // pričekajte da se prikaže dijaloški okvir
                Thread.Sleep(10000); // pričekajte da se dijaloški okvir u potpunosti učita
                var messageBox = driver.FindElement(By.Name("Odaberite ljubimca. Ako ga nemate, kreirajte ga!"));
                var messageBoxText = messageBox.Text;

                // provjerite je li poruka ispravna
                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }
    }
}
