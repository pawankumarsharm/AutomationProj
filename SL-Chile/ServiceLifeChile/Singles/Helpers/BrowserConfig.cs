using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using ServiceLifeChile.StepsDefinations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.Helpers
{
    public class BrowserConfig
    {
        public static IWebDriver webDriver;
        // private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string baseURL = ConfigurationManager.AppSettings.Get("url");
        private static string browser = ConfigurationManager.AppSettings.Get("browser");
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
            }
            webDriver.Manage().Window.Maximize();

        }
        public static void NavigateToSLS()
        {
            ValidatingServiceLifeHoursSteps.Logger.Info("Redirecting to the url " + baseURL);
            Goto(baseURL);
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
            //Accept cookies
            //if (webDriver.FindElement(By.XPath(XpathContainer._aCookiesVisible)).Displayed)
            //{
            //    webDriver.FindElement(By.Id(XpathContainer._acceptCookies)).Click();
            //}
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
