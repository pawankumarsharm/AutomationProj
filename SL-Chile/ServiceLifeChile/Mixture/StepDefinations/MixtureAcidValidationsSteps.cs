using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ServiceLife_Chile.mixture_acids_validation.Configurations;
using ServiceLife_Chile.mixture_acids_validation.excel;
using ServiceLife_Chile.mixture_acids_validation.Logger;
using ServiceLife_Chile.mixture_acids_validation.Utilities;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
//public static ILog _logger = GenerateLogs.GetLogger(typeof(Non_Mixture_ValidationSteps));
namespace ServiceLife_Chile.mixture_acids_validation.StepDefinations
{
    [Binding]
    public class MixtureAcidValidationsSteps
    {
        SelectAcid sa = new SelectAcid();
        public static ILog _logger = GenerateLogs.GetLogger(typeof(MixtureAcidValidationsSteps));
        private static readonly string baseURL = ConfigurationManager.AppSettings.Get("url");
         


        [Given(@"I have already navigated to the SLS WebPage")]
        public void GivenIHaveAlreadyNavigatedToTheSLSWebPage()
        {
            _logger.Info("Mixture Validation Started.......");
            string currentUrl = BrowserConfig.webDriver.Url;
            string resultType = "https://rssl-dev.azurewebsites.net/selectresultstype";
            string contaminant = "https://rssl-dev.azurewebsites.net/contaminants";
            string _reviewPage = "https://rssl-dev.azurewebsites.net/review";
            string _productsPage = "https://rssl-dev.azurewebsites.net/products";
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.cookies)).Click();
            if (currentUrl.Equals(baseURL))
            {
                string region = MixtureResultWriteExcel.SelectRegion();
                MixtureUtility.NavigateFromHome(region);
            }
            else if(currentUrl.Equals(_productsPage))
            {
                BrowserConfig.webDriver.Url = contaminant;
            }
            else if (currentUrl.Equals(resultType))
            {
                _logger.Info("Selecting Service Life ElSI selector check box");
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.chkbox)).Click();
                ExplicitWait.WaitForAnElement(XpathContainer.next);
                //Accept to proceed further
                _logger.Info("Clicking on next IAccept button after selecting Service Life ElSI selector check box");
                BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            }
            else if(currentUrl.Equals(_reviewPage))
            {
                bool donebtn = BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Displayed;
                ExplicitWait.WaitForAnElement(XpathContainer.next);
                if (donebtn)
                {
                    _logger.Info("Clicking on the final done button");
                    BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
                    ExplicitWait.WaitForAnElement(XpathContainer.chkbox);
                    MixtureAcidValidationsSteps._logger.Info("Clicking on Service Life ElSI selector check box");
                    BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.chkbox)).Click();
                    ExplicitWait.WaitForAnElement(XpathContainer.next);
                    MixtureAcidValidationsSteps._logger.Info("Clicking on next IAccept button after selecting Service Life ElSI selector check box");
                    //Accept to proceed further
                    BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
                }
                else
                {
                    Console.WriteLine("Button not visible");
                }
            }
            else if (currentUrl.Equals(contaminant))
            {
                Console.WriteLine("Already in the required webpage");
            }
            
        }
        [Then(@"I select the AF acid and set their respective exposure values\.")]
        public void ThenISelectTheAFAcidAndSetTheirRespectiveExposureValues_()
        {
            //////////////////////////////////////////////////////////            
            
            //Select the Acetonitrile Acid
            sa.SelectAcidRespirator(AcidCas._casAcetonitrile);
            _logger.Info("Sending the cas value as " + AcidCas._casAcetonitrile);
            //Set Exposure for Acetonitrile
            sa._exposure = ReadMixtureData.getdata(4, 2);
            sa._exposureUnit = ReadMixtureData.getdata(5, 2);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure +" "+sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Formaldehyde acid
            //Set the cas value from the excel sheet
            
            
            _logger.Info("Sending the cas value as " + AcidCas._casFormamide);
            //Select the Formaldehyde Acid
            sa.SelectAcidRespirator(AcidCas._casFormamide);
            //Set Exposure for Formaldehyde
            sa._exposure = ReadMixtureData.getdata(4, 3);
            sa._exposureUnit = ReadMixtureData.getdata(5, 3);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
            //////////////////////////////////////////////////////////
        }
        [Then(@"I click on next button and then click on Done button on Refine Result")]
        public void ThenIClickOnNextButtonAndThenClickOnDoneButtonOnRefineResult()
        {
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.btnDone);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.btnDone)).Click();
        }
        [Then(@"I click on next button and then click on Done button on Refine Result for AcetonitrileMethylineChlorideFormamide")]
        public void ThenIClickOnNextButtonAndThenClickOnDoneButtonOnRefineResultForAcetonitrileMethylineChlorideFormamide()
        {
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.next)).Click();
            ExplicitWait.WaitForSomeTime(1000);
            ExplicitWait.WaitForAnElement(XpathContainer._btnOK);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer._btnOK)).Click();
            ExplicitWait.WaitForAnElement(XpathContainer.btnDone);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.btnDone)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValue()
        {
            sa._cartidge= ReadMixtureData.getdata(6, 2);
            sa.SelectTheCartidgeorFilter(sa._cartidge);           
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }        

        [When(@"I click on the Select And Continue button , I should be in environment setup page\.")]
        public void WhenIClickOnTheSelectAndContinueButtonIShouldBeInEnvironmentSetupPage_()
        {
            _logger.Info("Clicking on Select and Continue button");
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.SelCon)).Click();
        }

        [When(@"After setting up the environment details click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 2);
            sa._atmospPressure = ReadMixtureData.getdata(8, 2);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 2));
            sa._tempUnit = ReadMixtureData.getdata(10, 2);
            sa._workRate=ReadMixtureData.getdata(11,2);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify teh Service Life Estimate and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTehServiceLifeEstimateAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 2);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the HS acid and set their respective exposure values\.")]
        public void ThenISelectTheHSAcidAndSetTheirRespectiveExposureValues_()
        {
            //////////////////////////////////////////////////////////            
            
            //Select the Hexane Acid
            sa.SelectAcidRespirator(AcidCas._casHexane);
            _logger.Info("Sending the cas value as " + AcidCas._casHexane);
            //Set Exposure for Hexane
            sa._exposure = ReadMixtureData.getdata(4, 4);
            sa._exposureUnit = ReadMixtureData.getdata(5, 4);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Styrene acid
            //Set the cas value from the excel sheet

            
            _logger.Info("Sending the cas value as " + AcidCas._casStyrene);
            //Select the Styrene Acid
            sa.SelectAcidRespirator(AcidCas._casStyrene);
            //Set Exposure for Styrene
            sa._exposure = ReadMixtureData.getdata(4, 5);
            sa._exposureUnit = ReadMixtureData.getdata(5, 5);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
            //////////////////////////////////////////////////////////
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for HS Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForHSAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 4);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for HS Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForHSAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 4);
            sa._atmospPressure = ReadMixtureData.getdata(8, 4);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 4));
            sa._tempUnit = ReadMixtureData.getdata(10, 4);
            sa._workRate = ReadMixtureData.getdata(11, 4);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for HS Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForHSAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 4);
            sa.VerifyHours(sa._expectedHours);
        }
        [Then(@"I select the HFSO acid")]
        public void ThenISelectTheHFSOAcid()
        {
            
            //Select the Hydrogen Flouride Acid
            sa.SelectAcidRespirator(AcidCas._casHF);
            _logger.Info("Sending the cas value as " + AcidCas._casHF);
            //Set Exposure for Hydrogen Flouride
            sa._exposure = ReadMixtureData.getdata(4, 6);
            sa._exposureUnit = ReadMixtureData.getdata(5, 6);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid
            //Set the cas value from the excel sheet

            
            _logger.Info("Sending the cas value as " + AcidCas._casSO2);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 7);
            sa._exposureUnit = ReadMixtureData.getdata(5, 7);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for HFSO Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForHFSOAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 6);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for HFSO Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForHFSOAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 6);
            sa._atmospPressure = ReadMixtureData.getdata(8, 6);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 6));
            sa._tempUnit = ReadMixtureData.getdata(10, 6);
            sa._workRate = ReadMixtureData.getdata(11, 6);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for HFSO Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForHFSOAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 6);
            sa.VerifyHours(sa._expectedHours);
        }
        [Then(@"I select the AM acid")]
        public void ThenISelectTheAMAcid()
        {
            
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 8);
            sa._exposureUnit = ReadMixtureData.getdata(5, 8);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Methylamine acid
            
            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 9);
            sa._exposureUnit = ReadMixtureData.getdata(5, 9);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }
        [Then(@"I select the AM acid with exposure unit as mg")]
        public void ThenISelectTheAMAcidWithExposureUnitAsMg()
        {
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 10);
            sa._exposureUnit = ReadMixtureData.getdata(5, 10);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Methylamine acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 11);
            sa._exposureUnit = ReadMixtureData.getdata(5, 11);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }
        [Then(@"I select the AM acid with exposure unit as mg(.*)")]
        public void ThenISelectTheAMAcidWithExposureUnitAsMg(int p0)
        {
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 12);
            sa._exposureUnit = ReadMixtureData.getdata(5, 12);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Methylamine acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 13);
            sa._exposureUnit = ReadMixtureData.getdata(5, 13);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for AmmoniaMethylamine Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForAmmoniaMethylamineAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 8);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for AmmoniaMethylamine Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAmmoniaMethylamineAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 8);
            sa._atmospPressure = ReadMixtureData.getdata(8, 8);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 8));
            sa._tempUnit = ReadMixtureData.getdata(10, 8);
            sa._workRate = ReadMixtureData.getdata(11, 8);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AmmoniaMethylamine Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAmmoniaMethylamineAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 8);
            sa.VerifyHours(sa._expectedHours); 
        }
        [When(@"After setting up the environment details for AmmoniaMethylamine Acid Mixture_mg(.*) click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAmmoniaMethylamineAcidMixture_MgClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 10);
            sa._atmospPressure = ReadMixtureData.getdata(8, 10);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 10));
            sa._tempUnit = ReadMixtureData.getdata(10, 10);
            sa._workRate = ReadMixtureData.getdata(11, 10);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AmmoniaMethylamine Acid Mixture_mg(.*) and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAmmoniaMethylamineAcidMixture_MgAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 10);
            sa.VerifyHours(sa._expectedHours); 
        }
        [When(@"After setting up the environment details for AmmoniaMethylamine Acid MixtureMg click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAmmoniaMethylamineAcidMixtureMgClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 12);
            sa._atmospPressure = ReadMixtureData.getdata(8, 12);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 12));
            sa._tempUnit = ReadMixtureData.getdata(10, 12);
            sa._workRate = ReadMixtureData.getdata(11, 12);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AmmoniaMethylamine Acid MixtureMg and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAmmoniaMethylamineAcidMixtureMgAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 12);
            sa.VerifyHours(sa._expectedHours);
        }
        [Then(@"I select the ASO(.*) acid")]
        public void ThenISelectTheASOAcid(int p0)
        {
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 14);
            sa._exposureUnit = ReadMixtureData.getdata(5, 14);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 15);
            sa._exposureUnit = ReadMixtureData.getdata(5, 15);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for ASO(.*) Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForASOAcidMixture(int p0)
        {
            sa._cartidge = ReadMixtureData.getdata(6, 14);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for ASO(.*) Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForASOAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 14);
            sa._atmospPressure = ReadMixtureData.getdata(8, 14);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 14));
            sa._tempUnit = ReadMixtureData.getdata(10, 14);
            sa._workRate = ReadMixtureData.getdata(11, 14);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for ASO(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForASOAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 14);
            sa.VerifyHours(sa._expectedHours);
        }
        [Then(@"I select the H(.*)SSO(.*) acid")]
        public void ThenISelectTheHSSOAcid(int p0, int p1)
        {
            //Select the HydrogenSulphide Acid
            sa.SelectAcidRespirator(AcidCas._casHS);
            _logger.Info("Sending the cas value as " + AcidCas._casHS);
            //Set Exposure for HydrogenSulphide
            sa._exposure = ReadMixtureData.getdata(4, 16);
            sa._exposureUnit = ReadMixtureData.getdata(5, 16);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 17);
            sa._exposureUnit = ReadMixtureData.getdata(5, 17);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for H(.*)SSO(.*) Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForHSSOAcidMixture(int p0, int p1)
        {
            sa._cartidge = ReadMixtureData.getdata(6, 16);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for H(.*)SSO(.*) Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForHSSOAcidMixtureClickOnNextButtonToProceedFurther_(int p0, int p1)
        {
            sa._humidity = ReadMixtureData.getdata(7, 16);
            sa._atmospPressure = ReadMixtureData.getdata(8, 16);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 16));
            sa._tempUnit = ReadMixtureData.getdata(10, 16);
            sa._workRate = ReadMixtureData.getdata(11, 16);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for H(.*)SSO(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForHSSOAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0, int p1)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 16);
            sa.VerifyHours(sa._expectedHours);
        }
        [Then(@"I select the AcetoneSO(.*) acid")]
        public void ThenISelectTheAcetoneSOAcid(int p0)
        {
            //Select the Acetone Acid
            sa.SelectAcidRespirator(AcidCas._casAcetone);
            _logger.Info("Sending the cas value as " + AcidCas._casAcetone);
            //Set Exposure for Acetone
            sa._exposure = ReadMixtureData.getdata(4, 18);
            sa._exposureUnit = ReadMixtureData.getdata(5, 18);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 19);
            sa._exposureUnit = ReadMixtureData.getdata(5, 19);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for AcetoneSO(.*) Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForAcetoneSOAcidMixture(int p0)
        {
            sa._cartidge = ReadMixtureData.getdata(6, 18);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for AcetoneSO(.*) Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAcetoneSOAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 18);
            sa._atmospPressure = ReadMixtureData.getdata(8, 18);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 18));
            sa._tempUnit = ReadMixtureData.getdata(10, 18);
            sa._workRate = ReadMixtureData.getdata(11, 18);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AcetoneSO(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAcetoneSOAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 18);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneAmmonia acid")]
        public void ThenISelectTheTouleneAmmoniaAcid()
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 20);
            sa._exposureUnit = ReadMixtureData.getdata(5, 20);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Ammonia acid

            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 21);
            sa._exposureUnit = ReadMixtureData.getdata(5, 21);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneAmmonia Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneAmmoniaAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 20);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneAmmonia Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneAmmoniaAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 20);
            sa._atmospPressure = ReadMixtureData.getdata(8, 20);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 20));
            sa._tempUnit = ReadMixtureData.getdata(10, 20);
            sa._workRate = ReadMixtureData.getdata(11, 20);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneAmmonia Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneAmmoniaAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 20);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneAmmonia(.*) acids")]
        public void ThenISelectTheTouleneAmmoniaAcids(int p0)
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 22);
            sa._exposureUnit = ReadMixtureData.getdata(5, 22);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Ammonia acid

            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 23);
            sa._exposureUnit = ReadMixtureData.getdata(5, 23);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneAmmonia(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneAmmoniaAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 22);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the AmmoniaSulfurDioxide acid")]
        public void ThenISelectTheAmmoniaSulfurDioxideAcid()
        {
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 24);
            sa._exposureUnit = ReadMixtureData.getdata(5, 24);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 25);
            sa._exposureUnit = ReadMixtureData.getdata(5, 25);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for AmmoniaSulfurDioxide Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForAmmoniaSulfurDioxideAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 24);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for AmmoniaSulfurDioxide Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAmmoniaSulfurDioxideAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 24);
            sa._atmospPressure = ReadMixtureData.getdata(8, 24);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 24));
            sa._tempUnit = ReadMixtureData.getdata(10, 24);
            sa._workRate = ReadMixtureData.getdata(11, 24);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AmmoniaSulfurDioxide Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAmmoniaSulfurDioxideAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 24);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the AmmoniaSulfurDioxide(.*) acids")]
        public void ThenISelectTheAmmoniaSulfurDioxideAcids(int p0)
        {
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 26);
            sa._exposureUnit = ReadMixtureData.getdata(5, 26);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 27);
            sa._exposureUnit = ReadMixtureData.getdata(5, 27);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AmmoniaSulfurDioxide(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAmmoniaSulfurDioxideAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 26);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneSulfurDioxide acid")]
        public void ThenISelectTheTouleneSulfurDioxideAcid()
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 28);
            sa._exposureUnit = ReadMixtureData.getdata(5, 28);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 29);
            sa._exposureUnit = ReadMixtureData.getdata(5, 29);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneSulfurDioxide Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneSulfurDioxideAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 28);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneSulfurDioxide Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneSulfurDioxideAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 28);
            sa._atmospPressure = ReadMixtureData.getdata(8, 28);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 28));
            sa._tempUnit = ReadMixtureData.getdata(10, 28);
            sa._workRate = ReadMixtureData.getdata(11, 28);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneSulfurDioxide Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneSulfurDioxideAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 28);
            sa.VerifyHours(sa._expectedHours);
        }

        [When(@"After setting up the environment details for TouleneSulfurDioxide(.*) Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneSulfurDioxideAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 30);
            sa._atmospPressure = ReadMixtureData.getdata(8, 30);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 30));
            sa._tempUnit = ReadMixtureData.getdata(10, 30);
            sa._workRate = ReadMixtureData.getdata(11, 30);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneSulfurDioxide(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneSulfurDioxideAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 30);
            sa.VerifyHours(sa._expectedHours);
        }

        //[Then(@"I select the TouleneMEK acid")]
        //public void ThenISelectTheTouleneMEKAcid()
        //{
        //    //Select the Toulene Acid
        //    sa.SelectAcidRespirator(AcidCas._casToulene);
        //    _logger.Info("Sending the cas value as " + AcidCas._casToulene);
        //    //Set Exposure for Toulene
        //    sa._exposure = ReadMixtureData.getdata(4, 32);
        //    sa._exposureUnit = ReadMixtureData.getdata(5, 32);
        //    _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
        //    MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
        //    _logger.Info("Clearing the Search Box");

        //    Clear();
        //    //Now selecting MEK acid

        //    _logger.Info("Sending the cas value as " + AcidCas._casMEK);
        //    //Select the MEK Acid
        //    sa.SelectAcidRespirator(AcidCas._casMEK);
        //    //Set Exposure for MEK
        //    sa._exposure = ReadMixtureData.getdata(4, 33);
        //    sa._exposureUnit = ReadMixtureData.getdata(5, 33);
        //    _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
        //    MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
        //    ExplicitWait.WaitForAnElement(XpathContainer.selected);
        //    BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        //}

        //[Then(@"I filter the required cartidge/filter using the cartidge value for TouleneMEK Acid Mixture")]
        //public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneMEKAcidMixture()
        //{
        //    sa._cartidge = ReadMixtureData.getdata(6, 32);
        //    sa.SelectTheCartidgeorFilter(sa._cartidge);
        //    ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
        //    Pause.Waiting();
        //}

        //[When(@"After setting up the environment details for TouleneMEK Acid Mixture click on next button to proceed further\.")]
        //public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneMEKAcidMixtureClickOnNextButtonToProceedFurther_()
        //{
        //    sa._humidity = ReadMixtureData.getdata(7, 32);
        //    sa._atmospPressure = ReadMixtureData.getdata(8, 32);
        //    sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 32));
        //    sa._tempUnit = ReadMixtureData.getdata(10, 32);
        //    sa._workRate = ReadMixtureData.getdata(11, 32);
        //    sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
        //    _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
        //    _logger.Info("Clicking on next button after setting up the environment details");
        //    ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
        //    BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        //}

        //[Then(@"Verify the Service Life Estimate for TouleneMEK Acid Mixture and then click on Done button to complete the verification process\.")]
        //public void ThenVerifyTheServiceLifeEstimateForTouleneMEKAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        //{
        //    sa._expectedHours = ReadMixtureData.getdata(12, 32);
        //    sa.VerifyHours(sa._expectedHours);
        //}

        [Then(@"I select the AcetonitrileMethylineChlorideFormamide acid")]
        public void ThenISelectTheAcetonitrileMethylineChlorideFormamideAcid()
        {
            //Select the Acetonitrile Acid
            sa.SelectAcidRespirator(AcidCas._casAcetonitrile);
            _logger.Info("Sending the cas value as " + AcidCas._casAcetonitrile);
            //Set Exposure for Acetonitrile
            sa._exposure = ReadMixtureData.getdata(4, 32);
            sa._exposureUnit = ReadMixtureData.getdata(5, 32);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting MethyleneChloride acid
            _logger.Info("Sending the cas value as " + AcidCas._casMethyleneChloride);
            //Select the MethyleneChloride Acid
            sa.SelectAcidRespirator(AcidCas._casMethyleneChloride);
            //Set Exposure for MethyleneChloride
            sa._exposure = ReadMixtureData.getdata(4, 33);
            sa._exposureUnit = ReadMixtureData.getdata(5, 33);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Formamide acid
            _logger.Info("Sending the cas value as " + AcidCas._casFormamide);
            //Select the Formamide Acid
            sa.SelectAcidRespirator(AcidCas._casFormamide);
            //Set Exposure for Formamide
            sa._exposure = ReadMixtureData.getdata(4, 34);
            sa._exposureUnit = ReadMixtureData.getdata(5, 34);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for AcetonitrileMethylineChlorideFormamide Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForAcetonitrileMethylineChlorideFormamideAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 32);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for AcetonitrileMethylineChlorideFormamide Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAcetonitrileMethylineChlorideFormamideAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 32);
            sa._atmospPressure = ReadMixtureData.getdata(8, 32);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 32));
            sa._tempUnit = ReadMixtureData.getdata(10, 32);
            sa._workRate = ReadMixtureData.getdata(11, 32);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AcetonitrileMethylineChlorideFormamide Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAcetonitrileMethylineChlorideFormamideAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 32);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneSOAmmonia acid")]
        public void ThenISelectTheTouleneSOAmmoniaAcid()
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 35);
            sa._exposureUnit = ReadMixtureData.getdata(5, 35);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");

            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casSO2);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 36);
            sa._exposureUnit = ReadMixtureData.getdata(5, 36);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);

            _logger.Info("Clearing the Search Box");
            Clear();
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 37);
            sa._exposureUnit = ReadMixtureData.getdata(5, 37);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneSOAmmonia Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneSOAmmoniaAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 35);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneSOAmmonia Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneSOAmmoniaAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 35);
            sa._atmospPressure = ReadMixtureData.getdata(8, 35);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 35));
            sa._tempUnit = ReadMixtureData.getdata(10, 35);
            sa._workRate = ReadMixtureData.getdata(11, 35);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneSOAmmonia Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneSOAmmoniaAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 35);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneHexSO(.*)HF acid")]
        public void ThenISelectTheTouleneHexSOHFAcid(int p0)
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 38);
            sa._exposureUnit = ReadMixtureData.getdata(5, 38);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();

            //Select the Hexane Acid
            sa.SelectAcidRespirator(AcidCas._casHexane);
            _logger.Info("Sending the cas value as " + AcidCas._casHexane);
            //Set Exposure for Hexane
            sa._exposure = ReadMixtureData.getdata(4, 39);
            sa._exposureUnit = ReadMixtureData.getdata(5, 39);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");

            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 40);
            sa._exposureUnit = ReadMixtureData.getdata(5, 40);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting HF acid

            _logger.Info("Sending the cas value as " + AcidCas._casHF);
            //Select the HF Acid
            sa.SelectAcidRespirator(AcidCas._casHF);
            //Set Exposure for HF
            sa._exposure = ReadMixtureData.getdata(4, 41);
            sa._exposureUnit = ReadMixtureData.getdata(5, 41);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneHexSO(.*)HF Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneHexSOHFAcidMixture(int p0)
        {
            sa._cartidge = ReadMixtureData.getdata(6, 38);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneHexSO(.*)HF Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneHexSOHFAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 38);
            sa._atmospPressure = ReadMixtureData.getdata(8, 38);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 38));
            sa._tempUnit = ReadMixtureData.getdata(10, 38);
            sa._workRate = ReadMixtureData.getdata(11, 38);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneHexSO(.*)HF Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneHexSOHFAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 38);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneHexSO(.*)HF(.*) acid")]
        public void ThenISelectTheTouleneHexSOHFAcid(int p0, int p1)
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 42);
            sa._exposureUnit = ReadMixtureData.getdata(5, 42);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();

            //Select the Hexane Acid
            sa.SelectAcidRespirator(AcidCas._casHexane);
            _logger.Info("Sending the cas value as " + AcidCas._casHexane);
            //Set Exposure for Hexane
            sa._exposure = ReadMixtureData.getdata(4, 43);
            sa._exposureUnit = ReadMixtureData.getdata(5, 43);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");

            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 44);
            sa._exposureUnit = ReadMixtureData.getdata(5, 44);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting HF acid

            _logger.Info("Sending the cas value as " + AcidCas._casHF);
            //Select the HF Acid
            sa.SelectAcidRespirator(AcidCas._casHF);
            //Set Exposure for HF
            sa._exposure = ReadMixtureData.getdata(4, 45);
            sa._exposureUnit = ReadMixtureData.getdata(5, 45);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [When(@"After setting up the environment details for TouleneHexSO(.*)HF(.*) Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneHexSOHFAcidMixtureClickOnNextButtonToProceedFurther_(int p0, int p1)
        {
            sa._humidity = ReadMixtureData.getdata(7, 42);
            sa._atmospPressure = ReadMixtureData.getdata(8, 42);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 42));
            sa._tempUnit = ReadMixtureData.getdata(10, 42);
            sa._workRate = ReadMixtureData.getdata(11, 42);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneHexSO(.*)HF(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneHexSOHFAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0, int p1)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 42);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneHexAmmoniaMeth acid")]
        public void ThenISelectTheTouleneHexAmmoniaMethAcid()
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 46);
            sa._exposureUnit = ReadMixtureData.getdata(5, 46);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();

            //Select the Hexane Acid
            sa.SelectAcidRespirator(AcidCas._casHexane);
            _logger.Info("Sending the cas value as " + AcidCas._casHexane);
            //Set Exposure for Hexane
            sa._exposure = ReadMixtureData.getdata(4, 47);
            sa._exposureUnit = ReadMixtureData.getdata(5, 47);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");

            Clear();
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 48);
            sa._exposureUnit = ReadMixtureData.getdata(5, 48);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Methylamine acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 49);
            sa._exposureUnit = ReadMixtureData.getdata(5, 49);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneHexAmmoniaMeth Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneHexAmmoniaMethAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 46);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneHexAmmoniaMeth Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneHexAmmoniaMethAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 46);
            sa._atmospPressure = ReadMixtureData.getdata(8, 46);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 46));
            sa._tempUnit = ReadMixtureData.getdata(10, 46);
            sa._workRate = ReadMixtureData.getdata(11, 46);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneHexAmmoniaMeth Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneHexAmmoniaMethAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 46);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the SulphurHFAmmoniaMeth acid")]
        public void ThenISelectTheSulphurHFAmmoniaMethAcid()
        {
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            _logger.Info("Sending the cas value as " + AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 50);
            sa._exposureUnit = ReadMixtureData.getdata(5, 50);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();

            //Now selecting HF acid

            _logger.Info("Sending the cas value as " + AcidCas._casHF);
            //Select the HF Acid
            sa.SelectAcidRespirator(AcidCas._casHF);
            //Set Exposure for HF
            sa._exposure = ReadMixtureData.getdata(4, 51);
            sa._exposureUnit = ReadMixtureData.getdata(5, 51);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 52);
            sa._exposureUnit = ReadMixtureData.getdata(5, 52);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Methylamine acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 53);
            sa._exposureUnit = ReadMixtureData.getdata(5, 53);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for SulphurHFAmmoniaMeth Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForSulphurHFAmmoniaMethAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 50);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for SulphurHFAmmoniaMeth Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForSulphurHFAmmoniaMethAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 50);
            sa._atmospPressure = ReadMixtureData.getdata(8, 50);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 50));
            sa._tempUnit = ReadMixtureData.getdata(10, 50);
            sa._workRate = ReadMixtureData.getdata(11, 50);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for SulphurHFAmmoniaMeth Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForSulphurHFAmmoniaMethAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 50);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneAceticMEKXylene acid")]
        public void ThenISelectTheTouleneAceticMEKXyleneAcid()
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 54);
            sa._exposureUnit = ReadMixtureData.getdata(5, 54);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Acetic acid butyl ester acid

            _logger.Info("Sending the cas value as " + AcidCas._casAceticAcidEster);
            //Select the Acetic acid butyl ester Acid
            sa.SelectAcidRespirator(AcidCas._casAceticAcidEster);
            //Set Exposure for Acetic acid butyl ester
            sa._exposure = ReadMixtureData.getdata(4, 55);
            sa._exposureUnit = ReadMixtureData.getdata(5, 55);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
           
            Clear();
            //Now selecting MEK acid

            _logger.Info("Sending the cas value as " + AcidCas._casMEK);
            //Select the MEK Acid
            sa.SelectAcidRespirator(AcidCas._casMEK);
            //Set Exposure for MEK
            sa._exposure = ReadMixtureData.getdata(4, 56);
            sa._exposureUnit = ReadMixtureData.getdata(5, 56);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting Xylene acid

            _logger.Info("Sending the cas value as " + AcidCas._casXylene);
            //Select the Xylene Acid
            sa.SelectAcidRespirator(AcidCas._casXylene);
            //Set Exposure for Xylene
            sa._exposure = ReadMixtureData.getdata(4, 57);
            sa._exposureUnit = ReadMixtureData.getdata(5, 57);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneAceticMEKXylene Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneAceticMEKXyleneAcidMixture()
        {
            sa._cartidge = ReadMixtureData.getdata(6, 54);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneAceticMEKXylene Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneAceticMEKXyleneAcidMixtureClickOnNextButtonToProceedFurther_()
        {
            sa._humidity = ReadMixtureData.getdata(7, 54);
            sa._atmospPressure = ReadMixtureData.getdata(8, 54);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 54));
            sa._tempUnit = ReadMixtureData.getdata(10, 54);
            sa._workRate = ReadMixtureData.getdata(11, 54);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneAceticMEKXylene Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneAceticMEKXyleneAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_()
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 54);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneAceticMEKXylene(.*) acid")]
        public void ThenISelectTheTouleneAceticMEKXyleneAcid(int p0)
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 58);
            sa._exposureUnit = ReadMixtureData.getdata(5, 58);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Acetic acid butyl ester acid

            _logger.Info("Sending the cas value as " + AcidCas._casAceticAcidEster);
            //Select the Acetic acid butyl ester Acid
            sa.SelectAcidRespirator(AcidCas._casAceticAcidEster);
            //Set Exposure for Acetic acid butyl ester
            sa._exposure = ReadMixtureData.getdata(4, 59);
            sa._exposureUnit = ReadMixtureData.getdata(5, 59);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            
            Clear();
            //Now selecting MEK acid

            _logger.Info("Sending the cas value as " + AcidCas._casMEK);
            //Select the MEK Acid
            sa.SelectAcidRespirator(AcidCas._casMEK);
            //Set Exposure for MEK
            sa._exposure = ReadMixtureData.getdata(4, 60);
            sa._exposureUnit = ReadMixtureData.getdata(5, 60);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting Xylene acid

            _logger.Info("Sending the cas value as " + AcidCas._casXylene);
            //Select the Xylene Acid
            sa.SelectAcidRespirator(AcidCas._casXylene);
            //Set Exposure for Xylene
            sa._exposure = ReadMixtureData.getdata(4, 61);
            sa._exposureUnit = ReadMixtureData.getdata(5, 61);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [When(@"After setting up the environment details for TouleneAceticMEKXylene(.*) Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneAceticMEKXyleneAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 58);
            sa._atmospPressure = ReadMixtureData.getdata(8, 58);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 58));
            sa._tempUnit = ReadMixtureData.getdata(10, 58);
            sa._workRate = ReadMixtureData.getdata(11, 58);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneAceticMEKXylene(.*) Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneAceticMEKXyleneAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 58);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the AmmoniaHFHSSO(.*)Methy acid")]
        public void ThenISelectTheAmmoniaHFHSSOMethyAcid(int p0)
        {
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 62);
            sa._exposureUnit = ReadMixtureData.getdata(5, 62);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();

            //Now selecting HF acid

            _logger.Info("Sending the cas value as " + AcidCas._casHF);
            //Select the HF Acid
            sa.SelectAcidRespirator(AcidCas._casHF);
            //Set Exposure for HF
            sa._exposure = ReadMixtureData.getdata(4, 63);
            sa._exposureUnit = ReadMixtureData.getdata(5, 63);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting HS acid

            _logger.Info("Sending the cas value as " + AcidCas._casHS);
            //Select the HS Acid
            sa.SelectAcidRespirator(AcidCas._casHS);
            //Set Exposure for HS
            sa._exposure = ReadMixtureData.getdata(4, 64);
            sa._exposureUnit = ReadMixtureData.getdata(5, 64);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting SO2 acid

            _logger.Info("Sending the cas value as " + AcidCas._casSO2);
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 65);
            sa._exposureUnit = ReadMixtureData.getdata(5, 65);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Now selecting Methylamine acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 66);
            sa._exposureUnit = ReadMixtureData.getdata(5, 66);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for AmmoniaHFHSSO(.*)Methy Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForAmmoniaHFHSSOMethyAcidMixture(int p0)
        {
            sa._cartidge = ReadMixtureData.getdata(6, 62);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for AmmoniaHFHSSO(.*)Methy Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForAmmoniaHFHSSOMethyAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 62);
            sa._atmospPressure = ReadMixtureData.getdata(8, 62);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 62));
            sa._tempUnit = ReadMixtureData.getdata(10, 62);
            sa._workRate = ReadMixtureData.getdata(11, 62);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for AmmoniaHFHSSO(.*)Methy Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForAmmoniaHFHSSOMethyAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 62);
            sa.VerifyHours(sa._expectedHours);
        }

        [Then(@"I select the TouleneHexaneSO(.*)HFAmmoniaMethylamine acid")]
        public void ThenISelectTheTouleneHexaneSOHFAmmoniaMethylamineAcid(int p0)
        {
            //Select the Toulene Acid
            sa.SelectAcidRespirator(AcidCas._casToulene);
            _logger.Info("Sending the cas value as " + AcidCas._casToulene);
            //Set Exposure for Toulene
            sa._exposure = ReadMixtureData.getdata(4, 67);
            sa._exposureUnit = ReadMixtureData.getdata(5, 67);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Hexane acid
            _logger.Info("Sending the cas value as " + AcidCas._casHexane);
            //Select the Hexane Acid
            sa.SelectAcidRespirator(AcidCas._casHexane);
            //Set Exposure for Hexane
            sa._exposure = ReadMixtureData.getdata(4, 68);
            sa._exposureUnit = ReadMixtureData.getdata(5, 68);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            Clear();
            //Select the SO2 Acid
            sa.SelectAcidRespirator(AcidCas._casSO2);
            _logger.Info("Sending the cas value as " + AcidCas._casSO2);
            //Set Exposure for SO2
            sa._exposure = ReadMixtureData.getdata(4, 69);
            sa._exposureUnit = ReadMixtureData.getdata(5, 69);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting HF acid
            _logger.Info("Sending the cas value as " + AcidCas._casHF);
            //Select the Hexane Acid
            sa.SelectAcidRespirator(AcidCas._casHF);
            //Set Exposure for Hexane
            sa._exposure = ReadMixtureData.getdata(4, 70);
            sa._exposureUnit = ReadMixtureData.getdata(5, 70);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Select the Ammonia Acid
            sa.SelectAcidRespirator(AcidCas._casAmmonia);
            _logger.Info("Sending the cas value as " + AcidCas._casAmmonia);
            //Set Exposure for Ammonia
            sa._exposure = ReadMixtureData.getdata(4, 71);
            sa._exposureUnit = ReadMixtureData.getdata(5, 71);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            _logger.Info("Clearing the Search Box");
            Clear();
            //Now selecting Methylamine acid

            _logger.Info("Sending the cas value as " + AcidCas._casMethylamine);
            //Select the Methylamine Acid
            sa.SelectAcidRespirator(AcidCas._casMethylamine);
            //Set Exposure for Methylamine
            sa._exposure = ReadMixtureData.getdata(4, 72);
            sa._exposureUnit = ReadMixtureData.getdata(5, 72);
            _logger.Info("Setting the Exposure and Exposure Unit as " + sa._exposure + " " + sa._exposureUnit);
            MixtureUtility.SetExposure(sa._exposure, sa._exposureUnit);
            ExplicitWait.WaitForAnElement(XpathContainer.selected);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.selected)).Click();
        }

        [Then(@"I filter the required cartidge/filter using the cartidge value for TouleneHexaneSO(.*)HFAmmoniaMethylamine Acid Mixture")]
        public void ThenIFilterTheRequiredCartidgeFilterUsingTheCartidgeValueForTouleneHexaneSOHFAmmoniaMethylamineAcidMixture(int p0)
        {
            sa._cartidge = ReadMixtureData.getdata(6, 67);
            sa.SelectTheCartidgeorFilter(sa._cartidge);
            ExplicitWait.WaitForAnElement(XpathContainer.SelCon);
            Pause.Waiting();
        }

        [When(@"After setting up the environment details for TouleneHexaneSO(.*)HFAmmoniaMethylamine Acid Mixture click on next button to proceed further\.")]
        public void WhenAfterSettingUpTheEnvironmentDetailsForTouleneHexaneSOHFAmmoniaMethylamineAcidMixtureClickOnNextButtonToProceedFurther_(int p0)
        {
            sa._humidity = ReadMixtureData.getdata(7, 67);
            sa._atmospPressure = ReadMixtureData.getdata(8, 67);
            sa._temperatureature = int.Parse(ReadMixtureData.getdata(9, 67));
            sa._tempUnit = ReadMixtureData.getdata(10, 67);
            sa._workRate = ReadMixtureData.getdata(11, 67);
            sa.SetAtmosphericData(sa._humidity, sa._atmospPressure, sa._temperatureature, sa._tempUnit, sa._workRate);
            _logger.Info("Setting up the humidity, atmospheric pressure, temperature, temperature unit , work rate as " + sa._humidity + " " + sa._atmospPressure + " " + sa._temperatureature + " " + sa._tempUnit + " " + sa._workRate);
            _logger.Info("Clicking on next button after setting up the environment details");
            ExplicitWait.WaitForAnElement(XpathContainer.nextfinal);
            BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.nextfinal)).Click();
        }

        [Then(@"Verify the Service Life Estimate for TouleneHexaneSO(.*)HFAmmoniaMethylamine Acid Mixture and then click on Done button to complete the verification process\.")]
        public void ThenVerifyTheServiceLifeEstimateForTouleneHexaneSOHFAmmoniaMethylamineAcidMixtureAndThenClickOnDoneButtonToCompleteTheVerificationProcess_(int p0)
        {
            sa._expectedHours = ReadMixtureData.getdata(12, 67);
            sa.VerifyHours(sa._expectedHours);
        }

        
        public void Clear()
        {
            Actions action = new Actions(BrowserConfig.webDriver);
            action.Click(BrowserConfig.webDriver.FindElement(By.XPath(XpathContainer.CASBox)))
               .KeyDown(Keys.Control)
               .SendKeys("a")
               .KeyUp(Keys.Control)
               .SendKeys(Keys.Backspace)
               .Build()
               .Perform();
        }
       
        
    }
}
