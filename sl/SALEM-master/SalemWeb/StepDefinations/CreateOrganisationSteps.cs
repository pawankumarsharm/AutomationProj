using NUnit.Framework;
using OpenQA.Selenium;
using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SalemWeb.StepDefinations
{
    /// <summary>
    /// Create Org DashBoard with the below parameters.
    /// <p1> </p1>
    /// <p2> </p2>
    /// <p3> </p3>
    /// 
    /// </summary>
    [Binding]
    public class CreateOrganisationSteps
    {
        [When(@"Redirected to the CreateOrganistion dashboard, fill the necessary details such as (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public void WhenRedirectedToTheCreateOrganistionDashboardFillTheNecessaryDetailsSuchAs(string _orgName, string _fname, string _country, string _lname, string _state, string _email, string _city, string _contactNo, string _bussinesUnit, string _accType, string _field, string _status)
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._orgDetailsTxtId);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._orgnewNameId)).SendKeys(_orgName);

            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgFnameId)).SendKeys(_fname);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgLnameId)).SendKeys(_lname);
            
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgEmailId)).Clear();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgEmailId)).SendKeys(_email);
          
            SupportingFunctions.selectCountry(_country, ObjectIdentifiers._createOrgCountryId);
            SupportingFunctions.scrollToElement(ObjectIdentifiers._createOrgCreateBtnId);
           
            SupportingFunctions.selectState(_state, ObjectIdentifiers._createOrgStateId);
           
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgCityId)).Clear();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgCityId)).SendKeys(_city);
            //Enter Admin Contact Number
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgContactId)).Clear();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgContactId)).SendKeys(_contactNo);
            //Select Bussiness Unit
            SupportingFunctions.selectBussinessUnit(_bussinesUnit, ObjectIdentifiers._createOrgBUId);
            //Select Account Type
            SupportingFunctions.selectAccountType(_accType, ObjectIdentifiers._createOrgATId);
            //Select Field
            SupportingFunctions.selectField(_field, ObjectIdentifiers._createOrgFieldId);
            //Select Status
            SupportingFunctions.selectStatus(_status, ObjectIdentifiers._createOrgStatusId);
        }

       
        [Then(@"Click on the Organisations link to redirect to Organisation DashBoard\.")]
        public void ThenClickOnTheOrganisationsLinkToRedirectToOrganisationDashBoard_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._orgLinkId)).Click();
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._createOrgBtn);
            bool _exists = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgBtn)).Displayed;
            if (_exists)
            {
                Console.WriteLine("Successfully redirected to Organisation Create Page.");
            }
            else
            {
                Assert.Fail("Oops... something went wrong. Unable to redirect to Create New Organisation page.");
            }
        }

        /// <summary>
        /// OnDashBoard,CreateNewOrganisation button to proceed with the new organisation creati
        /// </summary>
        [Then(@"In the Organisation Dashboard, tap on the CreateNewOrganisation button to proceed with the new organisation creation\.")]
        public void ThenInTheOrganisationDashboardTapOnTheCreateNewOrganisationButtonToProceedWithTheNewOrganisationCreation_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgBtn)).Click();
        }

        /// <summary>
        /// Click on create button to validate the Org creation.
        /// </summary>
        [Then(@"Click on Create button to complete with the Organisation creation\.")]
        public void ThenClickOnCreateButtonToCompleteWithTheOrganisationCreation_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createOrgCreateBtnId)).Click();
        }

        /// <summary>
        /// Verification of new Org creation.
        /// </summary>
        [Then(@"Verify that new Organisation is created successfully or not\.")]
        public void ThenVerifyThatNewOrganisationIsCreatedSuccessfullyOrNot_()
        {
            
            bool _eleDisplayed = false;
            string _toastMsg = "";
            try
            {
                _toastMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastOrgCreatedId)).Text;
                _eleDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastOrgCreatedId)).Displayed;
                if (_eleDisplayed)
                {
                    Assert.AreEqual(_toastMsg, "Organization created.");
                }
                else
                {
                    Assert.Fail("Unable to create new Organisation.");
                }
            }
            catch
            {
                string _toastMsgExists = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastOrgAlreadyExist)).Text;
                ExplicitWaiting.waitForTime(5000);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signout)).Click();
                Exception _cusExcept = new Exception(_toastMsgExists);
                throw _cusExcept;
            }


        }
        [Then(@"Click on Cancel Button and verify if Organization creation is canceled successfully\.")]
        public void ThenClickOnCancelButtonAndVerifyIfOrganizationCreationIsCanceledSuccessfully_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastOrgCancelBtn)).Click();
        }
        [Then(@"Verify that no new Organisation is created successfully or not\.")]
        public void ThenVerifyThatNoNewOrganisationIsCreatedSuccessfullyOrNot_()
        {
            bool _elem = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastOrgCreateErr)).Displayed;
            if (_elem)
            {
                Console.WriteLine("Required fields missing...");
            }
            else
            {
                Assert.Fail("Created org without entering any value");
            }
        }

        [Then(@"click on logout button\.")]
        public void ThenClickOnLogoutButton_()
        {
            ExplicitWaiting.waitForTime(5000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signout)).Click();
            ExplicitWaiting.waitForTime(3000);

        }

    }
}
