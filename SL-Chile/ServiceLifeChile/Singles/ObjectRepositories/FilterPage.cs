using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class FilterPage
    {
        IWebDriver driver;

        By searchBox = By.CssSelector("input#Search");
        By cartidgesToFilter = By.CssSelector("div[class='productItemMedia-content-hd']");
        By selectButton = By.XPath("//button[text()='Seleccionar y Continuar']");
        By ElsiOK = By.XPath("//button[contains(text(),'Ok')]");
        public FilterPage(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        public IWebElement searchCartidges()
        {
            return driver.FindElement(searchBox);
        }
        public IWebElement ELSIOK()
        {
            return driver.FindElement(ElsiOK);
        }
        public void selectCartidges(string cartidgesValue)
        {
            IList<IWebElement> carEle = driver.FindElements(cartidgesToFilter);
            foreach (IWebElement items in carEle)
            {
                if (items.Text.Equals(cartidgesValue))
                {
                    Thread.Sleep(500);
                    items.Click();
                    break;
                }
            }
        }
        public IWebElement selectAndContinue()
        {
            return driver.FindElement(selectButton);
        }
    }
}
