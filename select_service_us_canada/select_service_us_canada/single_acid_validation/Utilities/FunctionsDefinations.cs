using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using select_service_us_canada.single_acid_validation.Configurations;
using select_service_us_canada.single_acid_validation.StepDefinations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_service_us_canada.single_acid_validation.Utilities
{
    class FunctionsDefinations
    {
        private static string baseURL = ConfigurationManager.AppSettings.Get("url");
        private static string browser = ConfigurationManager.AppSettings.Get("browsers");
        /// <summary>
        /// Selecting the unit of temperature to be inputed ie ppm or mg3
        /// </summary>
        /// <param name="expunit"></param>
        /// 

        public static void ExpUnitDrop(string expunit, string cas)
        {
            var _selectExpousureElement = BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer._masterExposureUnit));
            Non_Mixture_ValidationSteps._logger.Info("Setting up the exposure unit " + expunit);
            var _customSelect = new SelectElement(_selectExpousureElement);
            if (expunit.Equals("ppm"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the exposure unit as ppm");
                _customSelect.SelectByValue("ppm");
            }
            else
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the exposure unit as mg/m3");
                _customSelect.SelectByValue("mg/m3");
            }

        }
        /// <summary>
        /// Selecting the value of temperature in Celsius or Farenhite
        /// </summary>
        /// <param name="temp"></param>
        public static void temperature(int temp)
        {
            // Console.WriteLine("The temperature is: " + temp);
            XplicitWait.WaitForAnElement(XpathContainer.tempDropDwn);
            var temperatureUnit = BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.tempDropDwn));
            //create select element object 
            var selectElement = new SelectElement(temperatureUnit);
            if (temp == 32)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 32");
                selectElement.SelectByText("32");
            }
            else if (temp == 50)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 50");
                selectElement.SelectByText("50");
            }
            else if (temp == 68)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 68");
                selectElement.SelectByText("68");
            }
            else if (temp == 86)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 86");
                selectElement.SelectByText("86");
            }
            else if (temp == 104)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 104");
                selectElement.SelectByText("104");
            }
            else if (temp == 122)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 122");
                selectElement.SelectByText("122");
            }
            else if (temp == 10)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 10");
                selectElement.SelectByText("10");
            }
            else if (temp == 20)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 20");
                selectElement.SelectByText("20");
            }
            else if (temp == 30)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 30");
                selectElement.SelectByText("30");
            }
            else if (temp == 40)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 40");
                selectElement.SelectByText("40");
            }
            else if (temp == 0)
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature as 0");
                selectElement.SelectByText("0");
            }
        }
        /// <summary>
        /// Navigating to the SLS Website using the URL provided
        /// </summary>
        public static void NavigateToSLS()
        {
            BrowserAndUrlConfig.NavigateToSLS();
            Non_Mixture_ValidationSteps._logger.Info("Sucessfully navigated to the url " + baseURL);
        }
        /// <summary>
        /// Selection of United States as my Region
        /// </summary>
        public static void RegionSelect(string region)
        {
            Non_Mixture_ValidationSteps._logger.Info("The region to be selected is " + region);

            string currentUrl = BrowserAndUrlConfig.webDriver.Url;
            if (currentUrl == "https://rssl-dev.azurewebsites.net/")
            {
                Non_Mixture_ValidationSteps._logger.Info("Waiting for the element " + XpathContainer.espain + "to be clickable");
                XplicitWait.WaitForAnElement(XpathContainer.espain);
                Non_Mixture_ValidationSteps._logger.Info("Clicking on the element " + XpathContainer.espain);
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.espain)).Click();

                Pause.WaitingForSomeTime();
                if (region == "United States")
                {
                    Non_Mixture_ValidationSteps._logger.Info("Setting up the region as United States");
                    BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.usRegionSelect)).Click();
                }
                else if (region == "Canada")
                {
                    Non_Mixture_ValidationSteps._logger.Info("Setting up the region as Canada");
                    BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.can_RegionSelect)).Click();
                }
                else if (region == "Mexico")
                {
                    Non_Mixture_ValidationSteps._logger.Info("Setting up the region as Mexico");
                    BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.mex_RegionSelect)).Click();
                }
                else if (region == "Brazil")
                {
                    Non_Mixture_ValidationSteps._logger.Info("Setting up the region as Brazil");
                    BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.Brazil_RegionSelect)).Click();
                }
            }
        }
        /// <summary>
        /// Proceed to next after selecting the Region as United States/Canada/Brazil/Mexico
        /// </summary>
        public static void ProccedToNext()
        {
            string currentUrl = BrowserAndUrlConfig.webDriver.Url;
            if (currentUrl == "https://rssl-dev.azurewebsites.net/")
            {
                Non_Mixture_ValidationSteps._logger.Info("Waiting for the element " + XpathContainer.IAccept + "to be clickable");
                XplicitWait.WaitForAnElement(XpathContainer.IAccept);
                Non_Mixture_ValidationSteps._logger.Info("Clicking on IAccept button after setting up the region");
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.IAccept)).Click();
            }
        }
        /// <summary>
        /// Select the Service life Check Box
        /// </summary>
        public static void ESLISelector()
        {
            Non_Mixture_ValidationSteps._logger.Info("Waiting for the eLSI checkbox to be clickable");
            XplicitWait.WaitForAnElement(XpathContainer.eLSI_selector);
            Non_Mixture_ValidationSteps._logger.Info("Clicking on the Service Life elsi selector");
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.eLSI_selector)).Click();
        }
        /// <summary>
        /// Accept after selecting the Service life In ESLI Selector
        /// </summary>
        public static void AcceptToMove()
        {
            Non_Mixture_ValidationSteps._logger.Info("Waiting for the next to be clickable");
            XplicitWait.WaitForAnElement(XpathContainer.IAccept);
            Non_Mixture_ValidationSteps._logger.Info("Clicking on the next button after selecting Service Life as elsi selector");
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.IAccept)).Click();
        }
        /// <summary>
        /// Filter the product using the CAS provided
        /// </summary>
        /// <param name="cas"></param>
        public static void FilterContaminantUsingCAS(string cas)
        {
            Non_Mixture_ValidationSteps._logger.Info("Waiting for the Search Box to be clickable");
            XplicitWait.WaitForAnElement(XpathContainer.searchBxCas);
            Non_Mixture_ValidationSteps._logger.Info("Sending the Cas Value " + cas + " to the Search Box to filter the products");
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.searchBxCas)).SendKeys(cas);
            Non_Mixture_ValidationSteps._logger.Info("Waiting for the filtered products to appear");
            XplicitWait.WaitForAnElement(XpathContainer.chkBx);
            Non_Mixture_ValidationSteps._logger.Info("Selecting the filtered product");
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.chkBx)).Click();
        }
        /// <summary>
        /// Enter the exposure and exposure unit
        /// </summary>
        /// <param name="exposure"></param>
        /// <param name="expunit"></param>
        /// <param name="cas"></param>
        public static void ExposureForSelectedProd(string exposure, string expunit, string cas)
        {
            Non_Mixture_ValidationSteps._logger.Info("Setting up the environment details");
            Non_Mixture_ValidationSteps._logger.Info("Setting up the exposure value for product " + cas + "as " + exposure);
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer._masterExposureValue)).SendKeys(exposure);

            ExpUnitDrop(expunit, cas);
            Non_Mixture_ValidationSteps._logger.Info("Clicking on the next button after setting up the environment details");
            XplicitWait.WaitForAnElement(XpathContainer.IAccept);
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.IAccept)).Click();
            BrowserAndUrlConfig.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        /// <summary>
        /// Proceed further by clicking on Done button
        /// </summary>
        public static void Done(string cas)
        {
            Console.WriteLine(cas);
            if ((cas == "71-43-2") || (cas == "50-00-0"))
            {
                XplicitWait.Wait();
                Non_Mixture_ValidationSteps._logger.Info("Clicking on the Done button");
                XplicitWait.WaitForAnElement(XpathContainer.okBtn);
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.okBtn)).Click();
                XplicitWait.Wait();
                XplicitWait.WaitForAnElement(XpathContainer.doneBtn);
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.doneBtn)).Click();
            }
            else
            {
                XplicitWait.Wait();
                Non_Mixture_ValidationSteps._logger.Info("Clicking on the Done button");
                XplicitWait.WaitForAnElement(XpathContainer.doneBtn);
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.doneBtn)).Click();
            }




        }
        /// <summary>
        /// Filter the cartidge using the CAS
        /// </summary>
        /// <param name="cartidge"></param>
        public static void FilterUsingCartidge(string cartidge)
        {
            Non_Mixture_ValidationSteps._logger.Info("Sending the cartidge value as " + cartidge + " after selecting the product using CAS");
            XplicitWait.WaitForAnElement(XpathContainer.searchBxCartidge);
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.searchBxCartidge)).SendKeys(cartidge);
        }
        /// <summary>
        /// Select the product filtered using the Cartidge
        /// </summary>
        /// <param name="cartidge"></param>
        public static void SelectFilteredProd(string cartidge)
        {
            Non_Mixture_ValidationSteps._logger.Info("Selecting the product with cartidge value as " + cartidge);
            string element = SwitchToFiltered(cartidge);
            XplicitWait.WaitForAnElement(element);
            Pause.WaitingForSomeTime();
            //try
            //{
            //    //BrowserAndUrlConfig.webDriver.FindElement(By.XPath(element)).Click();
            //    ClickAndReturn(cartidge,element);
            //}
            //catch (Exception ex)
            //{
            //    Non_Mixture_ValidationSteps._logger.Error(ex);
            //}
            ClickAndReturn(cartidge, element);
        }

        private static void ClickAndReturn(string cartidge,string element)
        {
            try
            {
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(element)).Click();
            }
            catch (Exception ex)
            {
                throw new Exception("This  element " + cartidge + " was not found.");
            }
        }

        /// <summary>
        /// Returns the element of the product filtered using CAS to the calling function
        /// </summary>
        /// <param name="cartidge"></param>
        /// <returns></returns>
        public static string SwitchToFiltered(string cartidge)
        {
            Console.WriteLine("This is the value of " + cartidge);
            string product = "";
            if (cartidge.Equals("6001") || cartidge.Equals("5303") || cartidge.Equals("6004") || cartidge.Equals("07193") || cartidge.Equals("07191") || cartidge.Equals("07192") || cartidge.Equals("6005") || cartidge.Equals("60925") || cartidge.Equals("GVP-445") || cartidge.Equals("60922") || cartidge.Equals("6009S") || cartidge.Equals("2076HF") || cartidge.Equals("5103") || cartidge.Equals("5203") || cartidge.Equals("5203") || cartidge.Equals("6003") || cartidge.Equals("60923") || cartidge.Equals("6006") || cartidge.Equals("60926") || cartidge.Equals("GVP-441") || cartidge.Equals("GVP-443") || cartidge.Equals("FR-64") || cartidge.Equals("FR-15CBRN") || cartidge.Equals("7093C") || cartidge.Equals("GVP-443") || cartidge.Equals("453-03-01") || cartidge.Equals("453-01-01")||cartidge.Equals("TR-6130E")||cartidge.Equals("TR-6580E") || cartidge.Equals("TR-6130E"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            else if (cartidge.Equals("7047") || cartidge.Equals("5201") || cartidge.Equals("5101") || cartidge.Equals("5301") || cartidge.Equals("60921") || cartidge.Equals("60924") || cartidge.Equals("60926") || cartidge.Equals("GVP-444") || cartidge.Equals("60929S") || cartidge.Equals("6002") || cartidge.Equals("60928") || cartidge.Equals("51P71") || cartidge.Equals("52P71") || cartidge.Equals("53P71") || cartidge.Equals("60921i"))
            {
                product = "//div[@class='productItemMedia-content-bd']";
                return product;
            }
            else if (cartidge.Equals("FR-57"))
            {
                product = "//div[contains(text(),'High Efficiency Cartridge FR-57/453-03-02R06,')]";
                return product;
            }
            if (cartidge.Equals("6001i"))
            {
                product = "//div[contains(text(),'3M™ Organic Vapor Service Life Indicator Cartridge')]";
                return product;
            }
            else if (cartidge.Equals("07046"))
            {
                product = "//div[contains(text(),'Organic Vapor Cartridge 07046 60 EA/Case')]";
                return product;
            }
            else if (cartidge.Equals("07047"))
            {
                product = "//div[@class='productItemMedia-content-hd'][contains(text(),'07047')]";
                return product;
            }
            else if (cartidge.Equals("D8001")|| cartidge.Equals("D8003") || cartidge.Equals("D8006") || cartidge.Equals("D80921") || cartidge.Equals("D80923") || cartidge.Equals("6007") || cartidge.Equals("60927"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            else if (cartidge.Equals("D80926"))
            {
                product = "//div[@class='productItemMedia-content']";
                return product;
            }
            else if (cartidge.Equals("TR-6510N"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            else if (cartidge.Equals("TR-6360N"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            else if (cartidge.Equals("TR-6320N"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            else if (cartidge.Equals("TR-6530N"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            else if (cartidge.Equals("TR-6590N"))
            {
                product = "//div[@class='productItemMedia-content-hd']";
                return product;
            }
            return product;
        }
        /// <summary>
        /// Click on Select and Continue to proceed further
        /// </summary>
        public static void SelectAndContinue(string cartidge)
        {
            Non_Mixture_ValidationSteps._logger.Info("Waiting for Select and Continue button to be clickable for the question Description:NIOSH approved against certain organic vapors.Use with 3M(TM) Half and Full Facepieces 6000, 7000 and FF - 400 Series with bayonet filter holders");
            XplicitWait.WaitForAnElement(XpathContainer.sel_Con);
            Pause.WaitingForSomeTime();
            Non_Mixture_ValidationSteps._logger.Info("Clicking on the Select and Continue button to proceed further");
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.sel_Con)).Click();
            if (cartidge.Equals("6001i") || cartidge.Equals("60921i"))
            {
                XplicitWait.WaitForAnElement(XpathContainer.okBtn);
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.okBtn)).Click();
            }
            else
            {
                Console.WriteLine("Test");
            }
        }
        /// <summary>
        /// Enter the details such as humidity, pressure , temperature , temperature unit and work rate in the environment detail page.
        /// </summary>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        /// <param name="temp"></param>
        /// <param name="tempunit"></param>
        /// <param name="workrate"></param>
        public static void EnvironmentDetails(string humidity, string pressure, int temp, string tempunit, string workrate)
        {
            Non_Mixture_ValidationSteps._logger.Info("Trying to set up the enviroment details as " +" "+ humidity +" "+ pressure +" "+ temp +" "+ tempunit +" "+ workrate);
            humidityfunc(humidity);
            Non_Mixture_ValidationSteps._logger.Info("Clearing the previous Atmospheric value");
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.atmPressure)).Clear();
            Non_Mixture_ValidationSteps._logger.Info("Setting up the atmospheric value as " + pressure);
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.atmPressure)).SendKeys(pressure);
            TemperatureUnit(tempunit, temp);
            WorkRate(workrate);
        }
        /// <summary>
        /// verify the details and click on next button 
        /// </summary>
        public static void Verify()
        {
            XplicitWait.WaitForAnElement(XpathContainer.nextFinal);
            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.nextFinal)).Click();
        }
        public static void VerifyHours(string workrate)
        {
            Non_Mixture_ValidationSteps._logger.Info("Checking if actuals hours matches " + workrate);
            string ActualHours = BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.hoursStringVerify)).Text;
            Assert.AreEqual(workrate,ActualHours);
        }
        public static void TemperatureUnit(string tempunit, int temp)
        {
            Console.WriteLine(tempunit);
            if (tempunit.Equals("Celsius"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature unit as " + tempunit);
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.celciusSelect)).Click();
                temperature(temp);
            }
            else
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the temperature unit as Farenheit");
                BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.fahrenheitSelect)).Click();
            }
        }
        public static void humidityfunc(string humidity)
        {
            Console.WriteLine("The humidity is: " + humidity);
            var exposureUnit = BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.humidityDrpDwn));
            //create select element object 
            var selectElement = new SelectElement(exposureUnit);
            //Pause.WaitingForSomeTime();
            if (humidity.Equals("<65%"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the humidity as " + humidity);
                selectElement.SelectByText("<65%");
            }
            else if (humidity.Equals("65"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the humidity as " + humidity);
                selectElement.SelectByText("65%");
            }
            else if (humidity.Equals("85"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the humidity as " + humidity);
                selectElement.SelectByText("85%");
            }
            else if (humidity.Equals("75"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the humidity as " + humidity);
                selectElement.SelectByText("75%");
            }
            else if (humidity.Equals("90"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the humidity as " + humidity);
                selectElement.SelectByText("90%");
            }
            //Pause.WaitingForSomeTime();
        }
        public static void WorkRate(string workrate)
        {
            var wrkrate = BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.wrkRate));
            //create select element object 
            var selectElement = new SelectElement(wrkrate);
            if (workrate.Equals("Heavy"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as Heavy");
                selectElement.SelectByText("Heavy");
            }
            else if (workrate.Equals("Medium"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as Medium");
                selectElement.SelectByText("Medium");
            }
            else if (workrate.Equals("Light"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as Light");
                selectElement.SelectByText("Light");
            }
            else if (workrate.Equals("PAPR Loose"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Loose");
                selectElement.SelectByText("PAPR Loose Fitting");
            }
            else if (workrate.Equals("PAPR Tight"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Tight");
                selectElement.SelectByText("PAPR Tight Fitting");
            }
            else if (workrate.Equals("Loose fitting - standard airflow"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Loose Fitting - Standard Airflow");
                selectElement.SelectByText("PAPR Loose Fitting - Standard Airflow");
            }
            else if (workrate.Equals("Loose fitting - medium airflow"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Loose Fitting - Medium Airflow");
                selectElement.SelectByText("PAPR Loose Fitting - Medium Airflow");
            }
            else if (workrate.Equals("Loose fitting - high airflow"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Loose Fitting - High Airflow");
                selectElement.SelectByText("PAPR Loose Fitting - High Airflow");
            }
            else if (workrate.Equals("Tight fitting - standard airflow"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Tight Fitting - Standard Airflow");
                selectElement.SelectByText("PAPR Tight Fitting - Standard Airflow");
            }
            else if (workrate.Equals("Tight fitting - medium airflow"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Tight Fitting - Medium Airflow");
                selectElement.SelectByText("PAPR Tight Fitting - Medium Airflow");
            }
            else if (workrate.Equals("Tight fitting - high airflow"))
            {
                Non_Mixture_ValidationSteps._logger.Info("Setting up the work rate as PAPR Tight Fitting - High Airflow");
                selectElement.SelectByText("PAPR Tight Fitting - High Airflow");
            }
        }
    }
}
