using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace Safeguard.Feature
{
    [Binding]
    public class SafeguardSteps3
    {
        private IWebDriver driver;

        public SafeguardSteps3(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"check the header and footer of safeguard website")]
        public void GivenCheckTheHeaderAndFooterOfSafeguardWebsite()
        {
            driver.Url = "https://safeguardqa.azurewebsites.net/Guest#/Validation";

            Thread.Sleep(4000);
          //checking for headers element
            driver.FindElement(By.XPath("//*[@id=\"js-gsnList\"]/a[1]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id=\"js-gsnList\"]/a[2]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id=\"js-gsnList\"]/a[3]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id=\"js-siteHd\"]/div[1]/a/img[1]")).Click();
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//*[@id=\"footer\"]/div/div[3]/div[1]/div/div[1]/a/img")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//*[@id=\"footer\"]/div/div[3]/div[1]/div/div[2]/div/a[1]")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//*[@id=\"footer\"]/div/div[3]/div[1]/div/div[2]/div/a[2]")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[contains(text(),'© 2021 3M. All Rights Reserved.')]")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//div[@class='MMM--hdg MMM--hdg_4 mix-MMM--hdg_spaced']")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//a[@title='Twitter']")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//a[@title='LinkedIn']")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//a[@title='YouTube']")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//a[@title='Facebook']")).Click();
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//a[@title='Instagram']")).Click();
            //Thread.Sleep(4000);

            // //checking for footers element



            driver.Close();

           
        }
    }
}
