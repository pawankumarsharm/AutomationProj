using OpenQA.Selenium;
using PAPR.Pages;
using System;
using System.Threading;
using System.Xml.XPath;
using TechTalk.SpecFlow;

namespace PAPR.Steps
{
    [Binding]
    public class Filterbyattributes
    {
        private IWebDriver driver;
        private ScenarioContext context;

        public Filterbyattributes(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the PAPR website application")]
        public void GivenOpenThePAPRWebsiteApplication()
        {
            driver.Navigate().GoToUrl("https://compres-dev.mmm.com/");
            System.Threading.Thread.Sleep(7000);
        }
        
        [Given(@"Click on the signin button there")]
        public void GivenClickOnTheSigninButtonThere()
        {
            Thread.Sleep(6000);
        }
        
        [When(@"Enter the emailid(.*) and passwoord(.*)")]
        public void WhenEnterTheEmailidAndPasswoord(string emailid, string password)
        {
            driver.FindElement(By.XPath(xpath.emaild)).SendKeys(emailid);
            driver.FindElement(By.XPath(xpath.next)).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.password)).SendKeys(password);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.clicksignin)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.multifactorclick)).Click();
            Thread.Sleep(8000);
        }
        
        [Then(@"Provide the gnerted OTP and make login into application")]
        public void ThenProvideTheGnertedOTPAndMakeLoginIntoApplication()
        {
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(xpath.authenticate)).Click();
            driver.FindElement(By.XPath(xpath.yes)).Click();
            Thread.Sleep(9000);
        }
        
        [Then(@"Select any Respiratory category and verify filter by attributes\.")]
        public void ThenSelectAnyRespiratoryCategoryAndVerifyFilterByAttributes_()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.FindElement(By.XPath(xpath.selectpoweredair)).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.Finditbutton)).Click();
            Thread.Sleep(15000);
          driver.FindElement(By.XPath("//input[@id='attrid_6']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//input[@id='attrid_8']")).Click();
            Thread.Sleep(9000);

            XPathNavigator nav;
            XPathDocument docNav;
            String xPath;
            String xPath2;
            docNav = new XPathDocument("");
            nav = docNav.CreateNavigator();
            xPath = "//input[@id='attrid_6']";
            xPath2 = "//a[@value='attrid_6']";
            string var1 = nav.SelectSingleNode(xPath).Value;
            string var2 = nav.SelectSingleNode(xPath2).Value;
            string v2 = var2.Remove('X');

            string v= "//*[@id="v_filterby"]/span/a";
           
            if (xPath.Equals(xPath2))
            {
                Console.WriteLine("Data matched Successfully");

            }
            else
            {
                Console.WriteLine("Failed to match");
            }
            String vari = driver.FindElement(By.XPath("//input[@id='attrid_6']")).GetAttribute("alt");
            String vari1= driver.FindElement(By.XPath("//a[@value='attrid_6']")).GetAttribute("alt");
            if (vari.Equals(vari1))
            {
                Console.WriteLine("Data matched Successfully");

            }
            else
            {
                Console.WriteLine("Failed to match");
            }

            String var1 = "//input[@id='attrid_6']"; 
            String var2 = "//a[@value='attrid_6']";
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            if (var1.Equals(var2))
            {
                Console.WriteLine("Data matched Successfully");
               
            }
            else
            {
                Console.WriteLine("Failed to match");
            }
            //  driver.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div[3]/div[2]/div/div/div/div/div/div/span[1]/a")).Click();
            //driver.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div[3]/div[2]/div/div/div/div/div/div/span[2]/a")).Click();
            // / html / body / div[1] / main / div[2] / div[3] / div[2] / div / div / div / div / div / div / span[3] / a
            // if (//div[@id='v_filterByRow']//span[1]  )
            // js.ExecuteScript("window.scrollBy(0,400)");
            //Thread.Sleep(9000);

        }
    }
}
