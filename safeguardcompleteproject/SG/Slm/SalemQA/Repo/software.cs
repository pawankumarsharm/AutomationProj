using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemQA.Repo
{
    class software
    {
        IWebDriver driver;
        public software(IWebDriver driver)
        {
            this.driver = driver;
        }
        By seeDetails = By.XPath("(//a[@id='seeDetailsAnonymous'])[1]");
        By req = By.XPath("//button[@id='downloadBtn']");
        public IWebElement SeeDetailsBtn()
        {
            return driver.FindElement(seeDetails);
        }
        public IWebElement Request()
        {
            return driver.FindElement(req);
        }
    }
}
