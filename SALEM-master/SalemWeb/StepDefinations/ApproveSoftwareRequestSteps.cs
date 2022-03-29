using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SalemWeb.StepDefinations
{
    [Binding]
    public class ApproveSoftwareRequestSteps
    {
        [Given(@"Navigate to url\.")]
        public void GivenNavigateToUrl_()
        {
            BrowserConfig.Init();
        }



        [Then(@"Click on Sign In button to proceed with approving software request\.")]
        public void ThenClickOnSignInButtonToProceedWithApprovingSoftwareRequest_()
        {
            try
            {
                
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signinbtn)).Click();
            }
           
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
           
        }


        [Then(@"After landing on sign in page\. Enter email (.*) and (.*)")]
        public void ThenAfterLandingOnSignInPage_EnterEmailAnd(string email, string password)
        {
            try
            {
                ExplicitWaiting.waitForAnElement(ObjectIdentifiers._loginbtn);

                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._email)).SendKeys(email);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._password)).SendKeys(password);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
        [Then(@"Click on Sign in button\.")]
        public void ThenClickOnSignInButton_()
        {
            try
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loginbtn)).Click();
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }

        }
          
    
        
        //[Then(@"select organisation (.*) from dropdown menu and click on Continue button\.")]
        //public void ThenSelectOrganisationFromDropdownMenuAndClickOnContinueButton_(string organisation)
        //{
        //    try
        //    {
        //        Function.selectOrganisation(organisation);
        //        BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._continueBtn)).Click();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Error");
        //    }
        //}
        [Then(@"click on Organisation (.*) from dropdown menu and click on Continue button")]
        public void ThenClickOnOrganisationFromDropdownMenuAndClickOnContinueButton(string organisation)
        {
            try
            {
                Function.selectOrganisation(organisation);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._continueBtn)).Click();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        [When(@"After landing  on website page, click on unapproved request button\.")]
        public void WhenAfterLandingOnWebsitePageClickOnUnapprovedRequestButton_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._softwareBtnIdentifier);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._unapprovedReq)).Click();
        }
        [When(@"Enter organistaion name (.*) in search box, Click on unapproved button\.")]
        public void WhenEnterOrganistaionNameInSearchBoxClickOnUnapprovedButton_(string org)
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchBox)).SendKeys(org);
            IWebElement _errMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._noRecord));
            if (_errMsg.Text == "No matching records found")
            {
               Assert.Fail("No such Unapproved request");
            }
            else
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._unapproveBtn)).Click();
            }
        }
        [Then(@"Click on Approve button to approved software request\.")]
        public void ThenClickOnApproveButtonToApprovedSoftwareRequest_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._approveBtn)).Click();
        }
        [Then(@"Click on Create Button\.")]
        public void ThenClickOnCreateButton_()
        {
            IJavaScriptExecutor jd = (IJavaScriptExecutor)BrowserConfig._driver;
            jd.ExecuteScript("window.scrollBy(0,250)", "");
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createBtn)).Click();
        }
        [Then(@"After landing on new organistaion page, click on Create Button")]
        public void ThenAfterLandingOnNewOrganistaionPageClickOnCreateButton()
        {
            ExplicitWaiting.waitForTime(3000);
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._createBtnLast);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._createBtnLast)).Click();
        }
       
        [Then(@"Verify against success message\.")]
        public void ThenVerifyAgainstSuccessMessage_()
        {
            ExplicitWaiting.waitForTime(2000);
            bool _toastMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastMsg)).Displayed;
            if (!_toastMsg)
            {
                Assert.Fail("request not approved");
            }
        }


        [Given(@"user clicks on url and navigates to sign in button\.")]
        public void GivenUserClicksOnUrlAndNavigatesToSignInButton_()
        {
            BrowserConfig.Init();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signinbtn)).Click();
        }
        [When(@"user enters email(.*) and password (.*)\.")]
        public void WhenUserEntersEmailAndPassword_(string email, string password)
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._email)).SendKeys(email);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._password)).SendKeys(password);
        }

        [Then(@"user sign in\.")]
        public void ThenUserSignIn_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loginbtn)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._organisationBtnIdentifier));
        }

        [Then(@"Click on merge Button")]
        public void ThenClickOnMergeButton()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeBtn)).Click();
            Console.WriteLine("hi");
            IWebElement element = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeNotification));
            Function.elementVisible(element);
        }

        
        [Then(@"enter in search box organistaion (.*), click search button\.")]
        public void ThenEnterInSearchBoxOrganistaionClickSearchButton_(string Orgtomerge)
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeSearchBox)).SendKeys(Orgtomerge);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeSearchBtn)).Click();
            IWebElement searchElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeSearchIdentifier));
            Function.elementVisible(searchElement);
        }
        [Then(@"Select organisation name\. Click on approve button and then merge button\.")]
        public void ThenSelectOrganisationName_ClickOnApproveButtonAndThenMergeButton_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._selectOrgToMerge)).Click();
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._approveBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._approveBtn)).Click();
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeBtn)).Click();
        }

        [Then(@"click on save button and select role(.*)from dropdown\.")]
        public void ThenClickOnSaveButtonAndSelectRolefromDropdown_(string role)
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveBtn)).Click();
            Function.selectRole(role);
        }
        [Then(@"verify merge sucess\.")]
        public void ThenVerifyMergeSucess_()
        {
            ExplicitWaiting.waitForTime(2000);
            bool _mergeMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mergeSuccessMsg)).Displayed;
            if (!_mergeMsg)
            {
                Assert.Fail("request not approved");
            }
        }


        [Then(@"click on reject button, and click on yes button\.")]
        public void ThenClickOnRejectButtonAndClickOnYesButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._rejectBtn)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._rejectMailYesBtn)).Click();
        }

        [Then(@"Verify Rejection")]
        public void ThenVerifyRejection()
        {

            ExplicitWaiting.waitForTime(2000);
            bool _rejectMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._rejectToastMsg)).Displayed;
            if (!_rejectMsg)
            {
                Assert.Fail(" not rejected");
            }
        }



    }



}
