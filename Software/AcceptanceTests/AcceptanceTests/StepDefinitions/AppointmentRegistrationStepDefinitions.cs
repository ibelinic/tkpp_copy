using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Windows.Forms;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class AppointmentRegistrationStepDefinitions
    {
        [When(@"I select the veterinarian Klara Klaric from the dropdown list of veterinarians")]
        public void WhenISelectTheVeterinarianKlaraKlaricFromTheDropdownListOfVeterinarians()
        {
            var driver = GuiDriver.GetDriver();
            var formVeterinar = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");

            var veterinari = formVeterinar.FindElementByAccessibilityId("cmbVeterinari");
            Actions action = new Actions(driver);
            action.MoveToElement(veterinari, veterinari.Size.Width - 10, veterinari.Size.Height / 2).Click().Perform();

            var valueToSelect = "Klara Klaric";
            var itemToSelect = driver.FindElement(By.Name(valueToSelect));
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, veterinari.GetAttribute("Value.Value"));
        }

        [When(@"I click the button Prijavi termin")]
        public void WhenIClickTheButtonPrijaviTermin()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");
            var btnPrijavi = frmKorisnik.FindElementByAccessibilityId("btnPrijaviTermin");
            btnPrijavi.Click();
        }

        [Then(@"I should receive a message stating Ne mozete prijaviti termin u trenutnom vremenu")]
        public void ThenIShouldReceiveAMessageStatingNeMozetePrijavitiTerminUTrenutnomVremenu()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Ne mozete prijaviti termin u trenutnom vremenu!";

                Thread.Sleep(500);
                var messageBox = driver.FindElement(By.Name("Ne mozete prijaviti termin u trenutnom vremenu!"));
                var messageBoxText = messageBox.Text;

                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"I then fill with the following details:")]
        public void WhenIThenFillWithTheFollowingDetails(Table table)
        {
            var driver = GuiDriver.GetOrCreateDriver();

            var rows = table.Rows;

            var dtpDatum = driver.FindElementByAccessibilityId("dtpPregled");
            dtpDatum.Clear();
            dtpDatum.SendKeys(rows[0]["datum"]);

            var dtpPocetak = driver.FindElementByAccessibilityId("dtPocetak");
            dtpPocetak.Clear();
            dtpPocetak.SendKeys(rows[0]["vrijeme_pocetka"]);

            var dtpZavrsetak = driver.FindElementByAccessibilityId("dtZavrsetak");
            dtpZavrsetak.Clear();
            dtpZavrsetak.SendKeys(rows[0]["vrijeme_zavrsetka"]);

            var comboBoxElement = driver.FindElementByAccessibilityId("cmbLjubimac");
            var comboBoxName = comboBoxElement.GetAttribute("LegacyIAccessiblePattern.Name");
            if (comboBoxName == "Mela Stjepanovic")
            {
                comboBoxElement.Click();
                Assert.AreEqual(rows[0]["ljubimac"], comboBoxElement);
            }
        }

        [Then(@"I should receive a message stating Veterinar je u tom vremenu zauzet")]
        public void ThenIShouldReceiveAMessageStatingVeterinarJeUTomVremenuZauzet()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Veterinar je u tom vremenu zauzet!";

                Thread.Sleep(500);
                var messageBox = driver.FindElement(By.Name("Veterinar je u tom vremenu zauzet!"));
                var messageBoxText = messageBox.Text;

                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [Then(@"I should see the appoitment in the busy section")]
        public void ThenIShouldSeeTheAppoitmentInTheBusySection()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var dgvAppointments = driver.FindElementByAccessibilityId("dgvDostupniVeterinari");

            var rows = dgvAppointments.FindElementsByAccessibilityId("Row");

            foreach (var row in rows)
            {
                var dateCell = row.FindElement(By.Name("datum"));
                var startTimeCell = row.FindElement(By.Name("vrijeme_pocetka"));
                var endTimeCell = row.FindElement(By.Name("vrijeme_zavrsetka"));

                var expectedDate = "13.4.2023.";
                var expectedStartTime = "12:00:00";
                var expectedEndTime = "12:30:00";

                if (dateCell.Text == expectedDate &&
                    startTimeCell.Text == expectedStartTime &&
                    endTimeCell.Text == expectedEndTime)
                {
                    return; 
                }
            }

            Assert.Fail("Appointment not found in busy section"); 
        }

        [Then(@"I should receive a message stating Ne mozete prijaviti termin kraci od (.*) minuta")]
        public void ThenIShouldReceiveAMessageStatingNeMozetePrijavitiTerminKraciOdMinuta(int p0)
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Ne mozete prijaviti termin kraci od 30 minuta!";

                Thread.Sleep(500);
                var messageBox = driver.FindElement(By.Name("Ne mozete prijaviti termin kraci od 30 minuta!"));
                var messageBoxText = messageBox.Text;

                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }
    }
}
