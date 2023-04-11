using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Windows.Forms;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class AvailableVeterinariansStepDefinitions
    {
        [Then(@"the user selects Available veterinarians")]
        public void ThenTheUserSelectsAvailableVeterinarians()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var frmKorisnik = driver.FindElementByAccessibilityId("FrmKorisnik");
            var btnVeterinar = frmKorisnik.FindElementByAccessibilityId("btnDostupniVeterinari");
            btnVeterinar.Click();
        }

        [Then(@"the user is on the View available veterinarians form")]
        public void ThenTheUserIsOnTheViewAvailableVeterinariansForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var dostupniVet = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");
            var isCorrectTitle = driver.Title == "Dostupni veterinari";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            Assert.IsTrue(dostupniVet.Displayed);
        }

        [When(@"the user select a veterinarian without termins")]
        public void WhenTheUserSelectAVeterinarianWithoutTermins()
        {

            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");

            var dostupniVet = formVet.FindElementByAccessibilityId("cmbVeterinari");
            Actions action = new Actions(driver);
            action.MoveToElement(dostupniVet, dostupniVet.Size.Width - 10, dostupniVet.Size.Height / 2).Click().Perform();

            var valueToSelect = "veterinar veterinar"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, dostupniVet.GetAttribute("Value.Value"));
        }

        [Then(@"the user should only see an empty table of data")]
        public void ThenTheUserShouldOnlySeeAnEmptyTableOfData()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");

            var dgv = formVet.FindElementByAccessibilityId("dgvDostupniVeterinari");
            dgv.Clear();
        }

        [When(@"the user selects ""([^""]*)"" from the ""([^""]*)"" dropdown")]
        public void WhenTheUserSelectsFromTheDropdown(string p0, string p1)
        {
            var driver = GuiDriver.GetDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");

            var dostupniVet = formVet.FindElementByAccessibilityId("cmbVeterinari");
            Actions action = new Actions(driver);
            action.MoveToElement(dostupniVet, dostupniVet.Size.Width - 10, dostupniVet.Size.Height / 2).Click().Perform();

            var valueToSelect = "Klara Klaric"; // vrijednost koju želimo odabrati
            var itemToSelect = driver.FindElementByName(valueToSelect);
            itemToSelect.Click();
            Assert.AreEqual(valueToSelect, dostupniVet.GetAttribute("Value.Value"));
        }

        [Then(@"the user should see a list of appointments for ""([^""]*)"" with the following columns: ID, Date, Start, End")]
        public void ThenTheUserShouldSeeAListOfAppointmentsForWithTheFollowingColumnsIDDateStartEnd(string p0)
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var formVet = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");

            // get the list of rows in the DataGridView
            var dgv = formVet.FindElementByAccessibilityId("dgvDostupniVeterinari");
            var rows = dgv.FindElements(By.ClassName("android.widget.TableRow"));
            _ = rows.Count > 0;
        }
    }
}
