using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CreatingReportOfDigitalCartonStepDefinitions
    {
        [Given(@"User on the form for veterinarian should press button for report")]
        public void GivenUserOnTheFormForVeterinarianShouldPressButtonForReport()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formPocetnaVeterinar = driver.FindElementByAccessibilityId("FrmPocetnaVeterinar");
            var btnIzvjestaj = formPocetnaVeterinar.FindElementByAccessibilityId("btnIzvjestaj");
            btnIzvjestaj.Click();
        }
        [When(@"User selects pet from right corner:")]
        public void WhenUserSelectsPetFromRightCorner(Table table)
        {
            var driver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }
            var formIzvjestaj = driver.FindElementByAccessibilityId("FrmIzvjestajVeterinar");
            var isCorrectTitle = driver.Title == "Izvještaj";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var rows = table.Rows;
            var comboBoxElement = formIzvjestaj.FindElementByAccessibilityId("comboBox1");
            var comboBoxName = comboBoxElement.GetAttribute("LegacyIAccessiblePattern.Name");
            if (comboBoxName == "Rio Anic")
            {
                comboBoxElement.Click();
                var selectedValue = comboBoxElement.GetAttribute("Value.Value");
                // daljnje korake za odabir vrijednosti iz ComboBox-a možete dodati ovdje
                Assert.AreEqual(rows[0]["ljubimac"], selectedValue);//provjera vrijednosti-combobox

            }
        }


        [Then(@"User will be able to see form with report of selected pet")]
        public void ThenUserWillBeAbleToSeeFormWithReportOfSelectedPet()
        {
            var reportDriver = GuiDriver.GetDriver();
            Console.WriteLine($"Number of open windows: {reportDriver.WindowHandles.Count}");
            foreach (var handle in reportDriver.WindowHandles)
            {
                reportDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {reportDriver.Title}");
            }
            var formIzvjestaj = reportDriver.FindElementByAccessibilityId("FrmIzvjestajLjubimacKorisnik");
            var isCorrectTitle = reportDriver.Title == "Izvještaj";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");
            var report = formIzvjestaj.FindElementByAccessibilityId("FrmIzvjestajLjubimacKorisnik");
            Assert.IsTrue(report.Displayed, "Izvjestaj nije prikazan");
        }

        [When(@"User selects appointment of pet")]
        public void WhenUserSelectsAppointmentOfPet()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var formRaspored = driver.FindElementByAccessibilityId("FrmIzvjestajVeterinar");
            var dataGridView = formRaspored.FindElementByAccessibilityId("dgvPosjeta");
            var rows = dataGridView.FindElements(By.TagName("DataGridRow"));
            if (rows.Count > 0)
            {
                rows[0].Click();
            }
        }
        [When(@"User selects button for report")]
        public void WhenUserSelectsButtonForReport()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmIzvjestajVeterinar");
            var btnAžuriraj = formRaspored.FindElementByAccessibilityId("btnIzvjestajVeterinara");
            btnAžuriraj.Click();
        }


    }
}
