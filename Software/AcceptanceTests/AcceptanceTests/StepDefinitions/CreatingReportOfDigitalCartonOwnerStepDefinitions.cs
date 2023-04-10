using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CreatingReportOfDigitalCartonOwnerStepDefinitions
    {
        [Given(@"User need to go to profil")]
        public void GivenUserNeedToGoToProfil()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var formaPocetna = driver.FindElementByAccessibilityId("FrmKorisnik");
            var buttonProfil = formaPocetna.FindElementByAccessibilityId("btnProfil");
            buttonProfil.Click();
        }

        [When(@"User selects pet:")]
        public void WhenUserSelectsPet(Table table)
        {
            var driverProfil = GuiDriver.GetOrCreateDriver();
            Console.WriteLine($"Number of open windows: {driverProfil.WindowHandles.Count}");
            foreach (var handle in driverProfil.WindowHandles)
            {
                driverProfil.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {driverProfil.Title}");
            }
            var formProfil = driverProfil.FindElementByAccessibilityId("FrmProfil");
            var isCorrectTitle = driverProfil.Title == "FrmProfil";
            Assert.IsTrue(isCorrectTitle, "Naziv prozora nije ispravan");

            var rows = table.Rows;
            Thread.Sleep(2000);
            var comboBoxElement = formProfil.FindElementByAccessibilityId("cmbProfili");
            Console.WriteLine(comboBoxElement);
            comboBoxElement.Click();
            var comboBoxName = comboBoxElement.GetAttribute("Name");
            if (comboBoxElement.Displayed)
            {
                if (comboBoxName == "Rio Anic")
                {
                    comboBoxElement.Click();
                }

                // daljnje korake za odabir vrijednosti iz ComboBox-a možete dodati ovdje
                Assert.AreEqual(rows[0]["ljubimac"], comboBoxName);//provjera vrijednosti-combobox

            }
        }

        //cmbProfili
        //FrmProfil-> to je i naziv




        [When(@"User goes to digital carton")]
        public void WhenUserGoesToDigitalCarton()
        {
            //btnDigitalniKarton
            var driver = GuiDriver.GetOrCreateDriver();
            var formProfil = driver.FindElementByAccessibilityId("FrmProfil");
            var button = formProfil.FindElementByAccessibilityId("btnDigitalniKarton");
            button.Click();
        }

        [When(@"User selects pet appointment")]
        public void WhenUserSelectsPetAppointment()
        {
            //dgvPosjeta
            var profilDriver = GuiDriver.GetOrCreateDriver();

            Console.WriteLine($"Number of open windows: {profilDriver.WindowHandles.Count}");
            foreach (var handle in profilDriver.WindowHandles)
            {
                profilDriver.SwitchTo().Window(handle);
                Console.WriteLine($"Handle: {handle}, Title: {profilDriver.Title}");
            }

            var formProfil = profilDriver.FindElementByAccessibilityId("FrmDigitalniKarton");
            var dataGridView = formProfil.FindElementByAccessibilityId("dgvPosjeta");
            var rows = dataGridView.FindElements(By.TagName("DataGridRow"));
            if (rows.Count > 0)
            {
                rows[0].Click();
            }
        }

        [When(@"User goes to report")]
        public void WhenUserGoesToReport()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var formKarton = driver.FindElementByAccessibilityId("FrmDigitalniKarton");
            var button = formKarton.FindElementByAccessibilityId("btnIzvjestaj");
            button.Click();
        }


    }
}
