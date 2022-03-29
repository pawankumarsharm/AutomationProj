using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SalemQA.Repo;
using SalemQA.Utility;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace SalemQA.StepDefinations
{
    [Binding]
    public class OrgAdminAccessiblitySteps:BrowserConfig
    {
        [Given(@"User navigates to the Salem Home Page\.")]
        public void GivenUserNavigatesToTheSalemHomePage_()
        {
            Console.WriteLine(_driver.Url);
        }

        

        [Then(@"In the Home Page, Click on the Login Link and enter the (.*) and (.*) to login with OrgAdmin account\.")]
        public void ThenInTheHomePageClickOnTheLoginLinkAndEnterTheAndToLoginWithOrgAdminAccount_(string usrname, string password)
        {
            Home h = new Home(_driver);
            var wait = new WebDriverWait(BrowserConfig._driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//li[@class='MMM--utilityLinks MMM--isOnDesktop MMM--desktopUtilLinks']")));

            h.Login().Click();
            Thread.Sleep(5000);
            Login l = new Login(_driver);
            l.Email().SendKeys(usrname);
            l.Password().SendKeys(password);
            l.LogIn().Click();
        }
        [When(@"Logged in verify if able to add users\.")]
        public void WhenLoggedInVerifyIfAbleToAddUsers_()
        {
            Home h = new Home(_driver);
            if(h.AddUser().Displayed)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Assert.Fail("Add user functionality not available");
            }
        }
        [Then(@"Verify if user is able to download the assigned software\.")]
        public void ThenVerifyIfUserIsAbleToDownloadTheAssignedSoftware_()
        {
            Home h = new Home(_driver);
            h.SoftwareSection().Click();
            var element = h.SoftwarePObtained();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element);
            actions.Perform();
            int count = h.AvailabeForDownload().Count;
            if(count>0)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Assert.Fail("No software available for download.");
            }
        }
        [Then(@"Verify if user is able to request the unassigned software\.")]
        public void ThenVerifyIfUserIsAbleToRequestTheUnassignedSoftware_()
        {
            software s = new software(_driver);
            String reqURL = "https://download-qa.3m.com/Software/ViewSoftwareOrgAdmin";
            if((_driver.Url).Equals(reqURL))
            {
                ///
                
                s.SeeDetailsBtn().Click();
                if(s.Request().Displayed)
                {
                    Console.WriteLine("Can request for software");
                }
                else
                {
                    Assert.Fail("Cannot request for new software");
                }
            }
            else
            {
                _driver.Url = reqURL;
                s.SeeDetailsBtn().Click();
                if (s.Request().Displayed)
                {
                    Console.WriteLine("Can request for software");
                }
                else
                {
                    Assert.Fail("Cannot request for new software");
                }
            }
        }
        [Then(@"In the Home Page, Click on the Login Link and enter the (.*) and (.*) to login with super admin\.")]
        public void ThenInTheHomePageClickOnTheLoginLinkAndEnterTheAndToLoginWithSuperAdmin_(string username, string password)
        {
            Home h = new Home(_driver);
            var wait = new WebDriverWait(BrowserConfig._driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//li[@class='MMM--utilityLinks MMM--isOnDesktop MMM--desktopUtilLinks']")));

            h.Login().Click();
            Thread.Sleep(5000);
            Login l = new Login(_driver);
            l.Email().SendKeys(username);
            l.Password().SendKeys(password);
            l.LogIn().Click();
        }

        [Then(@"Select the users organistion\.")]
        public void ThenSelectTheUsersOrganistion_()
        {
            var _dropElement = BrowserConfig._driver.FindElement(By.XPath("//select[@id='orgDropdown']"));
            var _selectElement = new SelectElement(_dropElement);
            
             _selectElement.SelectByText("3M Internal Group");
            _driver.FindElement(By.XPath(ObjectIdentifiers._continuebtn)).Click();

        }
        [Then(@"Select the users organistion (.*)")]
        public void ThenSelectTheUsersOrganistion(string org)
        {
            var _dropElement = BrowserConfig._driver.FindElement(By.XPath("//select[@id='orgDropdown']"));
            var _selectElement = new SelectElement(_dropElement);

            _selectElement.SelectByText(org);
            _driver.FindElement(By.XPath(ObjectIdentifiers._continuebtn)).Click();
        }

        [Then(@"Navigate to Orgnazation and create a new one (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public void ThenNavigateToOrgnazationAndCreateANewOne(string _orgName, string _fname, string _country, string _lname, string _state, string _email, string _city, string _contactNo, string _bussinesUnit, string _accType, string _field, string _status)
        {
            _driver.FindElement(By.XPath(ObjectIdentifiers._orgLinkId)).Click();
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgBtn)).Click();
            _driver.FindElement(By.XPath(ObjectIdentifiers._orgnewNameId)).SendKeys(_orgName);

            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgFnameId)).SendKeys(_fname);
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgLnameId)).SendKeys(_lname);

            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgEmailId)).Clear();
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgEmailId)).SendKeys(_email);

            SupportingFunctions.selectCountry(_country, ObjectIdentifiers._createOrgCountryId);
            SupportingFunctions.scrollToElement(ObjectIdentifiers._createOrgCreateBtnId);

            SupportingFunctions.selectState(_state, ObjectIdentifiers._createOrgStateId);

            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgCityId)).Clear();
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgCityId)).SendKeys(_city);
            //Enter Admin Contact Number
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgContactId)).Clear();
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgContactId)).SendKeys(_contactNo);
            //Select Bussiness Unit
            SupportingFunctions.selectBussinessUnit(_bussinesUnit, ObjectIdentifiers._createOrgBUId);
            //Select Account Type
            SupportingFunctions.selectAccountType(_accType, ObjectIdentifiers._createOrgATId);
            //Select Field
            SupportingFunctions.selectField(_field, ObjectIdentifiers._createOrgFieldId);
            //Select Status
            SupportingFunctions.selectStatus(_status, ObjectIdentifiers._createOrgStatusId);
            _driver.FindElement(By.XPath(ObjectIdentifiers._createOrgCreateBtnId)).Click();
        }

        [Then(@"Verify Software cannot be released without org admin\.")]
        public void ThenVerifySoftwareCannotBeReleasedWithoutOrgAdmin_()
        {
            _driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/center[1]")).Click();
            _driver.FindElement(By.XPath("//i[contains(text(),'')]")).Click();
            _driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();
            //_driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();
            _driver.FindElement(By.XPath("//button[contains(text(),'Release Software')]")).Click();
            if(_driver.FindElement(By.XPath("//button[@id='submit-id-signup']")).Displayed)
            {
                Assert.Fail("Able to release software without org admin");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }
        [When(@"Logged in verify localization based on language selected\.")]
        public void WhenLoggedInVerifyLocalizationBasedOnLanguageSelected_()
        {
            Thread.Sleep(5000);
            String text1 = _driver.FindElement(By.XPath("//h1[contains(text(),'3M Software Download Portal')]")).Text;
            _driver.FindElement(By.XPath("//button[@id='changelang']")).Click();
            _driver.FindElement(By.XPath("//a[text()=' Canadian French']")).Click();
            String text2= _driver.FindElement(By.XPath("//h1[contains(text(),'Portail de téléchargement de logiciels 3M')]")).Text;
            if(text1.Equals(text2))
            {
                Assert.Fail("Localization issue not fixed.");
            }
            else
            {
                Console.WriteLine("Passed");
            }
            
        }

        [When(@"Logged in, then verify if Org Admin option is available in the user creation page\.")]
        public void WhenLoggedInThenVerifyIfOrgAdminOptionIsAvailableInTheUserCreationPage_()
        {
            Home h = new Home(_driver);
            h.AddUser().Click();
            var element = _driver.FindElements(By.XPath("//select[@id='SelectedUserRoleCode']"));
            foreach(IWebElement ele in element)
            {
                if(ele.Text.Contains("Organization Admin"))
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Assert.Fail("Org Admin cannot create another org admin.");
                }
            }
        }
        [When(@"Logged in, then verify if Org Admin does not have Expires on Column in Software Section\.")]
        public void WhenLoggedInThenVerifyIfOrgAdminDoesNotHaveExpiresOnColumnInSoftwareSection_()
        {
            List<String> dataEle = new List<String>();
            var ele = _driver.FindElements(By.XPath("//table[@id='dataTable2']/thead"));
            foreach(var item in ele)
            {
                dataEle.Add(item.Text);
            }
            if(dataEle.Contains("Expires On"))
            {
                Assert.Fail("Contains column Expires on.");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }

    }
}
