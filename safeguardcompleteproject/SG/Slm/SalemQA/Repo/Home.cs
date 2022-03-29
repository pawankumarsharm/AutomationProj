using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemQA.Repo
{
    class Home
    {
        IWebDriver driver;
        public Home(IWebDriver driver)
        {
            this.driver = driver;   
        }
        By adduser = By.XPath("//button[contains(text(),'Add Users')]");
        By LoginLink = By.XPath("//li[@class='MMM--utilityLinks MMM--isOnDesktop MMM--desktopUtilLinks']");
        By software = By.XPath("//a[@title='SOFTWARE']");
        By softwarePO = By.XPath("//h3[contains(text(),'Software Previously Obtained')]");
        By downloadAvailable = By.XPath("//a[@class='MMM--btn MMM--btn_primary mix-MMM--btn_fullWidthMobileOnly  mix-MMM--btn_allCaps unicornButtonActive  mr-2']");
        public IWebElement Login()
        {
            return driver.FindElement(LoginLink);
        }
        public IWebElement AddUser()
        {
            return driver.FindElement(adduser);
        }
        public IWebElement SoftwareSection()
        {
            return driver.FindElement(software);
        }
        public IWebElement SoftwarePObtained()
        {
            return driver.FindElement(softwarePO);
        }
        public IList<IWebElement> AvailabeForDownload()
        {
            return driver.FindElements(downloadAvailable);
        }
    }
}
