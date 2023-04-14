using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CancelingAnAppointmentStepDefinitions
    {
        [When(@"I select the second row in data grid view")]
        public void WhenISelectTheSecondRowInDataGridView()
        {
            var driver = GuiDriver.GetDriver();
            var dgvApp = driver.FindElementByAccessibilityId("dgvDostupniVeterinari");

            Actions action = new Actions(driver);
            action.MoveToElement(dgvApp, dgvApp.Size.Width - 10, dgvApp.Size.Height / 2).Click().Perform();

            Thread.Sleep(2000);

            dgvApp.SendKeys(Keys.Down);
            dgvApp.Click();
        }

        [When(@"I click the button Odjavi termin")]
        public void WhenIClickTheButtonOdjaviTermin()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnOdjavi = driver.FindElementByAccessibilityId("btnOdjaviTermin");

            btnOdjavi.Click();
        }

        [Then(@"I should should receive a message stating Nemate pravo odjaviti ovaj termin")]
        public void ThenIShouldShouldReceiveAMessageStatingNematePravoOdjavitiOvajTermin()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Nemate pravo odjaviti ovaj termin!";

                Thread.Sleep(500);
                var messageBox = driver.FindElement(By.Name("Nemate pravo odjaviti ovaj termin!"));
                var messageBoxText = messageBox.Text;

                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }

        [When(@"I select the first row in data grid view")]
        public void WhenISelectTheFirstRowInDataGridView()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            var formSlobodni = driver.FindElementByAccessibilityId("FrmDostupniVeterinari");
            var dgvDostupni = formSlobodni.FindElementByAccessibilityId("dgvDostupniVeterinari");

            Thread.Sleep(500);

            var rows = dgvDostupni.FindElements(By.ClassName("DataGridViewRow"));

            if (rows.Count > 0)
            {
                var firstCell = rows[0].FindElement(By.XPath(".//DataGridCell[1]"));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", firstCell);
            }
        }

        [Then(@"I should no longer see that appoitment")]
        public void ThenIShouldNoLongerSeeThatAppoitment()
        {
            var driverLogin = GuiDriver.GetDriver();
            var dgvApp = driverLogin.FindElementByAccessibilityId("dgvDostupniVeterinari");

            WebDriverWait wait = new WebDriverWait(driverLogin, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(dgvApp));

            var rows = dgvApp.FindElements(By.XPath("//tr"));

            bool isAppointmentVisible = false;
            foreach (var row in rows)
            {
                var cells = row.FindElements(By.XPath("./td"));
                if (cells.Count > 0 && cells[0].Text == "Klara Klaric")
                {
                    isAppointmentVisible = true;
                    break;
                }
            }

            Assert.IsFalse(isAppointmentVisible, "The appointment is still visible in the grid.");
        }

        [Then(@"I should should receive a message Termin uspješno odjavljen")]
        public void ThenIShouldShouldReceiveAMessageTerminUspjesnoOdjavljen()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");

                string expectedMessage = "Termin uspješno odjavljen!";

                Thread.Sleep(500); 
                var messageBox = driver.FindElement(By.Name("Termin uspješno odjavljen!"));
                var messageBoxText = messageBox.Text;

                Assert.AreEqual(expectedMessage, messageBoxText);
            }
        }
    }
}
