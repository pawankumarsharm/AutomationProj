using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class Review
    {
        IWebDriver driver;
        By wrkRate = By.CssSelector("div[class='serviceLife-bd']");
        By donBtn = By.XPath("//button[@class='btn btn_primary' and text()='Finalizar']");
        public Review(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        public string WorkRate()
        {
            return driver.FindElement(wrkRate).Text;
        }
        public IWebElement Done()
        {
            return driver.FindElement(donBtn);
        }
    }
}
