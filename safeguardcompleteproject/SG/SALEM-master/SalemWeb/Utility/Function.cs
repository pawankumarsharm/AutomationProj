using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SalemWeb.ConfigFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalemWeb.Utility
{
    class Function
    {
        public static void selectOrganisation(string organisation)
        {
            ExplicitWaiting.waitForTime(3000);
            var _organisationBtnIdentifier = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._organisationBtnIdentifier));
            var selectElement = new SelectElement(_organisationBtnIdentifier);
            if (organisation.Equals("3M Internal Group"))
            {
                selectElement.SelectByText("3M Internal Group");
            }
            else if (organisation.Equals("Organisation2"))
            {
                selectElement.SelectByText("Organisation2");
            }
        }

       public static void elementVisible(IWebElement element)
        {
            bool visibility =  element.Displayed;
            if(visibility == true)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
        public static void selectRole(string role)
        {
            ExplicitWaiting.waitForTime(3000);
            var _roleBtn = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._roleBtnIdentifier));
            var selectElement = new SelectElement(_roleBtn);
            if(role.Equals("Organization Admin"))
            {
                selectElement.SelectByText("Organization Admin");
            }
            else if(role.Equals("Application User"))
            {
                selectElement.SelectByText("Application User");
            }
        }
        public static void selectRoleAs(string role)
        {
            ExplicitWaiting.waitForTime(3000);
            var _roleBtn1 = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._userRole));
            var selectElement = new SelectElement(_roleBtn1);
            if (role.Equals("Organization Admin"))
            {
                selectElement.SelectByText("Organization Admin");
            }
            else if (role.Equals(" Application User"))
            {
                selectElement.SelectByText("Application User");
            }
        }
        public static void selectRoleFor(string role)
        {
            ExplicitWaiting.waitForTime(3000);
            var _roleBtn2 = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._roleString));
            var selectElement = new SelectElement(_roleBtn2);
            if (role.Equals("Organization Admin"))
            {
                selectElement.SelectByText("Organization Admin");
            }
            else if (role.Equals(" Application User"))
            {
                selectElement.SelectByText("Application User");
            }
        }
        public static void selectAll(string b)
        {
            ExplicitWaiting.waitForTime(3000);
            var _showAll = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._showAll));
            var selectAllElement = new SelectElement(_showAll);
            if (b.Equals("All"))
            {
                selectAllElement.SelectByText("All");
            }
            else if (b.Equals("5"))
            {
                selectAllElement.SelectByText("5");
            }
            else if (b.Equals("10"))
            {
                selectAllElement.SelectByText("10");
            }
            else if (b.Equals("25"))
            {
                selectAllElement.SelectByText("25");
            }
            else if (b.Equals("50"))
            {
                selectAllElement.SelectByText("50");
            }
        }
        public static void chooseRole()
        {
            ExplicitWaiting.waitForTime(3000);
            var _addRoleBtn = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._choseRoleDropDown));
            var selectRoleElement = new SelectElement(_addRoleBtn);
            selectRoleElement.SelectByIndex(1);
        }
        public static void chooseBusinessUnit()
        {
            ExplicitWaiting.waitForTime(3000);
            var _addBusinessUnit = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chooseBusinessUnit));
            var selectRoleElement = new SelectElement(_addBusinessUnit);
            selectRoleElement.SelectByIndex(1);
        }
        public static void chooseOrganisation()
        {
            ExplicitWaiting.waitForTime(3000);
            var _addOrganisationBtn = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chooseOrganisation));
            var selectRoleElement = new SelectElement(_addOrganisationBtn);
            selectRoleElement.SelectByIndex(1);
        }
        public static void productSelect()
        {
            ExplicitWaiting.waitForTime(3000);
            var _productSelect = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._product));
            var selectRoleElement1 = new SelectElement(_productSelect);
            selectRoleElement1.SelectByIndex(1);
        }
        public static void versionSelect()
        {
            ExplicitWaiting.waitForTime(3000);
            var _versionSelect = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._version));
            var selectRoleElement2 = new SelectElement(_versionSelect);
            selectRoleElement2.SelectByIndex(1);
        }
        public static void maxActivationSelect()
        {
            ExplicitWaiting.waitForTime(3000);
            var _maxActivationSelect = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._maxActivation));
            var selectRoleElement3 = new SelectElement(_maxActivationSelect);
            selectRoleElement3.SelectByIndex(1);
        }
        public static void stateUnapproved()
        {
            ExplicitWaiting.waitForTime(3000);
            var _unapprovedState = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._stateUnapproved));
            var selectStateElement = new SelectElement(_unapprovedState);
          selectStateElement .SelectByIndex(1);
        }

    }

}

