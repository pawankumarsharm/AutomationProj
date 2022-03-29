using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Configurations
{
    class BrowserConfig
    {
        public static IWebDriver webDriver;
        // private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static readonly string baseURL = ConfigurationManager.AppSettings.Get("url");
        private static readonly string browser = ConfigurationManager.AppSettings.Get("browser");
        public static void Init()
        {
            if (webDriver != null)
            {
                Goto(baseURL);
            }
            else
            {
                switch (browser)
                {
                    case "Chrome":
                        webDriver = new ChromeDriver();
                        break;
                    case "IE":
                        webDriver = new InternetExplorerDriver();
                        break;
                    case "Firefox":
                        webDriver = new FirefoxDriver();
                        break;
                }
                webDriver.Manage().Window.Maximize();
                NavigateToSLS();

            }
        }
        public static void NavigateToSLS()
        {
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
        }
        public static void Close()
        {
            webDriver.Dispose();
            webDriver.Quit();
        }
    }
}
