using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class Environment
    {
        IWebDriver driver;
        By relHumidity = By.CssSelector("select#relative-humidity");
        By temperature = By.CssSelector("select#temperature");
        By workRate = By.CssSelector("select#work-rate");
        By atmPressure = By.CssSelector("input#atmospheric-pressure");
        By tmpUnitCel = By.XPath("//label[@class='radioButtons-button-label' and text()='Celsius']");
        By tmpUnitFar = By.XPath("//label[@class='radioButtons-button-label' and text()='Fahrenheit']");
        public Environment(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public IWebElement relativeHumidity()
        {
            return driver.FindElement(relHumidity);
        }
        public IWebElement setTemperature()
        {
            return driver.FindElement(temperature);
        }
        public IWebElement WorkRate()
        {
            return driver.FindElement(workRate);
        }
        public IWebElement setPressure()
        {
            return driver.FindElement(atmPressure);
        }
        public void SetTempUnit(string tmpUnit)
        {
            if (tmpUnit.Equals("Celsius"))
            {
                driver.FindElement(tmpUnitCel).Click();
            }
            else if (tmpUnit.Equals("Fahrenheit"))
            {
                driver.FindElement(tmpUnitFar).Click();
            }
        }
    }
}
