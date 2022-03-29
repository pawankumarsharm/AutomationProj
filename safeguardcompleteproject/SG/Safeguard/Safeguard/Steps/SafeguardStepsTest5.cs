using OpenQA.Selenium;
using Safeguard.Xpath;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Safeguard.Steps
{
    [Binding]
    public class SafeguardStepsTest5
    {
        private IWebDriver driver;


        public SafeguardStepsTest5(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Open safeguard webapplication in the browserr")]
        public void GivenOpenSafeguardWebapplicationInTheBrowserr()
        {
            driver.Navigate().GoToUrl("https://safeguardqa.azurewebsites.net/Guest#/Validation");
            System.Threading.Thread.Sleep(2000);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter the (.*) and (.*) in the text box")]
        public void GivenEnterTheAndInTheTextBox(string securecod, string lotcode)
        {
            driver.FindElement(By.XPath(xpath.securecode)).SendKeys(securecod);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.lotcode)).SendKeys(lotcode);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.checkbox)).Click();
            Thread.Sleep(5000);
        }
        
        [When(@"click on check validation to validate the product")]
        public void WhenClickOnCheckValidationToValidateTheProduct()
        {
            driver.FindElement(By.XPath(xpath.checkvalidate)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.confirm)).Click();
            Thread.Sleep(5000);
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"close the browser after validation")]
        public void ThenCloseTheBrowserAfterValidation()
        {
            driver.Close();
            // ScenarioContext.Current.Pending();
        }
    }
}
