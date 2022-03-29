using log4net;
using OpenQA.Selenium;
using select_service_us_canada.single_acid_validation.Configurations;
using select_service_us_canada.single_acid_validation.Logger;
using select_service_us_canada.single_acid_validation.Utilities;
using System;
using TechTalk.SpecFlow;

namespace select_service_us_canada.single_acid_validation.StepDefinations
{
    [Binding]
    public class Non_Mixture_ValidationSteps
    {
        public static ILog _logger = GenerateLogs.GetLogger(typeof(Non_Mixture_ValidationSteps));
        /// <summary>
        /// Navigate to the SLS Home Page
        /// </summary>
        [Given(@"I have navigated to the SLS Website Home Page")]
        public void GivenIHaveNavigatedToTheSLSWebsiteHomePage()
        {
            _logger.Info("=======================================================");
            _logger.Info("===========Redirecting to the Url:===============");
            string currentUrl = BrowserAndUrlConfig.webDriver.Url;
            if(currentUrl== "https://rssl-dev.azurewebsites.net/selectresultstype")
            {
                Console.WriteLine("Just continue to next step");
                _logger.Info("Already in the result page");

            }
            else
            {
                _logger.Info("Navigating to the SLS HomePage");
                FunctionsDefinations.NavigateToSLS();
            }
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Selection of Region
        /// </summary>
        [Then(@"I select the provided (.*) as the Country Region")]
        public void ThenISelectTheProvidedAsTheCountryRegion(string regionSelector)
        {
            _logger.Info("=======================================================");
            _logger.Info("=============Setting the Region ===================");
            _logger.Info("Trying to select the Region " + regionSelector);
            FunctionsDefinations.RegionSelect(regionSelector);
            _logger.Info("Successfully set the Region " + regionSelector);
            _logger.Info("=======================================================");
        }
        [Then(@"I click on next button after region selection")]
        public void ThenIClickOnNextButtonAfterRegionSelection()
        {
            _logger.Info("=======================================================");
            _logger.Info("Click on next button after region selection");
            FunctionsDefinations.ProccedToNext();
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Selection of Service Life Estimate End of Service
        /// </summary>
        [Then(@"I select the Service Life Estimate/End of Service Life Indicator \(ESLI\) Compatibility using the radio button")]
        public void ThenISelectTheServiceLifeEstimateEndOfServiceLifeIndicatorESLICompatibilityUsingTheRadioButton()
        {
            _logger.Info("=======================================================");
            _logger.Info("=============Selecting ELSI=================");
            FunctionsDefinations.ESLISelector();
            _logger.Info("Successfully selected Service Life Estimate/End of Service Life(ESLI)");
            _logger.Info("=======================================================");
        }

        [Then(@"Click on IAccept button")]
        public void ThenClickOnIAcceptButton()
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.AcceptToMove();
            _logger.Info("Clicking on IAccept button after selecting ESLI");
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Filter the data using the CAS
        /// </summary>
        /// <param name="cas"></param>
        [Then(@"I filter the data using (.*) in the Contaminate Page and select the filtered product\.")]
        public void ThenIFilterTheDataUsingInTheContaminatePageAndSelectTheFilteredProduct_(string cas)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.FilterContaminantUsingCAS(cas);
            _logger.Info("Successfully selected product using the cas value as :"+cas);
            _logger.Info("=======================================================");

        }
        /// <summary>
        /// Enter the the Exposure and it's unit for the filtered contaminant
        /// </summary>
        /// <param name="exposure"></param>
        /// <param name="expunit"></param>
        /// <param name="cas"></param>
        [Then(@"Enter the (.*) value and (.*) for the (.*) provided\.")]
        public void ThenEnterTheValueAndForTheProvided_(string exposure, string expunit, string cas)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.ExposureForSelectedProd(exposure, expunit, cas);
            _logger.Info("Successfully set the Exposure "+exposure +"and Exposure Unit as"+expunit );
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Done
        /// </summary>
        //[Then(@"Click on the Done button to proceed further\.")]
        //public void ThenClickOnTheDoneButtonToProceedFurther_()
        //{
        //    FunctionsDefinations.Done();
        //}
        [Then(@"Click on the Done button to proceed further(.*)\.")]
        public void ThenClickOnTheDoneButtonToProceedFurther_(string cas)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.Done(cas);
            _logger.Info("Clicking on Next button...............Success");
            _logger.Info("=======================================================");
        }

        /// <summary>
        /// Filtering the products using the Cartidge Value
        /// </summary>
        /// <param name="cartidge"></param>
        [Then(@"In cartidge page  filter the products using the (.*)")]
        public void ThenInCartidgePageFilterTheProductsUsingThe(string cartidge)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.FilterUsingCartidge(cartidge);
            _logger.Info("Filerting the cartidge " + cartidge);
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Select the Product filtered using the Cartidge Value
        /// </summary>
        /// <param name="cartidge"></param>
        [Then(@"Select the  product filtered using the (.*) number")]
        public void ThenSelectTheProductFilteredUsingTheNumber(string cartidge)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.SelectFilteredProd(cartidge);
            _logger.Info("Selecting the cartidge: " + cartidge+".......Success");
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Read the description generated according to the value inputted and click on Select and Continue to proceed further
        /// </summary>

        [Then(@"Read the description and Click on Select and Continue according to the (.*) value")]
        public void ThenReadTheDescriptionAndClickOnSelectAndContinueAccordingToTheValue(string cartidge)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.SelectAndContinue(cartidge);
            _logger.Info("Successfully clicked on Select and Continue");
            _logger.Info("=======================================================");
        }

        /// <summary>
        /// Enter the details of the Contaminant 
        /// </summary>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        /// <param name="temp"></param>
        /// <param name="tempunit"></param>
        /// <param name="workrate"></param>
        [Then(@"In the Environment  condition enter the (.*) ,(.*),(.*),(.*) and (.*)")]
        public void ThenInTheEnvironmentConditionEnterTheAnd(string humidity, string pressure, int temp, string tempunit, string workrate)
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.EnvironmentDetails(humidity, pressure, temp, tempunit, workrate);
            _logger.Info("Successfully set the environment details as " + humidity + pressure + temp + tempunit + workrate);
            _logger.Info("=======================================================");
        }

        [Then(@"Click on the next button and verify the data entered\.")]
        public void ThenClickOnTheNextButtonAndVerifyTheDataEntered_()
        {
            _logger.Info("=======================================================");
            FunctionsDefinations.Verify();
            _logger.Info("=======================================================");
        }
        /// <summary>
        /// Match the WorkRate of the the contaminant with the Service Life Hours provided in the test case and mark the test case as Pass or Fail according to it.
        /// </summary>
        /// <param name="workrate"></param>
        [Then(@"After verifying the details in the Environment page, if (.*) matches the Actual Hours displayed then click on on Done button\.")]
        public void ThenAfterVerifyingTheDetailsInTheEnvironmentPageIfMatchesTheActualHoursDisplayedThenClickOnOnDoneButton_(string workrate)
        {
            _logger.Info("=======================================================");
            _logger.Info("Expected hours from the excel is " + workrate);
            FunctionsDefinations.VerifyHours(workrate);
           
            //Assert the Hours

            BrowserAndUrlConfig.webDriver.FindElement(By.XPath(XpathContainer.IAccept)).Click();
            _logger.Info("=======================================================");

        }
    }
}
