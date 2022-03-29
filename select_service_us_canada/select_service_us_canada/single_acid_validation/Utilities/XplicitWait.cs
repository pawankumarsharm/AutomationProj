using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using select_service_us_canada.single_acid_validation.Configurations;
using select_service_us_canada.single_acid_validation.StepDefinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace select_service_us_canada.single_acid_validation.Utilities
{
    class XplicitWait
    {
        public static void WaitForAnElement(string value)
        {
            try
            {
                var wait = new WebDriverWait(BrowserAndUrlConfig.webDriver, new TimeSpan(0, 0, 15));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
            }
            catch(Exception ex)
            {
                Non_Mixture_ValidationSteps._logger.Error(ex);
                Exception custmExcep = new Exception("The required element/object " + value + "not found");
                throw custmExcep;
            }
        }
        public static void Wait()
        {
            Thread.Sleep(2000);
        }
    }
}
