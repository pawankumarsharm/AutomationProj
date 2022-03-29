using OpenQA.Selenium;
using Safeguard.Xpath;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Safeguard.Steps
{
    [Binding]
    public class SafeguardStepscheckDropdown
    {
        private IWebDriver driver;


        public SafeguardStepscheckDropdown(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open safeguard web application in the browser")]
        public void GivenOpenSafeguardWebApplicationInTheBrowser()
        {
            driver.Navigate().GoToUrl("https://safeguardqa.azurewebsites.net/Guest#/Validation");
            System.Threading.Thread.Sleep(2000);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Select the available product from dropdown")]
        public void GivenSelectTheAvailableProductFromDropdown()
        {
            driver.FindElement(By.XPath(xpath.selectproduct)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.selectproduct1)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.selectproduct2)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.modelname)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(xpath.modelname2)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(xpath.modelname3)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(xpath.modelname4)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(xpath.selectproduct3)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.modelname1)).Click();
            Thread.Sleep(4000);
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Close();
            //ScenarioContext.Current.Pending();
        }
    }
}
