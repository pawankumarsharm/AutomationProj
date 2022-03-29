using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SelectCartridgeChile.Helpers;
using SelectCartridgeChile.StepsDefination;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelectCartridgeChile.BrowsersConfigs
{
    class BrowserConfigs:Containers
    {
        public static IWebDriver webDriver;
        // private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static readonly string baseURL = ConfigurationManager.AppSettings.Get("url");
        private static readonly string browser = ConfigurationManager.AppSettings.Get("browsers");
        /// <summary>
        /// Function to Initiate the Browser and launch it.
        /// </summary>
        public static void Init()
        {
            if (webDriver != null)
            {
                //ChileSelectSteps.Logger.Info("Checking if the value of webdriver is null or not........The value is " + webDriver);

                Goto(baseURL);


            }
            else
            {

                switch (browser)
                {
                    case "Chrome":
                        ChileSelectSteps.Logger.Info("Checking for the available browsers in the configuration file........Chrome...OK");
                        webDriver = new ChromeDriver();
                        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
                        break;
                    case "IE":
                        ChileSelectSteps.Logger.Info("Checking for the available browsers in the configuration file........Internet Explorer...OK");
                        webDriver = new InternetExplorerDriver();
                        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                        break;
                    case "Firefox":
                        ChileSelectSteps.Logger.Info("Checking for the available browsers in the configuration file........FireFox...OK");
                        webDriver = new FirefoxDriver();
                        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                        break;


                }


                ChileSelectSteps.Logger.Info("Maximizing the browser instance");
                webDriver.Manage().Window.Maximize();
                Goto(baseURL);
            }
        }
        public static string Title
        {
            get { return webDriver.Title; }

        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        /// <summary>
        /// Function to Navigate to the SLS Dev Web Application.
        /// </summary>
        /// <param name="url"></param>
        public static void Goto(string url)
        {
            ChileSelectSteps.Logger.Info("Redirecting to the url..." + url);
            //Thread.Sleep(2000);
            webDriver.Url = url;
            // Accept the cookies
            //ExplicitWaits.WaitForAnElement(Containers._aCookiesVisible);
            try
            {
                if (webDriver.FindElement(By.XPath(Containers._aCookiesVisible)).Displayed)
                {
                    webDriver.FindElement(By.XPath(Containers._aCookiesVisible)).Click();
                    Thread.Sleep(2000);
                }
            }
            catch
            {
                Console.WriteLine("Accept not visible.");
            }

        }
        /// <summary>
        /// Function to Close the Browser Instance.
        /// </summary>
        public static void QuitBrowsersInstance()
        {
            webDriver.Quit();
            ChileSelectSteps.Logger.Info("Successfully closed the browser instance....");
        }
    }
}
