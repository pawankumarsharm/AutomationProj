using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class Cartridge_Filter
    {
        IWebDriver driver;
        [FindsBy(How = How.CssSelector, Using = "div[class='productItemMedia-content-hd']")]
        [CacheLookup]
        public IWebElement SelectCartidge { get; set; }
        public IWebElement refineResult { get; set; }
        public Cartridge_Filter(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        //public void refineResult()
        //{

        //}
    }
}
