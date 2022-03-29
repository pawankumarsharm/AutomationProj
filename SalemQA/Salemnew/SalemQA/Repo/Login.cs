using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemQA.Repo
{
    class Login
    {
        IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }
        By email = By.XPath("//input[@id='logonIdentifier']");
        By password = By.XPath("//input[@id='password']");
        By loginbtn = By.XPath("//button[@id='next']");
        public IWebElement Email()
        {
            return driver.FindElement(email);
        }
        public IWebElement Password()
        {
            return driver.FindElement(password);
        }
        public IWebElement LogIn()
        {
            return driver.FindElement(loginbtn);
        }
    }
}
