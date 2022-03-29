using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Safeguard.Xpath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Safeguard.Steps
{
    [Binding]
    public class Hooks1
    {
        private static ScenarioContext scenarioContext;
        private readonly IObjectContainer iob;
        public IWebDriver driver;
        public Hooks1(IObjectContainer iob)
        {
            this.iob = iob;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(@"C:\Users\PAWAN KUMAR SHARMA\Downloads\Safeguard\Safeguard\Chrome driver");
            //ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            iob.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = iob.Resolve<IWebDriver>();
            if
                   (driver != null)
            {
                //driver.Quit();
                //driver.Dispose();
            }
        }
        [AfterScenario]
        [Obsolete]
        public void ExcelCode()
        {
            int row = ' ';

            if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Open safeguard website and then check data validation"))
            {
                row = 2;
            }
            
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Open safeguard website and check links are working or not"))
            {
                row = 3;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Open safeguard website and check header and footer"))
            {
                row = 4;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Open Safeguard website and check dropdown function"))
            {
                row = 5;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Open safeguard website and change language"))
            {
                row = 6;
            }



            if (ScenarioContext.Current.TestError == null)
            {
                String msg = "Pass";
                string res = "Passed Successfully";
                string scen = ScenarioContext.Current.ScenarioInfo.Title;

                WriteDataToExcel.ExcelCode(res, msg, row, scen);
            }

            else if (ScenarioContext.Current.TestError != null)
            {
                String msg = "Fail";
                string res = ScenarioContext.Current.TestError.Message;
                string scen = ScenarioContext.Current.ScenarioInfo.Title;

                WriteDataToExcel.ExcelCode(res, msg, row, scen);
            }
        }
    }
}
