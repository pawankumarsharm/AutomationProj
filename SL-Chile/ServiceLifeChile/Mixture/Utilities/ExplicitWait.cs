using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ServiceLife_Chile.mixture_acids_validation.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Utilities
{
    class ExplicitWait
    {
        public static void WaitForAnElement(string value)
        {
            try
            {
                var wait = new WebDriverWait(BrowserConfig.webDriver, new TimeSpan(0, 0, 15));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
            }
            catch(Exception ex)
            {
                Exception customExcep = new Exception("The element or object " + value +"not found");
                throw customExcep;
            }
        }
        public static void WaitForSomeTime(int value)
        {
            Thread.Sleep(value);
        }
    }
}
