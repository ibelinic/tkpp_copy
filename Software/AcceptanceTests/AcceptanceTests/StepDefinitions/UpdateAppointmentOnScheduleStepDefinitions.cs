using AcceptanceTests.Support;
using OpenQA.Selenium;
using System;
using System.Threading;
using System.Windows.Forms;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class UpdateAppointmentOnScheduleStepDefinitions
    {
        [When(@"User selects appointment")]
        public void WhenUserSelectsAppointment()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {driver.WindowHandles.Count}");
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driver.Title}");
            }

            var formRaspored = driver.FindElementByAccessibilityId("FrmRaspored");
            var dataGridView = formRaspored.FindElementByAccessibilityId("dgvRaspored");
            var rows = dataGridView.FindElements(By.TagName("DataGridRow"));
            if (rows.Count > 0)
            {
                rows[0].Click();
            }
        }

        [When(@"User selects button for update")]
        public void WhenUserSelectsButtonForUpdate()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmRaspored");
            var btnAžuriraj = formRaspored.FindElementByAccessibilityId("btnAžuriraj");
            btnAžuriraj.Click();
        }

        [When(@"User enter details:")]
        public void WhenUserEnterDetails(Table table)
        {
            var driverLogin = GuiDriver.GetDriver();

            var formLoginVeterinarian = driverLogin.FindElementByAccessibilityId("FrmAzurirajRaspored");

            var rows = table.Rows;
            // Unos datuma u prvi DateTime picker kontroler
            var dtpDatum = formLoginVeterinarian.FindElementByAccessibilityId("dtpDatum");
            dtpDatum.Clear();
            dtpDatum.SendKeys(rows[0]["datum"]);
        }

        [When(@"User press button ""([^""]*)""")]
        public void WhenUserPressButton(string update)
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmAzurirajRaspored");
            var btnAzuriraj = formRaspored.FindElementByAccessibilityId("btnAzuriraj");
            btnAzuriraj.Click();
        }

        [When(@"User select button for canceling")]
        public void WhenUserSelectButtonForCanceling()
        {
            GuiDriver.GetOrCreateDriver();
            var driver = GuiDriver.GetDriver();
            var formRaspored = driver.FindElementByAccessibilityId("FrmAzurirajRaspored");
            var btnOdustani = formRaspored.FindElementByAccessibilityId("btnOdustani");
            btnOdustani.Click();
        }
    }
}
