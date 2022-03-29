using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using select_service_us_canada.mixture_acids_validation.Configurations;
using select_service_us_canada.mixture_acids_validation.excel;
using select_service_us_canada.mixture_acids_validation.StepDefinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace select_service_us_canada.mixture_acids_validation.Utilities
{
    class MixtureUtility
    {
        public static void NavigateTillCOV()
        {
            BrowserConfig.NavigateToSLS();
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.espain)).Click();
            Pause.WaitForSomeTime();
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.region)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.next);
            //Click on next to proceed further
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.chkbox);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.chkbox)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.next);
            //Accept to proceed further
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.CASBox);
        }
        public static void NavigateFromHome(string region_selector)
        {
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.espain)).Click();
            Pause.WaitForSomeTime();
            if(region_selector=="Canada")
            {
                MixtureAcidValidationsSteps._logger.Info("Clicking on the region selector element " + XpathContainer.region_canada);
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.region_canada)).Click();
            }
            else
            {
                MixtureAcidValidationsSteps._logger.Info("Clicking on the region selector element " + XpathContainer.region);
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.region)).Click();
            }
            ExplicitWait.WaitForAnElement(XpathContainer.next);
            //Click on next to proceed further
            MixtureAcidValidationsSteps._logger.Info("Clicking on next button after selecting region as " + region_selector);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.chkbox);
            MixtureAcidValidationsSteps._logger.Info("Clicking on Service Life ElSI selector check box");
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.chkbox)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.next);
            MixtureAcidValidationsSteps._logger.Info("Clicking on next IAccept button after selecting Service Life ElSI selector check box");
            //Accept to proceed further
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.CASBox);
        }
        public static void SelectToulene()
        {
            string TolueneByCas = ReadMixtureData.getdata(3, 22);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(TolueneByCas);
            //Select the Filtered Toulene product
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectMeth()
        {
            //CAS value of MEK from Excel
            string MEK = ReadMixtureData.getdata(3, 9);//coloum * row
                                                       //Filter Meth using cas value
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(MEK);

            //Select the Filtered Meth element
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();

        }


        public static void XyleneSelect()
        {
            string Xylene = ReadMixtureData.getdata(3, 37);//coloum * row
                                                           //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(Xylene);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectAcetonitrile()
        {
            string acetonitrile = ReadMixtureData.getdata(3, 2);//coloum * row
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(acetonitrile);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectFormamide()
        {
            string formamide = ReadMixtureData.getdata(3, 3);//coloum * row
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(formamide);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectMethyleneChloride()
        {
            string methyleneChloride = ReadMixtureData.getdata(3, 35);//coloum * row
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(methyleneChloride);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectHexane()
        {
            string hexane = ReadMixtureData.getdata(3, 4);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(hexane);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectStyrene()
        {
            string hexane = ReadMixtureData.getdata(3, 5);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(hexane);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectHF()
        {
            string hf = ReadMixtureData.getdata(3, 6);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(hf);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectSO2()
        {
            string sO2 = ReadMixtureData.getdata(3, 67);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(sO2);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectAmmonia()
        {
            string ammonia = ReadMixtureData.getdata(3, 8);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(ammonia);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectMethylamine()
        {
            string methylamine = ReadMixtureData.getdata(3, 13);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(methylamine);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectH2S()
        {
            string h2S = ReadMixtureData.getdata(3, 16);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(h2S);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void SelectAcetone()
        {
            string acetone = ReadMixtureData.getdata(3, 18);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(acetone);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void MethyleneChloride()
        {
            string methyleneChloride = ReadMixtureData.getdata(3, 33);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(methyleneChloride);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void Formamide()
        {
            string formamide = ReadMixtureData.getdata(3, 34);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(formamide);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void MEK()
        {
            string mEK = ReadMixtureData.getdata(3, 33);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(mEK);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void Xylene()
        {
            string xylene = ReadMixtureData.getdata(3, 59);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(xylene);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void AceticAcidButylEster()
        {
            string aceticAcidButylEster = ReadMixtureData.getdata(3, 57);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(aceticAcidButylEster);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
        public static void HS()
        {
            string HS = ReadMixtureData.getdata(3, 66);
            //Filter using CAS value of Xylene
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)).SendKeys(HS);
            ExplicitWait.WaitForAnElement(XpathContainer.contaminant);
            //Select the Filtered Xylene product
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.contaminant)).Click();
        }
   
        public static void SetExposure(string _exposureValue, string _exposureUnit)
        {
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer._masterExposureValue)).SendKeys(_exposureValue);
            var _selectElement = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer._masterExposureUnit));
            SelectElement element = new SelectElement(_selectElement);
            if (_exposureUnit.Equals("ppm"))
            {
                element.SelectByValue("ppm");
            }
            else
            {
                element.SelectByValue("mg/m3");
                Thread.Sleep(3000);
            }
        }
 
        public static void CartidgeFilter(string cartidge)
        {
            Pause.Waiting();

            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.casbox)).SendKeys(cartidge);            
            ExplicitWait.WaitForAnElement(XpathContainer._masterContaminant);
            ClickAndReturn(cartidge, XpathContainer._masterContaminant);

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
    }
}
