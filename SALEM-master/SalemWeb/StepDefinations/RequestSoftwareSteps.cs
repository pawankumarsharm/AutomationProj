

using OpenQA.Selenium;
using SalemWeb.Bindings;
using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace SalemWeb.StepDefinations
{
    [Binding]
    public class RequestSoftwareSteps
    {
        public static string _sftwrDwnldPortalUrl = "https://download-qa.3m.com/Home/ViewSoftwareAno";
        public static readonly string _email = ConfigurationManager.AppSettings.Get("email");
        public static readonly string _password = ConfigurationManager.AppSettings.Get("password");
        public static readonly string _createOrgUrl = "https://download-qa.3m.com/Organizations/CreateOrganizationAsync";
        public static string _urlForOrgPortal = "https://download-qa.3m.com/Organizations/ViewOrganizationDetailsAsync?organizationId";
        [Given(@"I have a valid url and navigated to the url\.")]
        public void GivenIHaveAValidUrlAndNavigatedToTheUrl_()
        {

            BrowserConfig.Init();
        }

       

        [Then(@"Click on Show Software button to proceed with requesting of requried software\.")]
        public void ThenClickOnShowSoftwareButtonToProceedWithRequestingOfRequriedSoftware_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Equals(_sftwrDwnldPortalUrl))
            {
                Console.WriteLine("Already in the 3M Software Download Portal.");
            }
            else if (_currentUrl.Equals(BrowserConfig._baseUrl))
            {
                if (BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._landingpage)).Displayed)
                {
                    //BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._showsoftwarebtn)).Click();
                }
                else
                {
                    Console.WriteLine("Oops... Something went wrong.");
                }
            }
        }

        [Then(@"Set the Filter to the required platform Desktop/Mobile (.*) as per requirement\.")]
        public void ThenSetTheFilterToTheRequiredPlatformDesktopMobileAsPerRequirement_(string _platform)
        {
            SupportingFunctions.selectPlatform(_platform);
        }

        [Then(@"Click on the See Details button for the required software (.*) to proceed further\.")]
        public void ThenClickOnTheSeeDetailsButtonForTheRequiredSoftwareToProceedFurther_(string _software)
        {
            SupportingFunctions.selectSoftware(_software);
        }
         [When(@"Landed to Software page click on Request button to proceed further\.")]
        public void WhenLandedToSoftwarePageClickOnRequestButtonToProceedFurther_()
        {
            SupportingFunctions.Request();
        }

        [When(@"Enter your Email (.*) and click on verify button\.")]
        public void WhenEnterYourEmailAndClickOnVerifyButton_(string _email)
        {
            SupportingFunctions.verifyEmail(_email);
            BrowserConfig._driver.FindElements(By.XPath(ObjectIdentifiers._veriftBtnIdentifier));
        }
        [Then(@"Enter your details such as First Name (.*),Last Name (.*),Organization Name (.*),Country (.*),State(.*) and City(.*)\.")]
        public void ThenEnterYourDetailsSuchAsFirstNameLastNameOrganizationNameCountryStateAndCity_(string _fname, string _lname, string _OrgName, string _country, string _state, string _city)
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._registerBtnIdentifier);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._firstnameId)).SendKeys(_fname);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._lastnameId)).SendKeys(_lname);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._orgNameId)).SendKeys(_OrgName);
            SupportingFunctions.selectCountry(_country, ObjectIdentifiers._countryId);
            SupportingFunctions.selectState(_state, ObjectIdentifiers._stateId);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._cityId)).SendKeys(_city);
        }

        [Then(@"Click on Register Button\.")]
        public void ThenClickOnRegisterButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._registerBtnIdentifier)).Click();
        }
        [Then(@"I click on the Sign In button to go to User Sign In portal\.")]
        public void ThenIClickOnTheSignInButtonToGoToUserSignInPortal_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Contains(_urlForOrgPortal) || _currentUrl.Contains(_createOrgUrl))
            {
                Console.WriteLine("In Organization Portal only.");
            }
            else
            {
                ExplicitWaiting.waitForAnElement(ObjectIdentifiers._signinbtn);
                bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signinbtn)).Displayed;
                if (_isDisplayed)
                {
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signinbtn)).Click();
                }
            }
        }
        [When(@"Redirected to the login portal, enter your valid username and password\.")]
        public void WhenRedirectedToTheLoginPortalEnterYourValidUsernameAndPassword_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Contains(_urlForOrgPortal) || _currentUrl.Contains(_createOrgUrl))
            {
                Console.WriteLine("In Organization Portal only.");
            }
            else
            {
                ExplicitWaiting.waitForAnElement(ObjectIdentifiers._btnSignIn);
                bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnSignIn)).Displayed;
                if (_isDisplayed)
                {
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._email)).SendKeys(_email);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._password)).SendKeys(_password);
                }
            }
        }

        [When(@"Click on Sign In button to proceed further\.")]
        public void WhenClickOnSignInButtonToProceedFurther_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Contains(_urlForOrgPortal) || _currentUrl.Contains(_createOrgUrl))
            {
                Console.WriteLine("In Organization Portal only.");
            }
            else
            {
                ExplicitWaiting.waitForAnElement(ObjectIdentifiers._btnSignIn);
                bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnSignIn)).Displayed;
                if (_isDisplayed)
                {
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnSignIn)).Click();
                }
            }
        }
        [Then(@"Verify if Login is successfull\.")]
        public void ThenVerifyIfLoginIsSuccessfull_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Contains(_urlForOrgPortal) || _currentUrl.Contains(_createOrgUrl))
            {
                Console.WriteLine("In Organization Portal only.");
            }
            else
            {
                ExplicitWaiting.waitForAnElement(ObjectIdentifiers._loginContinueBtn);
                bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loginContinueBtn)).Displayed;
                if (_isDisplayed)
                {
                    Console.WriteLine("Login is Successfull");
                }
                else
                {
                    Console.WriteLine("Some error occured..please try again later.");
                }
            }
        }
        [When(@"Redirected to the login portal, enter an invalid username and password\.")]
        public void WhenRedirectedToTheLoginPortalEnterAnInvalidUsernameAndPassword_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._btnSignIn);
            bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnSignIn)).Displayed;
            if (_isDisplayed)
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._email)).SendKeys("kverma@mmm.com");
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._password)).SendKeys("Nathcorp!1");
            }
        }

        [Then(@"Verify if Login is not successfull\.")]
        public void ThenVerifyIfLoginIsNotSuccessfull_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._loginErrAlert);
            bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loginErrAlert)).Displayed;
            if (_isDisplayed)
            {
                Console.WriteLine("Login is Un-Successfull");
            }
            else
            {
                Console.WriteLine("Login is successfull.");
            }
        }
        
        [Then(@"Select the users organistion\.")]
        public void ThenSelectTheUsersOrganistion_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Contains(_urlForOrgPortal) || _currentUrl.Contains(_createOrgUrl))
            {
                Console.WriteLine("In Organization Portal only.");
            }
            else
            {
                ExplicitWaiting.waitForAnElement(ObjectIdentifiers._orgDropdown);
                SupportingFunctions.selectOrg("3M Internal Group");
            }
        }
        [Then(@"Click on continue button to finish with the login process\.")]
        public void ThenClickOnContinueButtonToFinishWithTheLoginProcess_()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_currentUrl.Contains(_urlForOrgPortal) || _currentUrl.Contains(_createOrgUrl))
            {
                Console.WriteLine("In Organization Portal only.");
            }
            else
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._continuebtn)).Click();
                ExplicitWaiting.waitForTime(5000);
            }
        }

    }
}


