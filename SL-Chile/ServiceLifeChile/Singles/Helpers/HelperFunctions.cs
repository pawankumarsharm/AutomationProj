using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ServiceLifeChile.StepsDefinations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.Helpers
{
    class HelperFunctions
    {
        private static string baseURL = ConfigurationManager.AppSettings.Get("url");
        private static string browser = ConfigurationManager.AppSettings.Get("browsers");
        public static string _fileName = "";
        By expUnit = By.CssSelector("select[name='exposureUnit']");
        By tmpUnitCel = By.XPath("//label[@class='radioButtons-button-label' and text()='Celsius']");
        By tmpUnitFar = By.XPath("//label[@class='radioButtons-button-label' and text()='Fahrenheit']");

        public void SetExposureUnit(string exposure, IWebDriver _driver)
        {
            IWebElement _expUnitEle = _driver.FindElement(expUnit);
            SelectElement _ele = new SelectElement(_expUnitEle);
            if ((exposure.ToLower()).Equals("ppm"))
            {
                _ele.SelectByValue("ppm");
            }
            else if ((exposure).Equals("mg/m3 "))
            {
                _ele.SelectByValue("mg/m3");
            }
        }
        public void setRelativeHumidity(IWebElement ele, string humidity)
        {
            SelectElement _ele = new SelectElement(ele);
            if ((humidity.ToLower()).Equals("<65%"))
            {
                _ele.SelectByText("<65%");
            }
            else if ((humidity.ToLower()).Equals("65%") || (humidity.ToLower()).Equals("65"))
            {
                _ele.SelectByText("65%");
            }
            else if ((humidity.ToLower()).Equals("75%") || (humidity.ToLower()).Equals("75"))
            {
                _ele.SelectByText("75%");
            }
            else if ((humidity.ToLower()).Equals("85%") || (humidity.ToLower()).Equals("85"))
            {
                _ele.SelectByText("85%");
            }
            else if ((humidity.ToLower()).Equals("90%") || (humidity.ToLower()).Equals("90"))
            {
                _ele.SelectByText("90%");
            }
        }
        public void setTemperature(IWebElement ele, string temperature)
        {

            SelectElement _ele = new SelectElement(ele);
            if ((temperature.ToLower()).Equals("10"))
            {
                _ele.SelectByText("10");
            }
            else if ((temperature.ToLower()).Equals("20"))
            {
                _ele.SelectByText("20");
            }
            else if ((temperature.ToLower()).Equals("30"))
            {
                _ele.SelectByText("30");
            }
            else if ((temperature.ToLower()).Equals("40"))
            {
                _ele.SelectByText("40");
            }
            else if ((temperature.ToLower()).Equals("50"))
            {
                _ele.SelectByText("50");
            }
            else if ((temperature.ToLower()).Equals("32"))
            {
                _ele.SelectByText("32");
            }
            else if ((temperature.ToLower()).Equals("68"))
            {
                _ele.SelectByText("68");
            }
            else if ((temperature.ToLower()).Equals("86"))
            {
                _ele.SelectByText("86");
            }
            else if ((temperature.ToLower()).Equals("104"))
            {
                _ele.SelectByText("104");
            }
            else if ((temperature.ToLower()).Equals("122"))
            {
                _ele.SelectByText("122");
            }
        }

        internal static void TakingScreenshot(string stepinfo)
        {
            var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
            if (takesScreenshot != null)
            {
                var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(path + "\\Screenshots");
                var screenshot = takesScreenshot.GetScreenshot();
                var tempFileName = Path.Combine(path + "\\Screenshots", Path.GetFileNameWithoutExtension(stepinfo)) + ".jpg";
                int _fileSize = tempFileName.Length;
                if (_fileSize > 248 || tempFileName.Contains("Supplied air respirators may be appropriate to help reduce exposure depending on the protection factor of the respirator chosen."))
                {
                    _fileName = tempFileName.Replace(",3M does not have an appropriate filter for one or more of your contaminants. Supplied air respirators may be appropriate to help reduce exposure depending on the protection factor of the respirator chosen. Please see the supplied air respirators below or contact 3M at 1-800-243-4630 for more information", "");
                }
                else
                {
                    _fileName = tempFileName;
                }
                screenshot.SaveAsFile(_fileName, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
                Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");
            }
        }
        public void setWorkRate(IWebElement ele, string workrate)
        {
            SelectElement _ele = new SelectElement(ele);
            if ((workrate.ToLower()).Equals("heavy"))
            {
                _ele.SelectByText("Pesado");
            }
            if ((workrate.ToLower()).Equals("medium"))
            {
                _ele.SelectByText("Mediano");
            }
            if ((workrate.ToLower()).Equals("light"))
            {
                _ele.SelectByText("Ligero");
            }
            //if ((workrate.ToLower()).Equals("papr loose medium") || (workrate.ToLower()).Equals("papr loose - medium"))
            //{
            //    _ele.SelectByText("PAPR Loose Fitting - Medium Airflow");
            //}
            if ((workrate.ToLower()).Equals("tight fitting-standard airflow") || (workrate.ToLower()).Equals("tight fitting - standard airflow"))
            {
                _ele.SelectByText("Ajuste ajustado - flujo de aire estándar");//("PAPR Ajuste ajustado - flujo de aire estándar"); 
            }
            if ((workrate.ToLower()).Equals("tight fitting-medium airflow") || (workrate.ToLower()).Equals("tight fitting - medium airflow"))
            {
                _ele.SelectByText("Ajuste ajustado - flujo de aire medio");//("PAPR Ajuste ajustado - flujo de aire medio"); 
            }
            if ((workrate.ToLower()).Equals("tight fitting-high airflow") || (workrate.ToLower()).Equals("tight fitting - high airflow"))
            {
                _ele.SelectByText("Ajuste ajustado - alto flujo de aire");//("PAPR Ajuste ajustado - alto flujo de aire"); //Ajuste ajustado - flujo de aire estándar
            }
            if ((workrate.ToLower()).Equals("loose fitting-standard airflow") || (workrate.ToLower()).Equals("loose fitting - standard airflow"))
            {
                _ele.SelectByText("Ajuste holdado - flujo estandar de aire");//("PAPR Loose Fitting - Standard Airflow"); 
            }
            if ((workrate.ToLower()).Equals("loose fitting-high airflow") || (workrate.ToLower()).Equals("loose fitting - high airflow"))
            {
                _ele.SelectByText("Ajuste holdado - alto flujo de aire");//("PAPR Loose Fitting - High Airflow"); 
            }
            if ((workrate.ToLower()).Equals("loose fitting-medium airflow") || (workrate.ToLower()).Equals("loose fitting - medium airflow"))
            {
                _ele.SelectByText("Ajuste holdado - flujo medio de aire");//("PAPR Loose Fitting - Medium Airflow"); 
            }
        }
        public static void NavigateToSLS()
        {
            BrowserConfig.NavigateToSLS();
            ValidatingServiceLifeHoursSteps.Logger.Info("Sucessfully navigated to the url " + baseURL);
        }
    }
}
