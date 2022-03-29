using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Setupenvtest1
{
    public class Tests
    {
        //Hooks in nuint
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://download-qa.3m.com/");
            //driver.Title();
            //identify login
            //IWebElement lnkLogin = driver.FindElement(By.LinkText("Login"));
            IWebElement lnkLogin = driver.FindElement(By.XPath("//li[contains(@class,'MMM--utilityLinks MMM--isOnDesktop MMM--desktopUtilLinks')]//button[contains(@type,'button')][normalize-space()='Login']"));
            //operation
            lnkLogin.Click();

        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
        }
    }
}