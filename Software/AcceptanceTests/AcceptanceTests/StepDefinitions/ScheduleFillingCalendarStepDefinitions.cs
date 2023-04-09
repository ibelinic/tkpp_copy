using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class ScheduleFillingCalendarStepDefinitions
    {
        [Then(@"User needs to enter details:")]
        public void ThenUserNeedsToEnterDetails(Table table)
        {
            var driverLogin = GuiDriver.GetOrCreateDriver();
            var formLoginVeterinarian = driverLogin.FindElementByAccessibilityId("FrmPrijava");

            var rows = table.Rows;
            formLoginVeterinarian.FindElementByAccessibilityId("txtKorisnickoIme").SendKeys(rows[0]["korisnickoIme"]);
            formLoginVeterinarian.FindElementByAccessibilityId("txtLozinka").SendKeys(rows[0]["lozinka"]);
        }

        [Then(@"User login")]
        public void ThenUserLogin()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPrijava = driver.FindElementByAccessibilityId("FrmPrijava");
            var buttonPrijava = formPrijava.FindElementByAccessibilityId("btnPrijava");
            buttonPrijava.Click();
        }

     

        [Given(@"User clicks button his Schedule")]
        public void GivenUserClicksButtonHisSchedule()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPocetnaVeterinar = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            var btnRaspored = formPocetnaVeterinar.FindElementByAccessibilityId("btnRaspored");
            btnRaspored.Click();
        }

        [When(@"User select button for adding to the schedule")]
        public void WhenUserSelectButtonForAddingToTheSchedule()
        {

            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }
            var formRaspored = driver.FindElementByAccessibilityId("FrmRaspored");
           
            var btn = formRaspored.FindElementByAccessibilityId("btnDodaj");
            btn.Click();
        }

        [When(@"Form for adding schedule is open")]
        public void WhenFormForAddingScheduleIsOpen()
        {
            var addingDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {addingDriver.WindowHandles.Count}");
            foreach (var handle in addingDriver.WindowHandles)
            {
                addingDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {addingDriver.Title}");
            }

            var isCorrectTitle = addingDriver.Title == "Dodaj na raspored";
            var registrationFormButton = addingDriver.FindElementByAccessibilityId("dtpDatum");
            Assert.IsTrue(registrationFormButton.Displayed, "Forma za dodavanje nije otvorena");
        }

        [When(@"User then fill with the following details:")]
        public void WhenUserThenFillWithTheFollowingDetails(Table table)
        {
            var driverLogin = GuiDriver.GetDriver();

            var formLoginVeterinarian = driverLogin.FindElementByAccessibilityId("FrmDodajNaRaspored");

            var rows = table.Rows;
            // Unos datuma u prvi DateTime picker kontroler
            var dtpDatum = formLoginVeterinarian.FindElementByAccessibilityId("dtpDatum");
            dtpDatum.Clear();
            dtpDatum.SendKeys(rows[0]["datum"]);

            // Unos poèetnog vremena u drugi DateTime picker kontroler
            var dtpPocetak = formLoginVeterinarian.FindElementByAccessibilityId("dtpPocetak");
            dtpPocetak.Clear();
            dtpPocetak.SendKeys(rows[0]["vrijeme_pocetka"]);

            // Unos završnog vremena u treæi DateTime picker kontroler
            var dtpZavrsetak = formLoginVeterinarian.FindElementByAccessibilityId("dtpZavrsetak");
            dtpZavrsetak.Clear();
            dtpZavrsetak.SendKeys(rows[0]["vrijeme_zavrsetka"]);

            formLoginVeterinarian.FindElementByAccessibilityId("txtOpis").SendKeys(rows[0]["opis"]);

            
            var comboBoxElement = formLoginVeterinarian.FindElementByAccessibilityId("cmbLjubimac");
            var comboBoxName = comboBoxElement.GetAttribute("LegacyIAccessiblePattern.Name");
            if (comboBoxName == "Missy Anic")
            {
                comboBoxElement.Click();
                // daljnje korake za odabir vrijednosti iz ComboBox-a možete dodati ovdje
                Assert.AreEqual(rows[0]["ljubimac"], comboBoxElement);//provjera vrijednosti-combobox

            }

        }

        [When(@"Select button for adding")]
        public void WhenSelectButtonForAdding()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmDodajNaRaspored");
            var btnDodaj = formRaspored.FindElementByAccessibilityId("btnDodaj");
            btnDodaj.Click();
        }

        [Then(@"User should be able to view new appointment on the Schedule form")]
        public void ThenUserShouldBeAbleToViewNewAppointmentOnTheScheduleForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var formRaspored = driver.FindElementByAccessibilityId("FrmRaspored");
            Assert.IsTrue(formRaspored.Displayed);
        }


        [When(@"Select button for canceling")]
        public void WhenSelectButtonForCanceling()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmDodajNaRaspored");
            var btnDodaj = formRaspored.FindElementByAccessibilityId("btnOdustani");
            btnDodaj.Click();
        }
    }
}
