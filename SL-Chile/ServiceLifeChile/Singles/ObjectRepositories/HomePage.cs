using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class HomePage
    {
            IWebDriver driver;
            By confCookies = By.CssSelector("div#consent_prompt_submit");
            By country = By.XPath("//div[@class='countryOfRegulation-labeltext' and text()='Canada (English)']");
            By chileFlag = By.XPath("//*[text()='Chile (Español)']");
            By homeNext = By.CssSelector("button[class='btn btn_primary']");

            public HomePage(IWebDriver _driver)
            {
                this.driver = _driver;
            }
            public void acceptCookies()
            {
                driver.FindElement(confCookies).Click();
                Thread.Sleep(2000);

        }
            public void selectChileReg()
            {
                driver.FindElement(chileFlag).Click();
                Thread.Sleep(2000);
            }
            public void sel()
            {
                driver.FindElement(country).Click();
                
            }
            public void clickOnNextBtn()
            {
                driver.FindElement(homeNext).Click();
            }
        }
    }

