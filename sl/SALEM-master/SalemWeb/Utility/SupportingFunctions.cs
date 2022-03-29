using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SalemWeb.ConfigFiles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalemWeb.Utility
{
    class SupportingFunctions
    {

        private static readonly string _username = ConfigurationManager.AppSettings.Get("email");
        private static readonly string _password = ConfigurationManager.AppSettings.Get("password");
        public static string _expected_url = "https://download-qa.3m.com/Software/ViewSoftware";
        public static string _expected_url1 = "https://download-qa.3m.com/Software/ViewSoftware/";
        public static string _editUrl = "https://download-qa.3m.com/Software/EditSoftware?softwareId";
        public static void selectPlatform(string _platform)
        {
            var _platformIdentifier = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._platformIdentifier));
            var _selectElement = new SelectElement(_platformIdentifier);
            if (_platform.Equals("Desktop"))
            {

                _selectElement.SelectByValue("DESKTOP");
            }
            else if (_platform.Equals("Mobile"))
            {
                _selectElement.SelectByValue("MOBILE");
            }
            else if (_platform.Equals("All Platform"))
            {
                _selectElement.SelectByValue("All Platforms");
            }
        }
        public static void selectSoftware(string _software)
        {
            if (_software.Equals("Monitor QA"))
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._MonitorQASDIdentifier)).Click();
            }
            else if(_software.Equals("Configure QA"))
            {
                //
            }
        }
        public static void Request()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._requestBtn)).Click();
        }
        public static void verifyEmail(string _email)
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mailId)).SendKeys(_email);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._veriftBtnIdentifier)).Click();
        }
        public static void selectCountry(string _country)
        {
            var _countryIdentifier = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._countryId));
            var _selectElement = new SelectElement(_countryIdentifier);
            if (_country.Equals("India"))
            {
                
                _selectElement.SelectByText("India");
            }
            else if (_country.Equals("Mobile"))
            {
                _selectElement.SelectByText("MOBILE");
            }
            else if (_country.Equals("All Platform"))
            {
                _selectElement.SelectByText("All Platforms");
            }
        }
        public static void selectCountry(string _country, string _countryobjId)
        {
            var _countryIdentifier = BrowserConfig._driver.FindElement(By.XPath(_countryobjId));
            var _selectElement = new SelectElement(_countryIdentifier);
            if (_country.Equals("India"))
            {
                
                _selectElement.SelectByText("India");
            }
            else if (_country.Equals("Australia"))
            {
                _selectElement.SelectByText("Australia");
            }
            else if (_country.Equals("Canada"))
            {
                _selectElement.SelectByText("Canada");
            }
        }
        internal static void selectOrg(string _org)
        {
            var _dropElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._orgDropdown));
            var _selectElement = new SelectElement(_dropElement);
            if (_org.Equals("3M Internal Group"))
            {
                _selectElement.SelectByText("3M Internal Group");
            }
            else if (_org.Equals("Organization2"))
            {
                _selectElement.SelectByText("Organization2");
            }
        }
        public static void selectState(string _state, string _stateId)
        {
            
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._stateHeader);
            var _stateIdentifier = BrowserConfig._driver.FindElement(By.XPath(_stateId));
            _stateIdentifier.Click();
              ExplicitWaiting.waitForTime(2000);
            var _selectElement = new SelectElement(_stateIdentifier);
            if (_state.Equals("Jharkhand"))
            {
               
                _selectElement.SelectByText("Jharkhand");
                
            }
            else if (_state.Equals("Bihar"))
            {
                _selectElement.SelectByText("Bihar");
            }
            else if (_state.Equals("Assam"))
            {
                _selectElement.SelectByText("Assam");
            }
        }

        public static void scrollToElement(string _targetele)
        {

            int _length = _targetele.Length;
            if (_length > 40)
            {
                var element = BrowserConfig._driver.FindElement(By.CssSelector(_targetele));
                Actions actions = new Actions(BrowserConfig._driver);
                actions.MoveToElement(element);
                actions.Perform();
            }
            else
            {
                var element = BrowserConfig._driver.FindElement(By.XPath(_targetele));
                Actions actions = new Actions(BrowserConfig._driver);
                actions.MoveToElement(element);
                actions.Perform();
            }

        }
        internal static void selectBussinessUnit(string bussinesUnit, string createOrgBUId)
        {
            var _bssUnitId = BrowserConfig._driver.FindElement(By.XPath(createOrgBUId));
            var _selectEle = new SelectElement(_bssUnitId);
            if (bussinesUnit.Equals("3M Scott"))
            {
                _selectEle.SelectByText("3M Scott");
            }
            else if (bussinesUnit.Equals("Commercial Software"))
            {
                _selectEle.SelectByText("Commercial Software");
            }
        }

        internal static void selectBussinessUnitInEdit(string bussiness_Unit)
        {
            var _dropElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._editBussUnit));
            var _selectElement = new SelectElement(_dropElement);
            if (bussiness_Unit.Equals("3M Scott"))
            {
                _selectElement.SelectByText("3M Scott");
            }
            else if (bussiness_Unit.Equals("Commercial Software"))
            {
                _selectElement.SelectByText("Commercial Software");
            }
        }
        internal static void selectField(string _field, string createOrgFieldId)
        {
            var _orgfieldId = BrowserConfig._driver.FindElement(By.XPath(createOrgFieldId));
            var _selectEle = new SelectElement(_orgfieldId);
            if (_field.Equals("Fire Services"))
            {
                _selectEle.SelectByText("Fire Services");
            }
            else if (_field.Equals("Industrial"))
            {
                _selectEle.SelectByText("Industrial");
            }

        }

        internal static void logIntoApp()
        {
            string _currentUrl = BrowserConfig._driver.Url;
            if (_expected_url.Equals(_currentUrl) || _currentUrl.Equals(_expected_url1))
            {
                Console.WriteLine("Nothing to do....");
            }
            else if (_currentUrl.Contains(_editUrl))
            {
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._softwareLinkId)).Click();
            }
            else
            {
                  ExplicitWaiting.waitForTime(3000);
                Console.WriteLine(_username);
                Console.WriteLine(_password);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._signinbtn)).Click();
                  ExplicitWaiting.waitForTime(3000);
                //Now enter valid username and password and click on sign in button
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._email)).SendKeys(_username);
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._password)).SendKeys(_password);
                //Click on login button
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnSignIn)).Click();
            }
        }
        internal static void selectStatus(string _status, string createOrgStatusId)
        {
            var _StatusId = BrowserConfig._driver.FindElement(By.XPath(createOrgStatusId));
            var _selectEle = new SelectElement(_StatusId);
            if (_status.Equals("Active"))
            {
                _selectEle.SelectByText("Active");
            }
            else if (_status.Equals("Inactive"))
            {
                _selectEle.SelectByText("Inactive");
            }
            else if (_status.Equals("Suspended"))
            {
                _selectEle.SelectByText("Suspended");
            }
            else if (_status.Equals("Unapproved"))
            {
                _selectEle.SelectByText("Unapproved");
            }
            else if (_status.Equals("Rejected"))
            {
                _selectEle.SelectByText("Rejected");
            }
            else if (_status.Equals("Merged"))
            {
                _selectEle.SelectByText("Merged");
            }
        }
        internal static void selectAccountType(string accType, string createOrgATId)
        {
            var _accTypeId = BrowserConfig._driver.FindElement(By.XPath(createOrgATId));
            var _selectele = new SelectElement(_accTypeId);
            if (accType.Equals("Fire Department"))
            {
                _selectele.SelectByText("Fire Department");
            }
            else if (accType.Equals("Distributor"))
            {
                _selectele.SelectByText("Distributor");
            }
            else if (accType.Equals("Sales & Marketing"))
            {
                _selectele.SelectByText("Sales & Marketing");
            }
            else if (accType.Equals("Manufacturing"))
            {
                _selectele.SelectByText("Manufacturing");
            }
            else if (accType.Equals("Engineering"))
            {
                _selectele.SelectByText("Engineering");
            }
            else if (accType.Equals("Support"))
            {
                _selectele.SelectByText("Support");
            }
        }
        internal static void selectSoftType(string softwareType)
        {
            softwareType.ToUpper();
            var _dropElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._newSoftwareType));
            var _selectElement = new SelectElement(_dropElement);
            if (softwareType.Equals("Desktop"))
            {
                _selectElement.SelectByValue("WINDOWS");
            }
            else if (softwareType.Equals("MOBILE"))
            {
                _selectElement.SelectByValue("MOBILE");
            }
        }

    }
}




