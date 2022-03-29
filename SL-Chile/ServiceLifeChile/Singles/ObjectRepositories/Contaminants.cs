using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class Contaminants
    {
        IWebDriver driver;
        public Contaminants(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        By casBox = By.CssSelector("input#search");
        By selectContaminant = By.CssSelector("div[class='inputBox inputBox_noLabel']");
        By contNext = By.CssSelector("button[class='btn btn_primary']");
        By setExposure = By.CssSelector("input[name='exposureValue']");
        By setExposureUnit = By.CssSelector("select[name='exposureUnit']");
        public IWebElement searchContaminantUsingCAS()
        {
            return driver.FindElement(casBox);
        }
        public void selectTheContiminant()
        {
            driver.FindElement(selectContaminant).Click();
        }
        public void clickNextAndContinue()
        {
            driver.FindElement(contNext).Click();
        }
        public IWebElement setExposureValue()
        {
            return driver.FindElement(setExposure);
        }
        public IWebElement provideExposureUnit()
        {
            return driver.FindElement(setExposureUnit);
        }
    }
}
