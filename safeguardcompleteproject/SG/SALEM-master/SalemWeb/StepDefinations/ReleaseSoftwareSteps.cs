using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalemWeb.StepDefinations
{
    [Binding]
    class ReleaseSoftwareSteps
    {
       
          
       
        [Then(@"Click on Release Software Button")]
        public void ThenClickOnReleaseSoftwareButton()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._releaseSoftwareBtn)).Click();
        }
        [Then(@"Select product, version, License expiry date and max activations per day from dropdownmenu")]
        public void ThenSelectProductVersionLicenseExpiryDateAndMaxActivationsPerDayFromDropdownmenu()
        {
            Function.productSelect();
           Function.versionSelect();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._LicenseExpiryDate)).Click();
   
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchboxDate)).SendKeys(Keys.Return);
          
            Function.maxActivationSelect();
            IJavaScriptExecutor jd = (IJavaScriptExecutor)BrowserConfig._driver;
            jd.ExecuteScript("window.scrollBy(0,250)", "");
        }
        [Then(@"Click on release button\.")]
        public void ThenClickOnReleaseButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._relaseBtn)).Click();
        }
        [Then(@"Select product from dropdownmenu\.")]
        public void ThenSelectProductFromDropdownmenu_()
        {
            Function.productSelect();
        }
        [Then(@"select version from dropdownmenu\.")]
        public void ThenSelectVersionFromDropdownmenu_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._version);
            Function.productSelect();
            Function.versionSelect();
        }

        [Then(@"select License expiry date\.")]
        public void ThenSelectLicenseExpiryDate_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._LicenseExpiryDate);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchboxDate)).SendKeys(Keys.Return);
        }
        [Then(@"select maxactivationper day\.")]
        public void ThenSelectMaxactivationperDay_()
        {
            Function.maxActivationSelect();
        }
        [Then(@"verify frelease of software\.")]
        public void ThenVerifyFreleaseOfSoftware_()
        {
            bool _releaseMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._releaseSoftwareSucessMsg)).Displayed;
            if (!_releaseMsg)
            {
                Assert.Fail("sofftware not released.");
            }
        }


    }
}
        