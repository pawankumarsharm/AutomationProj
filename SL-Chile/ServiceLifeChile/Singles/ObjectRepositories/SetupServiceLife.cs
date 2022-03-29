using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class SetupServiceLife
    {
        IWebDriver driver;
        public SetupServiceLife(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        By chkBoxServiceLife = By.CssSelector("input#serviceLifeType");
        By btnIAccept = By.XPath("//button[text()='Estoy de acuerdo']");
        public void selectServiceLife()
        {
            bool _isSelected = driver.FindElement(chkBoxServiceLife).Selected;
            if (_isSelected)
            {
                Console.WriteLine("Service life is already selected.");
            }
            else
            {
                driver.FindElement(chkBoxServiceLife).Click();
            }
        }
        public void acceptAndContinue()
        {
            driver.FindElement(btnIAccept).Click();
        }
    }
}
