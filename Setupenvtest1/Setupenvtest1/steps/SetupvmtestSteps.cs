using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Setupenvtest1.steps
{
    [Binding]
    public class SetupvmtestSteps
    {
        private IWebDriver driver;


        public SetupvmtestSteps(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"Open safeguard webapplication in the browser")]
        public void GivenOpenSafeguardWebapplicationInTheBrowser()
        {
            driver.Navigate().GoToUrl("https://download-qa.3m.com");
            System.Threading.Thread.Sleep(2000);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter the userid and password in the text box")]
        public void GivenEnterTheUseridAndPasswordInTheTextBox()
        {
            driver.FindElement(By.XPath("//input[@id='logonIdentifier']")).SendKeys("pawan.sharma@nathcorp.com");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Pawan123@");
            Thread.Sleep(5000);
            // ScenarioContext.Current.Pending();
        }
        
        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.XPath("//button[normalize-space()='Sign in']")).Click();
            Thread.Sleep(5000);
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"close the browser after login")]
        public void ThenCloseTheBrowserAfterLogin()
        {
            driver.Close();
           // ScenarioContext.Current.Pending();
        }
    }
}
