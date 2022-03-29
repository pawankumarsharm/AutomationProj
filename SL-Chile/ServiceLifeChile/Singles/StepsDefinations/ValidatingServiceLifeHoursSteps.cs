using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using ServiceLifeChile.Helpers;
using ServiceLifeChile.ObjectRepositories;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using Environment = ServiceLifeChile.ObjectRepositories.Environment;

namespace ServiceLifeChile.StepsDefinations
{
    [Binding]
    public class ValidatingServiceLifeHoursSteps : BrowserConfig
    {
        public static ILog Logger = GenerateLogs.GetLogger(typeof(ValidatingServiceLifeHoursSteps));
        private static string baseURL = ConfigurationManager.AppSettings.Get("url");
        private static string browser = ConfigurationManager.AppSettings.Get("browsers");
        // public static IWebDriver _driver;
        [Given(@"I have navigated to SLS Web Application\.")]
        public void GivenIHaveNavigatedToSLSWebApplication_()
        {
            Logger.Info("=======================================================");
            Logger.Info("===========Redirecting to the Url:===============");
            string currentUrl = webDriver.Url;
            if (currentUrl == "https://rssl-dev.azurewebsites.net/selectresultstype")
            {
                Console.WriteLine("Just continue to next step");
                Logger.Info("Already in the result page");

            }
            else
            {
                Logger.Info("Navigating to the SLS HomePage");
                HelperFunctions.NavigateToSLS();
            }
            Logger.Info("=======================================================");
            //if(_driver!=null)
            //{
            //    Console.WriteLine("In homePage only");
            //}
            //else
            //{
            //    _driver = new ChromeDriver();
            //    _driver.Manage().Window.Maximize();
            //    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //    _driver.Url = baseURL;
            //}
        }
        [Then(@"I set region as (.*) from sheet\.")]
        public void ThenISetRegionAsFromSheet_(string _region)
        {
            string url = "https://rssl-dev.azurewebsites.net/selectresultstype";
            if (webDriver.Url.Equals(url))
            {
                Console.WriteLine("Already in the desired page.");
            }
            else
            {
                HomePage hp = new HomePage(webDriver);
                try
                {
                    hp.acceptCookies();
                }
                catch
                {
                    Console.WriteLine("Not visible");
                }
                hp.sel();
                hp.selectChileReg();
            }
            //hp.clickOnNextBtn();

        }
        [Then(@"I click on the next button to proceed further\.")]
        public void ThenIClickOnTheNextButtonToProceedFurther_()
        {
            string url = "https://rssl-dev.azurewebsites.net/";
            if (webDriver.Url.Equals(url))
            {
                HomePage hp = new HomePage(webDriver);
                hp.clickOnNextBtn();
            }
            else
            {
                Console.WriteLine("");
            }

        }

        [Then(@"In the Setup page I select the Service Life result and click on IAccept to continue\.")]
        public void ThenInTheSetupPageISelectTheServiceLifeResultAndClickOnIAcceptToContinue_()
        {
            SetupServiceLife sl = new SetupServiceLife(webDriver);
            sl.selectServiceLife();
            sl.acceptAndContinue();
        }

        [Then(@"In the contaminant page I filter the Contaminants using (.*) and set the (.*) and (.*)")]
        public void ThenInTheContaminantPageIFilterTheContaminantsUsingAndSetTheAnd(string cas, string exposure, string expUnit)
        {
            Contaminants con = new Contaminants(webDriver);
            con.searchContaminantUsingCAS().SendKeys(cas);
            con.selectTheContiminant();
            con.setExposureValue().SendKeys(exposure);
            HelperFunctions hf = new HelperFunctions();
            hf.SetExposureUnit(expUnit, webDriver);
            HomePage hp = new HomePage(webDriver);
            hp.clickOnNextBtn();
        }
        [Then(@"In the refine page I click on done button\.")]
        public void ThenInTheRefinePageIClickOnDoneButton_()
        {
            IWebElement Finalizer = webDriver.FindElement(By.XPath("//button[@class='btn mix-btn_block' and text()='Finalizar']"));
            
            if (Finalizer.Enabled)
            {
                Finalizer.Click();               
            }
            //else
            //{
            //    IWebElement Visto_Bueno = webDriver.FindElement(By.XPath("//button[text()='Visto bueno']"));
            //    Visto_Bueno.Click();
            //    Finalizer.Click();
            //}
            
        }
        [Then(@"In the filter page select the solution (.*) that works for you\.")]
        public void ThenInTheFilterPageSelectTheSolutionThatWorksForYou_(string cartidge)
        {
            FilterPage Fp = new FilterPage(webDriver);

            if (cartidge.Contains("i"))
            {

                Fp.searchCartidges().SendKeys(cartidge);
                Fp.selectCartidges(cartidge);
                Fp.selectAndContinue().Click();
                Fp.ELSIOK().Click();
            }
            else
            {
                Fp.searchCartidges().SendKeys(cartidge);
                Fp.selectCartidges(cartidge);
                Fp.selectAndContinue().Click();
            }
        }
        [Then(@"In Environment page I set the details of (.*),(.*),(.*),(.*) and (.*)")]
        public void ThenInEnvironmentPageISetTheDetailsOfAnd(string relHum, string atmPressure, string temp, string tempUnit, string workRate)
        {
            ObjectRepositories.Environment env = new Environment(webDriver);
            HelperFunctions hf = new HelperFunctions();
            hf.setRelativeHumidity(env.relativeHumidity(), relHum);
            env.setPressure().Clear();
            env.setPressure().SendKeys(atmPressure);
            env.SetTempUnit(tempUnit);
            hf.setTemperature(env.setTemperature(), temp);
            hf.setWorkRate(env.WorkRate(), workRate);
            HomePage hp = new HomePage(webDriver);
            hp.clickOnNextBtn();
        }
        [Then(@"I verify the (.*) in the review page\.")]
        public void ThenIVerifyTheInTheReviewPage_(string workRate)
        {
            Review rev = new Review(webDriver);
            if (workRate.Equals(rev.WorkRate()))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Assert.Fail("Expected hours {0} but was {1}", workRate, rev.WorkRate());
            }
            rev.Done().Click();
        }


    }
}
