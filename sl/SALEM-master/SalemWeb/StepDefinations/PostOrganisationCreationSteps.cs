using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SalemWeb.StepDefinations
{
    [Binding]
    class PostOrganisationCreationSteps
    {
       int rowcount; 
        [When(@"After landing on website, click on organisation button\.")]
        public void WhenAfterLandingOnWebsiteClickOnOrganisationButton_()
        {

            ExplicitWaiting.waitForTime(5000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._organisationBtn)).Click();
        }
        [When(@"enter organisation name (.*) in searchbox\.")]
        public void WhenEnterOrganisationNameInSearchbox_(string orgname)
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._orgSearchBox)).SendKeys(orgname);
            IWebElement _errMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._noRecordPostOrg));
            if (_errMsg.Text == "No matching records found")
            {
                Assert.Fail("Organisation not present.");
            }
            else
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._orgNameIdentifier)).Click();
            }
        }



        [When(@"Click on add user button\.")]
        public void WhenClickOnAddUserButton_()
        {

            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._addUserBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._addUserBtn)).Click();
        }

        [Then(@"After landing on user page, select user role (.*) , enter firstname (.*), lastname (.*), emailid(.*), contact number(.*)\.")]
        public void ThenAfterLandingOnUserPageSelectUserRoleEnterFirstnameLastnameEmailidContactNumber_(string role, string fname, string lname, string emailid, string num)
        {
            ExplicitWaiting.waitForTime(3000);
            Function.selectRoleAs(role);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userFirstName)).SendKeys(fname);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userLastName)).SendKeys(lname);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userEmail)).SendKeys(emailid);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userContactNum)).SendKeys(num);
        }

        [Then(@"Click on Create Button to create new user for an organisation and specify all string (.*)")]
        public void ThenClickOnCreateButtonToCreateNewUserForAnOrganisationAndSpecifyAllString(string role)
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userCreateBtn)).Click();
            IList<IWebElement> elements = BrowserConfig._driver.FindElements(By.XPath(ObjectIdentifiers._roleString));
            foreach (IWebElement element in elements)
            {
                element.Click();
                Function.selectRoleFor(role);
            }
        }

        [Then(@"Click on delete\.")]
        public void ThenClickOnDelete_()
        {
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._deleteOrgBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteOrgBtn)).Click();
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._deleteOrgConfirmBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteOrgConfirmBtn)).Click();
        }
  
        [Then(@"click on email")]
        public void ThenClickOnEmail()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mailSend)).Click();
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._mailSendConfirmBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mailSendConfirmBtn)).Click();
        }

        [When(@"after landing on website, click on user button\.")]
        public void WhenAfterLandingOnWebsiteClickOnUserButton_()
        {
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._userBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userBtn)).Click();
        }
        [When(@"enter user name (.*) in searchbox")]
        public void WhenEnterUserNameInSearchbox(string p0)
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._userSearchBox);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userSearchBox)).SendKeys(p0);
            IWebElement _errMsg3 = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._noUserPostOrg));
            if (_errMsg3.Text == "No matching records found")
            {
                Assert.Fail("No such user exsists.");
            }
            else
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userNameBtn)).Click();
            }
        }


        [Then(@"select user role , Business Unit and Organisation from dropdownmenu\.")]
        public void ThenSelectUserRoleBusinessUnitAndOrganisationFromDropdownmenu_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._addRoleBtn)).Click();
           
            Function.chooseRole();
         
            Function.chooseBusinessUnit();
          
            Function.chooseOrganisation();
        }

        [Then(@"click on add role button\.")]
        public void ThenClickOnAddRoleButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._addUserRoleBtn)).Click();

        }

     
        [When(@"scroll down to remove role button\.")]
        public void WhenScrollDownToRemoveRoleButton_()
        {

            IJavaScriptExecutor jd = (IJavaScriptExecutor)BrowserConfig._driver;
            jd.ExecuteScript("window.scrollBy(0,250)", "");
        }

     

        [Then(@"Click on confirm button to remove role\.")]
        public void ThenClickOnConfirmButtonToRemoveRole_()
        {
            ExplicitWaiting.waitForTime(2000);
          ScenarioContext.Current["rowcount"] = BrowserConfig._driver.FindElements(By.XPath(ObjectIdentifiers._table)).Count;
            var rowV = (int)ScenarioContext.Current["rowcount"];
            if (rowV == 1)
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeRoleBtn)).Click();
                ExplicitWaiting.waitForTime(3000);

                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeRoleConfirmBtn)).Click();
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._confirmDeleteRoleButton)).Click();
            }
            else
            {
                ExplicitWaiting.waitForTime(3000);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeRoleButton2)).Click();
                ExplicitWaiting.waitForTime(3000);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeRoleConfirmBtn)).Click();
            }
        }
        
        [Then(@"click on edit button to edit user\.")]
        public void ThenClickOnEditButtonToEditUser_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._editUserBtn)).Click();
        }
      
        [Then(@"click save\.")]
        public void ThenClickSave_()
        { 
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._editSaveBtn)).Click();
        }


        [Then(@"verify user creation\.")]
        public void ThenVerifyUserCreation_()
        {
           
            IWebElement _errMsg2 = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userCreationSucessMsg));
            if (_errMsg2.Text == "The user name already exists.")
            {
                Assert.Fail("user already exsists.");
            }
            else if(!_errMsg2.Displayed)
            {
                Assert.Fail("user cannot be created");
            }

        }
        [Then(@"Verify deletion of user\.")]
        public void ThenVerifyDeletionOfUser_()
        {
            bool _deleteMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteOrgSucessMsg)).Displayed;
            if (!_deleteMsg)
            {
                Assert.Fail("deletion failed");
            }
        }
       
        [Then(@"verify email sent\.")]
        public void ThenVerifyEmailSent_()
        {
            ExplicitWaiting.waitForTime(3000);
            bool _emailMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userMailSucessMsg)).Displayed;
            if (!_emailMsg)
            {
                Assert.Fail("email not  sent");
            }
        }
    

        [Then(@"verify user edit")]
        public void ThenVerifyUserEdit()
        {
            ExplicitWaiting.waitForTime(2000);
            bool _userEditMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userEditSucessMsg)).Displayed;
            if (!_userEditMsg)
            {
                Assert.Fail("user edit failed");
            }
        }
        [Then(@"Verify role addition")]
        public void ThenVerifyRoleAddition()
        {
            
            IWebElement _userRoleAddMsg = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._addRoleSucessMsg));
            if (_userRoleAddMsg.Text == "User already exists")
            {
                Assert.Fail("user already exsists.");
            }
            else if (_userRoleAddMsg.Displayed)
            {
                Assert.Fail("user role addition failed.");
            }
        }
        [Then(@"verify removal of role\.")]
        public void ThenVerifyRemovalOfRole_()
        {
           
            ExplicitWaiting.waitForTime(2000);
            Console.WriteLine((int)ScenarioContext.Current["rowcount"]);
            if (!((int)ScenarioContext.Current["rowcount"] == 1))
            {
                if (!((BrowserConfig._driver.FindElements(By.XPath(ObjectIdentifiers._table)).Count) == ((int)ScenarioContext.Current["rowcount"] - 1)))
                {
                    Assert.Fail("role removal failed");
                }
            }
            else
            {
                Console.WriteLine("user role cannot be removed");
            }
            
        }


    }


}


