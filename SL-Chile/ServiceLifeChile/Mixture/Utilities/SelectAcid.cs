using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ServiceLife_Chile.mixture_acids_validation.Configurations;
using ServiceLife_Chile.mixture_acids_validation.StepDefinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Utilities
{
    class SelectAcid
    {
        public string _casAcetonitrile { get; set; }
        public string _casFormamide { get; set; }
        public string _casHexane { get; set; }
        public string _casStyrene { get; set; }
        public string _casSO2 { get; set; }
        public string _casAmmonia { get; set; }
        public string _casMethylamine { get; set; }
        public string _casHS { get; set; }
        public string _casAcetone { get; set; }
        public string _casToulene { get; set; }
        public string _casMEK { get; set; }
        public string _casMethyleneChloride { get; set; }
        public string _casHF { get; set; }
        public string _casAceticAcidEster { get; set; }
        public string _casXylene { get; set; }
        public string _exposure { get; set; }
        public string _exposureUnit { get; set; }
        public string _cartidge { get; set; }
        public string _atmospPressure { get; set; }
        public int _temperatureature { get; set; }
        public string _tempUnit { get; set; }
        public string _workRate { get; set; }
        public string _hours { get; set; }
        public string _humidity { get; set; }
        public string _expectedHours { get; set; }
        /// <summary>
        /// Select the required Acid using the Cas Number
        /// </summary>
        /// <param name="_casNumber"></param>
        public void SelectAcidRespirator(string _casNumber)
        {
            //Log entry
            MixtureAcidValidationsSteps._logger.Info("Trying to filter using the cas " +_casNumber);
            //Enter the cas value to filter the contaminant
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(_casNumber);
            MixtureAcidValidationsSteps._logger.Info("Waiting for the checkbox for the filtered contaminant");
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the filtered contaminant
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public void SetExpousreValue(string _exposure,string _expoUnit)
        {
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer._masterExposureValue)).SendKeys(_exposure);
            var _selectElement = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer._masterExposureUnit));
            SelectElement element = new SelectElement(_selectElement);
            if (_exposureUnit.Equals("ppm"))
            {
                element.SelectByValue("ppm");
            }
            else
            {
                element.SelectByValue("mg/m3");
                //Thread.Sleep(3000);
            }
        }
        public void SelectTheCartidgeorFilter(string _cartidge)
        {
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.casbox)).SendKeys(_cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer._masterContaminant);
            ClickAndReturn(_cartidge, XpathContainer._masterContaminant);
        }
        private static void ClickAndReturn(string cartidge, string element)
        {
            try
            {
                BrowserConfig.webDriver.FindElement(By.XPath(element)).Click();
            }
            catch (Exception ex)
            {
                throw new Exception("This  element " + cartidge + " was not found.");
            }
        }
        public void SetAtmosphericData(string humidity, string pressure, int temp, string tempunit, string workrate)
        {
            humidityfunc(humidity);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.pressurele)).Clear();
            ExplicitWait.WaitForAnElement(XpathContainer.pressurele);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.pressurele)).SendKeys(pressure);
            TemperatureUnit(tempunit, temp);
            WorkRate(workrate);

        }
        public static void humidityfunc(string humidity)
        {
            MixtureAcidValidationsSteps._logger.Info("Setting up the humidity  as " + humidity);
            ExplicitWait.WaitForAnElement(XpathContainer.rel_humidity);
            var exposureUnit = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.rel_humidity));
            //create select element object 
            var selectElement = new SelectElement(exposureUnit);
            if (humidity.Equals("<65%"))
            {
                selectElement.SelectByText("<65%");
            }
            else if (humidity.Equals("65%"))
            {
                selectElement.SelectByText("65%");
                //Thread.Sleep(3000);
            }
            else if (humidity.Equals("85"))
            {
                selectElement.SelectByText("85%");
                //Thread.Sleep(3000);
            }
            else if (humidity.Equals("75%"))
            {
                selectElement.SelectByText("75%");
                //Thread.Sleep(3000);
            }
            else if (humidity.Equals("90%"))
            {
                selectElement.SelectByText("90%");
                //Thread.Sleep(3000);
            }

        }
        public static void WorkRate(string workrate)
        {

            var wrkrate = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.wrkrate_drpdwn));
            //create select element object 
            var selectElement = new SelectElement(wrkrate);
            // Thread.Sleep(2000);
            if (workrate.Equals("Heavy"))
            {

                selectElement.SelectByText("Pesado");
            }
            else if (workrate.Equals("Medium"))
            {
                selectElement.SelectByText("Mediano");
                //Thread.Sleep(3000);
            }
            else if (workrate.Equals("Light"))
            {
                selectElement.SelectByText("Ligero");
                //Thread.Sleep(3000);
            }
            //else if (workrate.Equals("PAPR Loose"))
            //{
            //    selectElement.SelectByText("PAPR Loose Fitting");
            //    //Thread.Sleep(3000);
            //}
            //else if (workrate.Equals("PAPR Tight"))
            //{
            //    selectElement.SelectByText("PAPR Tight Fitting");
            //    //Thread.Sleep(3000);
            //}
        }
        public static void TemperatureUnit(string tempunit, int temp)
        {
            Console.WriteLine(tempunit);
            if (tempunit.Equals("Celsius"))
            {
                ExplicitWait.WaitForAnElement(XpathContainer.btn_celcius);
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.btn_celcius)).Click();
                temperature(temp);
            }
            else
            {
                ExplicitWait.WaitForAnElement(XpathContainer.btn_fahrenheit);
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.btn_fahrenheit)).Click();
                temperature(temp);
            }
        }
        public static void temperature(int temp)
        {
            // Console.WriteLine("The temperature is: " + temp);
            ExplicitWait.WaitForAnElement(XpathContainer.temp_drpdwn);
            var temperatureUnit = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.temp_drpdwn));
            //create select element object 
            var selectElement = new SelectElement(temperatureUnit);
            //  Thread.Sleep(2000);
            if (temp == 32)
            {
                selectElement.SelectByText("32");
            }
            else if (temp == 50)
            {
                selectElement.SelectByText("50");
            }
            else if (temp == 68)
            {
                selectElement.SelectByText("68");
            }
            else if (temp == 86)
            {
                selectElement.SelectByText("86");
            }
            else if (temp == 104)
            {
                selectElement.SelectByText("104");
            }
            else if (temp == 122)
            {
                selectElement.SelectByText("122");
            }
            else if (temp == 10)
            {
                selectElement.SelectByText("10");
            }
            else if (temp == 20)
            {
                selectElement.SelectByText("20");
            }
            else if (temp == 30)
            {
                selectElement.SelectByText("30");
            }
            else if (temp == 40)
            {
                selectElement.SelectByText("40");
            }
            else if (temp == 0)
            {
                selectElement.SelectByText("0");
            }
        }
        public  void VerifyHours(string workrate)
        {
            ExplicitWait.WaitForAnElement(XpathContainer.hours_value);
            string ActualHours = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.hours_value)).Text;
            bool donebtn = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Displayed;
            MixtureAcidValidationsSteps._logger.Info("Verifying if Actual hours matches the expected hours");

            Assert.AreEqual(ActualHours, workrate);
            ExplicitWait.WaitForAnElement(XpathContainer.next);
            if (donebtn)
            {
                MixtureAcidValidationsSteps._logger.Info("Clicking on the final done button");
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            }
            else
            {
                Console.WriteLine("Button not visible");
            }

        }
        
    }
}
