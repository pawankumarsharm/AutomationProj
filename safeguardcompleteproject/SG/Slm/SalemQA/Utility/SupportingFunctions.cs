using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalemQA.Utility
{
    class SupportingFunctions
    {
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
        public static void selectState(string _state, string _stateId)
        {

            Thread.Sleep(3000);
            var _stateIdentifier = BrowserConfig._driver.FindElement(By.XPath(_stateId));
            _stateIdentifier.Click();
            Thread.Sleep(3000);
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
    }
}
