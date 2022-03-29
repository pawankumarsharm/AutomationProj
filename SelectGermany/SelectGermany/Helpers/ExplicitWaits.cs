using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SelectGermany.BrowsersConfigs;
using SelectGermany.StepsDefination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectGermany.Helpers
{
    class ExplicitWaits
    {
        public static void WaitForAnElement(string value)
        {
            try
            {
                GermanySelectSteps.Logger.Info("Waiting for element " + value);
                var wait = new WebDriverWait(BrowserConfigs.webDriver, new TimeSpan(0, 0, 24));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
            }
            catch (Exception ex)
            {
                //string err = "{'unexpected alert open: { Alert text : Internal Server Error Object reference not set to an instance of an object.}\n(Session info: chrome = 87.0.4280.88)'}";
                string _err = ex.ToString();
                if (_err.Contains("unexpected alert") || _err.Contains("Object reference"))
                {
                    throw ex;
                }
                else
                {
                    Exception excustom = new Exception("The expected element " + value + " not found or no contaminates may be present in the webapplication.");
                    throw excustom;
                }
            }
        }
    }
}
