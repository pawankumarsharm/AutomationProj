
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Safeguard.Xpath;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Safeguard.Steps
{
    [Binding]
    public class SafeguardStepschnglng
    {
        private IWebDriver driver;


        public SafeguardStepschnglng(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"open the safeguard webapplication")]
        public void GivenOpenTheSafeguardWebapplication()
        {
            driver.Navigate().GoToUrl("https://safeguardqa.azurewebsites.net/Guest#/Validation");
            System.Threading.Thread.Sleep(2000);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"slect the language from change language dropdown")]
        public void GivenSlectTheLanguageFromChangeLanguageDropdown()
        { 


            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//h5[normalize-space()='Change Language']")).Click();
            Thread.Sleep(5000);
           // driver.FindElement(By.XPath("//a[normalize-space()='Chinese (China)']")).Click();
            //Thread.Sleep(5000);
           // driver.FindElement(By.XPath("//h5[normalize-space()='Change Language']")).Click();
           // Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//a[normalize-space()='English (United States)']")).Click();
            //Thread.Sleep(10000);
            driver.FindElement(By.XPath("//a[normalize-space()='French (Canada)']")).Click();
            Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//a[normalize-space()='Japanese']")).Click();
            //Thread.Sleep(10000);
            //driver.FindElement(By.XPath("//a[normalize-space()='Portuguese (Brazil)']")).Click();
            //Thread.Sleep(10000);
            //driver.FindElement(By.XPath("//a[normalize-space()='Spanish (Latin America)']")).Click();
            //Thread.Sleep(10000);

            //Actions actions = new Actions(driver);
            //IWebElement test = driver.FindElement(By.XPath("//li[@class=\'dropdown dropdown-language\']"));
            //actions.MoveToElement(test).Perform();
            //Console.WriteLine("Done Mouse hover on 'ChangeLanguage' from Menu");
            //IWebElement selectMenuOption = driver.FindElement(By.XPath("//li[@id=\"ja-JP\"]"));
            //selectMenuOption.Click();
            //Console.WriteLine("Selected 'Japanese' from Menu");
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath(xpath.changelang2)).Click();
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath(xpath.changelang3)).Click();
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath(xpath.changelang4)).Click();
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath(xpath.changelang5)).Click();
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath(xpath.changelang6)).Click();
            //Thread.Sleep(5000);
            driver.Close();
            //ScenarioContext.Current.Pending();
        }
    }
}
