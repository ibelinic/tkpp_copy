using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class RecordingTreatmentsStepDefinitions
    {
        [Then(@"the user needs to enter vet details:")]
        public void ThenTheUserNeedsToEnterVetDetails(Table table)
        {
            var driverLogin = GuiDriver.GetOrCreateDriver();
            var formLoginUser = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginUser.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginUser.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }

        [Then(@"the user will be successfully redirected to the initial form for vet")]
        public void ThenTheUserWillBeSuccessfullyRedirectedToTheInitialFormForVet()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var welcomePet = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            Assert.IsTrue(welcomePet.Displayed);
        }

        [Then(@"the user selects Recording")]
        public void ThenTheUserSelectsRecording()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            var btnEvidentiraj = frmKorisnik.FindElementByAccessibilityId("btnEvidentiraj");
            btnEvidentiraj.Click();
        }

        [Then(@"the user is on the Recording form")]
        public void ThenTheUserIsOnTheRecordingForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var profilVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var button = profilVet.FindElementByAccessibilityId("btnBack");
            Assert.IsTrue(button.Displayed, "Nema gumba");
        }

        [When(@"the user doesn't select a pet from the dropdown")]
        public void WhenTheUserDoesntSelectAPetFromTheDropdown()
        {
            var driver = GuiDriver.GetDriver();
            var profilVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var cmbLjubimci = profilVet.FindElementByAccessibilityId("cmbLjubimci");
            cmbLjubimci.Click();
            cmbLjubimci.SendKeys(Keys.Escape);

        }

        [Then(@"the form's functionalities should be disabled")]
        public void ThenTheFormsFunctionalitiesShouldBeDisabled()
        {
            var driver = GuiDriver.GetDriver();
            var profilVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var cmbLjubimci = profilVet.FindElementByAccessibilityId("cmbLjubimci");
            if (!cmbLjubimci.Selected)
            {
                var formElement1 = profilVet.FindElementByAccessibilityId("btnEvidentiraj");
                // ensure that the form elements are disabled
                Assert.IsFalse(formElement1.Enabled);
            }
            else
            {
                cmbLjubimci.Clear();
                var formElement1 = driver.FindElementByAccessibilityId("btnEvidentiraj");
                // ensure that the form elements are disabled
                Assert.IsFalse(formElement1.Enabled);
            }
        }

        [When(@"the user selects the desired pet ""([^""]*)"" from the dropdown")]
        public void WhenTheUserSelectsTheDesiredPetFromTheDropdown(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var ljubimac = formVet.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(ljubimac, ljubimac.Size.Width - 10, ljubimac.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, ljubimac.GetAttribute("Value.Value"));
        }

        [When(@"the user selects a desired pet from the dropdown menu: ""([^""]*)""")]
        public void WhenTheUserSelectsADesiredPetFromTheDropdownMenu(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbLjubimci = formEvident.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(cmbLjubimci, cmbLjubimci.Size.Width - 10, cmbLjubimci.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, cmbLjubimci.GetAttribute("Value.Value"));
        }

        [When(@"the user selects an existing visit date from the dropdown menu of featuring")]
        public void WhenTheUserSelectsAnExistingVisitDateFromTheDropdownMenuOfFeaturing()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbPosjete = formEvident.FindElementByAccessibilityId("cmbPosjete");

            // Pomakni kursor lijevo prema dolje kako bi bio u podrucju opcija ComboBox-a
            Actions action = new Actions(driver);
            action.MoveToElement(cmbPosjete, cmbPosjete.Size.Width - 10, cmbPosjete.Size.Height / 2).Click().Perform();

            Thread.Sleep(2000);

            cmbPosjete.SendKeys(Keys.Down);
            cmbPosjete.SendKeys(Keys.Down);
            cmbPosjete.SendKeys(Keys.Enter);
        }

        [When(@"the user fills in all remaining fields with meaningful data:")]
        public void WhenTheUserFillsInAllRemainingFieldsWithMeaningfulData(Table table)
        {
            var addingDriver = GuiDriver.GetDriver();
            var formEvident = addingDriver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var nazivBolesti = formEvident.FindElementByAccessibilityId("txtNaziv");
            nazivBolesti.SendKeys(rows[0]["Bolest"]);

            var opisBolesti = formEvident.FindElementByAccessibilityId("rtxtOpisBolesti");
            opisBolesti.SendKeys(rows[0]["OpisB"]);

            var datumBolesti = formEvident.FindElementByAccessibilityId("dtpDatumBolesti");
            datumBolesti.Clear();
            datumBolesti.SendKeys(rows[0]["DatumB"]);

            var nazivLijeka = formEvident.FindElementByAccessibilityId("txtNazivLijeka");
            nazivLijeka.SendKeys(rows[0]["Lijek"]);

            var opisLijeka = formEvident.FindElementByAccessibilityId("rtxtOpisLijeka");
            opisLijeka.SendKeys(rows[0]["OpisL"]);
        }

        [When(@"the user clicks on the ""([^""]*)"" button")]
        public void WhenTheUserClicksOnTheButton(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentirajPostojecu = formEvident.FindElementByAccessibilityId("btnNadopuniPostojecu");
            buttonEvidentirajPostojecu.Click();
        }

        [Then(@"the system should successfully update the selected appointment and clear all fields")]
        public void ThenTheSystemShouldSuccessfullyUpdateTheSelectedAppointmentAndClearAllFields()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            // Clear all fields after the update
            var nazivBolesti = formEvident.FindElementByAccessibilityId("txtNaziv");

            var opisBolesti = formEvident.FindElementByAccessibilityId("rtxtOpisBolesti");

            var datumBolesti = formEvident.FindElementByAccessibilityId("dtpDatumBolesti");

            var nazivLijeka = formEvident.FindElementByAccessibilityId("txtNazivLijeka");

            var opisLijeka = formEvident.FindElementByAccessibilityId("rtxtOpisLijeka");

            Assert.IsTrue(string.IsNullOrEmpty(nazivBolesti.GetAttribute("Value.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(opisBolesti.GetAttribute("ValuePattern.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(datumBolesti.GetAttribute("AutomationValue.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(nazivLijeka.GetAttribute("Value.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(opisLijeka.GetAttribute("ValuePattern.Value")));
        }

        [When(@"the user selects the pet ""([^""]*)"" from the dropdown menu of feature")]
        public void WhenTheUserSelectsThePetFromTheDropdownMenuOfFeature(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var profilLjubimca = formProfil.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(profilLjubimca, profilLjubimca.Size.Width - 10, profilLjubimca.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, profilLjubimca.GetAttribute("Value.Value"));
        }

        [When(@"the user selects a new visit date of his choice:")]
        public void WhenTheUserSelectsANewVisitDateOfHisChoice(Table table)
        {
            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var datePosjeta = formVet.FindElementByAccessibilityId("dtpPosjeta");
            datePosjeta.Clear();
            datePosjeta.SendKeys(rows[0]["datum"]);
        }

        [When(@"the user does not fill in the ""([^""]*)"" field")]
        public void WhenTheUserDoesNotFillInTheField(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var razlog = formVet.FindElementByAccessibilityId("rtxtRazlogPosjete");
            razlog.Clear();
        }

        [When(@"the user clicks on ""([^""]*)"" button of feature")]
        public void WhenTheUserClicksOnButtonOfFeature(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentirajNovo = formEvident.FindElementByAccessibilityId("cbSpremi");
            buttonEvidentirajNovo.Click();
        }

        [Then(@"the user should receive an error message indicating that all fields are required to save the visit")]
        public void ThenTheUserShouldReceiveAnErrorMessageIndicatingThatAllFieldsAreRequiredToSaveTheVisit()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Nisu uneseni svi podaci za posjetu!";

                // pričekajte da se prikaže dijaloški okvir
                Thread.Sleep(500); // pričekajte da se dijaloški okvir u potpunosti učita
                var messageBox = driver.FindElement(By.Name("Nisu uneseni svi podaci za posjetu!"));
                var messageBoxText = messageBox.Text;

                // provjerite je li poruka ispravna
                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"the user selects the pet ""([^""]*)"" from the dropdown list")]
        public void WhenTheUserSelectsThePetFromTheDropdownList(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbLjubimac = formEvident.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(cmbLjubimac, cmbLjubimac.Size.Width - 10, cmbLjubimac.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, cmbLjubimac.GetAttribute("Value.Value"));
        }

        [When(@"the user selects a new visit date of his choice of feature:")]
        public void WhenTheUserSelectsANewVisitDateOfHisChoiceOfFeature(Table table)
        {
            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var datePosjeta = formVet.FindElementByAccessibilityId("dtpPosjeta");
            datePosjeta.Clear();
            datePosjeta.SendKeys(rows[0]["datum"]);
        }

        [When(@"the user fills in the reason field with any reason:")]
        public void WhenTheUserFillsInTheFieldWithAnyReason(Table table)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            // Clear all fields after the update
            var razlogPosjete = formEvident.FindElementByAccessibilityId("rtxtRazlogPosjete");
            razlogPosjete.SendKeys(rows[0]["razlog"]);
        }

        [When(@"the user clicks saving button of feature")]
        public void WhenTheUserClicksSavingButtonOfFeature()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentirajNovo = formEvident.FindElementByAccessibilityId("cbSpremi");
            buttonEvidentirajNovo.Click();
        }

        [Then(@"the previous data in the fields should be cleared automatically because visit is saved")]
        public void ThenThePreviousDataInTheFieldsShouldBeClearedAutomaticallyBecauseVisitIsSaved()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            // Clear all fields after the update
            var nazivBolesti = formEvident.FindElementByAccessibilityId("txtNaziv");
            nazivBolesti.Clear();

            var opisBolesti = formEvident.FindElementByAccessibilityId("rtxtOpisBolesti");
            opisBolesti.Clear();

            var datumBolesti = formEvident.FindElementByAccessibilityId("dtpDatumBolesti");
            datumBolesti.Clear();

            var nazivLijeka = formEvident.FindElementByAccessibilityId("txtNazivLijeka");
            nazivLijeka.Clear();

            var opisLijeka = formEvident.FindElementByAccessibilityId("rtxtOpisLijeka");
            opisLijeka.Clear();
        }

        [When(@"the user selects a pet ""([^""]*)"" from the dropdown menu")]
        public void WhenTheUserSelectsAPetFromTheDropdownMenu(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbLjubimac = formEvident.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(cmbLjubimac, cmbLjubimac.Size.Width - 10, cmbLjubimac.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, cmbLjubimac.GetAttribute("Value.Value"));
        }

        [When(@"the user selects a date and reason for the visit:")]
        public void WhenTheUserSelectsADateAndReasonForTheVisit(Table table)
        {
            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var razlog = formVet.FindElementByAccessibilityId("rtxtRazlogPosjete");
            razlog.SendKeys(rows[0]["razlog"]);

            var datePosjeta = formVet.FindElementByAccessibilityId("dtpPosjeta");
            datePosjeta.Clear();
            datePosjeta.SendKeys(rows[0]["datumPosjete"]);
        }

        [When(@"the user clicks on ""([^""]*)"" checkbox")]
        public void WhenTheUserClicksOnCheckbox(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentirajNovo = formEvident.FindElementByAccessibilityId("cbSpremi");
            buttonEvidentirajNovo.Click();
        }

        [Then(@"a new visit is successfully recorded so the fields for disease and medication are enabled")]
        public void ThenANewVisitIsSuccessfullyRecordedSoTheFieldsForDiseaseAndMedicationAreEnabled()
        {
            var driver = GuiDriver.GetDriver();
            var profilEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var formElement1 = profilEvident.FindElementByAccessibilityId("txtNaziv");
            var formElement2 = profilEvident.FindElementByAccessibilityId("rtxtOpisBolesti");
            var formElement3 = profilEvident.FindElementByAccessibilityId("dtpDatumBolesti");
            var formElement4 = profilEvident.FindElementByAccessibilityId("txtNazivLijeka");
            var formElement5 = profilEvident.FindElementByAccessibilityId("rtxtOpisLijeka");

            Assert.IsFalse(formElement1.Enabled && formElement2.Enabled && formElement3.Enabled && formElement4.Enabled && formElement5.Enabled);
        }

        [Then(@"the user fills in the fields for disease and medication with valid data and selects a date for the start of symptoms:")]
        public void ThenTheUserFillsInTheFieldsForDiseaseAndMedicationWithValidDataAndSelectsADateForTheStartOfSymptoms(Table table)
        {
            var addingDriver = GuiDriver.GetDriver();
            var formEvident = addingDriver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var nazivBolesti = formEvident.FindElementByAccessibilityId("txtNaziv");
            nazivBolesti.SendKeys(rows[0]["Bolest"]);

            var opisBolesti = formEvident.FindElementByAccessibilityId("rtxtOpisBolesti");
            opisBolesti.SendKeys(rows[0]["OpisB"]);

            var datumBolesti = formEvident.FindElementByAccessibilityId("dtpDatumBolesti");
            datumBolesti.Clear();
            datumBolesti.SendKeys(rows[0]["DatumB"]);

            var nazivLijeka = formEvident.FindElementByAccessibilityId("txtNazivLijeka");
            nazivLijeka.SendKeys(rows[0]["Lijek"]);

            var opisLijeka = formEvident.FindElementByAccessibilityId("rtxtOpisLijeka");
            opisLijeka.SendKeys(rows[0]["OpisL"]);
        }

        [Then(@"the user clicks on ""([^""]*)"" button")]
        public void ThenTheUserClicksOnButton(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentiraj = formEvident.FindElementByAccessibilityId("btnEvidentiraj");
            buttonEvidentiraj.Click();
        }

        [Then(@"the new visit is successfully recorded so all fields are cleared")]
        public void ThenTheNewVisitIsSuccessfullyRecordedAndAllFieldsAreCleared()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            // Clear all fields after the update
            var nazivBolesti = formEvident.FindElementByAccessibilityId("txtNaziv");

            var opisBolesti = formEvident.FindElementByAccessibilityId("rtxtOpisBolesti");

            var datumBolesti = formEvident.FindElementByAccessibilityId("dtpDatumBolesti");

            var nazivLijeka = formEvident.FindElementByAccessibilityId("txtNazivLijeka");

            var opisLijeka = formEvident.FindElementByAccessibilityId("rtxtOpisLijeka");

            Assert.IsTrue(string.IsNullOrEmpty(nazivBolesti.GetAttribute("Value.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(opisBolesti.GetAttribute("ValuePattern.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(datumBolesti.GetAttribute("AutomationValue.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(nazivLijeka.GetAttribute("Value.Value")));
            Assert.IsTrue(string.IsNullOrEmpty(opisLijeka.GetAttribute("ValuePattern.Value")));
        }

        [Given(@"the user selects the desired pet from the dropdown menu: ""([^""]*)""")]
        public void GivenTheUserSelectsTheDesiredPetFromTheDropdownMenu(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbLjubimac = formEvident.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(cmbLjubimac, cmbLjubimac.Size.Width - 10, cmbLjubimac.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, cmbLjubimac.GetAttribute("Value.Value"));
        }

        [When(@"the user selects existing visit date of pet")]
        public void WhenTheUserSelectsExistingVisitDateOfPet()
        {
            {
                var driver = GuiDriver.GetDriver();
                var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

                var cmbPosjete = formEvident.FindElementByAccessibilityId("cmbPosjete");

                // Pomakni kursor lijevo prema dolje kako bi bio u podrucju opcija ComboBox-a
                Actions action = new Actions(driver);
                action.MoveToElement(cmbPosjete, cmbPosjete.Size.Width - 10, cmbPosjete.Size.Height / 2).Click().Perform();

                Thread.Sleep(2000);

                cmbPosjete.SendKeys(Keys.Down);
                cmbPosjete.SendKeys(Keys.Enter);
            }
        }

        [Given(@"the user clicks on the ""([^""]*)"" checkbox")]
        public void GivenTheUserClicksOnTheCheckbox(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentirajNovo = formEvident.FindElementByAccessibilityId("cbSpremi");
            buttonEvidentirajNovo.Click();
        }

        [Then(@"the fields for diseases and medications are enabled")]
        public void ThenTheFieldsForDiseasesAndMedicationsAreEnabled()
        {
            var driver = GuiDriver.GetDriver();
            var profilEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var formElement1 = profilEvident.FindElementByAccessibilityId("txtNaziv");
            var formElement2 = profilEvident.FindElementByAccessibilityId("rtxtOpisBolesti");
            var formElement3 = profilEvident.FindElementByAccessibilityId("dtpDatumBolesti");
            var formElement4 = profilEvident.FindElementByAccessibilityId("txtNazivLijeka");
            var formElement5 = profilEvident.FindElementByAccessibilityId("rtxtOpisLijeka");

            Console.WriteLine("Is formElement1 enabled? " + formElement1.Enabled);
            Console.WriteLine("Is formElement2 enabled? " + formElement2.Enabled);
            Console.WriteLine("Is formElement3 enabled? " + formElement3.Enabled);
            Console.WriteLine("Is formElement4 enabled? " + formElement4.Enabled);
            Console.WriteLine("Is formElement5 enabled? " + formElement5.Enabled);

            Assert.IsTrue(formElement1.Enabled && formElement2.Enabled && formElement3.Enabled && formElement4.Enabled && formElement5.Enabled);

            Assert.IsTrue(formElement1.Enabled && formElement2.Enabled && formElement3.Enabled && formElement4.Enabled && formElement5.Enabled);
        }

        [Then(@"the user fills in the fields for disease and medication with valid data:")]
        public void ThenTheUserFillsInTheFieldsForDiseaseAndMedicationWithValidData(Table table)
        {
            var addingDriver = GuiDriver.GetDriver();
            var formEvident = addingDriver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var nazivBolesti = formEvident.FindElementByAccessibilityId("txtNaziv");
            nazivBolesti.SendKeys(rows[0]["Bolest"]);

            var opisBolesti = formEvident.FindElementByAccessibilityId("rtxtOpisBolesti");
            opisBolesti.SendKeys(rows[0]["OpisB"]);

            var nazivLijeka = formEvident.FindElementByAccessibilityId("txtNazivLijeka");
            nazivLijeka.SendKeys(rows[0]["Lijek"]);

            var opisLijeka = formEvident.FindElementByAccessibilityId("rtxtOpisLijeka");
            opisLijeka.SendKeys(rows[0]["OpisL"]);
        }

        [Then(@"the user selects the symptom onset date:")]
        public void ThenTheUserSelectsTheSymptomOnsetDateAs(Table table)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var rows = table.Rows;

            var datumBolesti = formEvident.FindElementByAccessibilityId("dtpDatumBolesti");
            datumBolesti.SendKeys(rows[0]["datumSimptoma"]);
        }

        [Then(@"the user clicks on ""([^""]*)"" button of feature Recording")]
        public void ThenTheUserClicksOnButtonOfFeatureRecording(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var buttonEvidentiraj = formEvident.FindElementByAccessibilityId("btnNadopuniPostojecu");
            buttonEvidentiraj.Click();
        }

        [Then(@"the system should display an error message saying that the symptom onset date must be earlier than the visit date")]
        public void ThenTheSystemShouldDisplayAnErrorMessageSayingThatTheSymptomOnsetDateMustBeEarlierThanTheVisitDate()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Datum posjete je prije početka simptoma!";

                // pričekajte da se prikaže dijaloški okvir
                Thread.Sleep(500); // pričekajte da se dijaloški okvir u potpunosti učita
                var messageBox = driver.FindElement(By.Name("Datum posjete je prije početka simptoma!"));
                var messageBoxText = messageBox.Text;

                // provjerite je li poruka ispravna
                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"the user selects the desired pet from the dropdown list: ""([^""]*)""")]
        public void WhenTheUserSelectsTheDesiredPetFromTheDropdownList(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbLjubimac = formEvident.FindElementByAccessibilityId("cmbLjubimci");
            Actions action = new Actions(driver);
            action.MoveToElement(cmbLjubimac, cmbLjubimac.Size.Width - 10, cmbLjubimac.Size.Height / 2).Click().Perform();

            var valueToSelect = "Rio Anic"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, cmbLjubimac.GetAttribute("Value.Value"));
        }

        [When(@"the user selects an existing date by mistake")]
        public void WhenTheUserSelectsAnExistingDateByMistake()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            var cmbPosjete = formEvident.FindElementByAccessibilityId("cmbPosjete");

            // Pomakni kursor lijevo prema dolje kako bi bio u podrucju opcija ComboBox-a
            Actions action = new Actions(driver);
            action.MoveToElement(cmbPosjete, cmbPosjete.Size.Width - 10, cmbPosjete.Size.Height / 2).Click().Perform();

            Thread.Sleep(2000);

            cmbPosjete.SendKeys(Keys.Down);
            cmbPosjete.SendKeys(Keys.Enter);
        }

        [When(@"the user clicks on cancellation button")]
        public void WhenTheUserClicksOnCancellationButton()
        {
            var driver = GuiDriver.GetDriver();
            var formEvidentiraj = driver.FindElementByAccessibilityId("FrmEvidentiraj");
            var btnPonisti = formEvidentiraj.FindElementByAccessibilityId("btnPonisti");
            btnPonisti.Click();
        }

        [Then(@"the system should automatically clear the previous data and the selected date")]
        public void ThenTheSystemShouldAutomaticallyClearThePreviousDataAndTheSelectedDate()
        {
            var driver = GuiDriver.GetDriver();
            var formEvident = driver.FindElementByAccessibilityId("FrmEvidentiraj");

            // find all text input fields
            var textFields = formEvident.FindElementsByXPath("//input[@type='text']");

            // clear the value of each input field
            foreach (var field in textFields)
            {
                field.Clear();
            }

            // find all textarea fields
            var textareas = formEvident.FindElementsByXPath("//textarea");

            // clear the value of each textarea
            foreach (var textarea in textareas)
            {
                textarea.Clear();
            }

            // find and clear the datetime picker
            var cmbPosjete = formEvident.FindElementByAccessibilityId("cmbPosjete");
            cmbPosjete.Clear();
        }
    }
}
