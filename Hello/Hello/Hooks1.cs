using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Hello
{
    [Binding]
    class Hooks1
    {
        private readonly IObjectContainer container; 
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public Hooks1(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            container.RegisterInstanceAs<IWebDriver>(driver);//TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }//TODO: implement logic that has to run after executing each scenario
        }
    }
}
