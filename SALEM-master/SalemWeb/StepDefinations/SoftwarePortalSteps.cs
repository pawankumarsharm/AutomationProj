using NUnit.Framework;
using OpenQA.Selenium;
using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace SalemWeb.StepDefinations
{
    [Binding]
    public class SoftwarePortalSteps
    {
        [Given(@"I have logged in to the Salem web portal using a valid credentials\.")]
        public void GivenIHaveLoggedInToTheSalemWebPortalUsingAValidCredentials_()
        {
          SupportingFunctions.logIntoApp();
         }

        [Given(@"I choose the organisation/groups to continue with")]
        public void GivenIChooseTheOrganisationGroupsToContinueWith(Table table)
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement _btnContinue = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loginContinueBtn));
                bool _isAvailable = _btnContinue.Displayed;
                if (_isAvailable)
                {
                    GetValues _organisation = table.CreateInstance<GetValues>();
                  SupportingFunctions.selectOrg(_organisation.Organistaion);

                    Thread.Sleep(3000);
                   // SupportingFunctions.SelectOrg(ObjectIdentifiers._chooseOrganisation);
                    //Click on continue btn
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loginContinueBtn)).Click();
                    //Verify if login was successfull or not
                    IWebElement _element = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dashboardLinkId));
                    bool IsVisible = _element.Displayed;
                    if (IsVisible)
                    {
                        Console.WriteLine("Login was successfull");
                    }
                    else
                    {
                        Assert.Fail("Login failed.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Already in the desired page.");
            }

        }
        [Then(@"select organisation (.*) from dropdown menu and click on Continue button\.")]
        public void ThenSelectOrganisationFromDropdownMenuAndClickOnContinueButton_(string organisation)
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
        [Then(@"I navigate to the software portal\.")]
        public void ThenINavigateToTheSoftwarePortal_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._softwareLinkId)).Click();
        }
       
        [Then(@"Verify the list of displayed softwares\.")]
        public void ThenVerifyTheListOfDisplayedSoftwares_()
        {
            //Calculate the displayed software
            // xpath of html table
            var elemTable = BrowserConfig._driver.FindElement(By.XPath("//table[@id='dataTable']"));
            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";
            if (lstTrElem.Count() > 0)
            {
                foreach (var elemTr in lstTrElem)
                {
                    // Fetch the columns from a particuler row
                    List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                    if (lstTdElem.Count > 0)
                    {
                        // Traverse each column
                        foreach (var elemTd in lstTdElem)
                        {
                            // "\t\t" is used for Tab Space between two Text
                            strRowData = strRowData + elemTd.Text + "\t\t";
                        }
                    }
                    else
                    {
                        // To print the data into the console
                        //Console.WriteLine("This is Header Row");
                        //Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                    }
                    Console.WriteLine(strRowData);
                    strRowData = String.Empty;
                }
            }
            else
            {
                Assert.Fail("No data available");
            }
        }
        [Then(@"I enter a particular software to search in the search box\.")]
        public void ThenIEnterAParticularSoftwareToSearchInTheSearchBox_(Table table)
        {
            GetValues _software = table.CreateInstance<GetValues>();
            //Enter the value to search in the search box.
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._softwareSearchId)).SendKeys(_software.Software);
        }
        [Then(@"Verify if the filtered software exists or not\.")]
        public void ThenVerifyIfTheFilteredSoftwareExistsOrNot_()
        {
            string _modified = ObjectIdentifiers._softwareeditCust.Replace("Identifier", "TestQAKSV");
            IWebElement _softFiltered = BrowserConfig._driver.FindElement(By.XPath(_modified));
            bool _isavailable = _softFiltered.Displayed;
            if (_isavailable)
            {
                Console.WriteLine("Software is available.");
            }
            else
            {
                Console.WriteLine("Software not available.");
            }
        }
        [Then(@"I click on the edit button\.")]
        public void ThenIClickOnTheEditButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._editSoftwareId)).Click();
        }
        [Then(@"I modify the values in the software description\.")]
        public void ThenIModifyTheValuesInTheSoftwareDescription_(Table table)
        {
            GetValues _edit = table.CreateInstance<GetValues>();
            BrowserConfig._driver.FindElement(By.XPath("//input[@id='SoftwareName']")).Clear();
            BrowserConfig._driver.FindElement(By.XPath("//input[@id='SoftwareName']")).SendKeys(_edit.Name);
            SupportingFunctions.selectBussinessUnitInEdit(_edit.Bussiness_Unit);
         
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnUpdate)).Click();
            bool _isdisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastEditSftwreSuccess)).Displayed;
            if (!_isdisplayed)
            {
                Assert.Fail("Error occured during editing process.");
            }
        }
        [Then(@"I Click on the delete button\.")]
        public void ThenIClickOnTheDeleteButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteSoftwareId)).Click();
        }
        [Then(@"Click on Ok button to confirm the deletion\.")]
        public void ThenClickOnOkButtonToConfirmTheDeletion_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteOKConfirm)).Click();
        }
        [Then(@"I click on Add New Software Button\.")]
        public void ThenIClickOnAddNewSoftwareButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._addNewSoftWare)).Click();
        }
        [Then(@"I enter the software details\.")]
        public void ThenIEnterTheSoftwareDetails_(Table table)
        {
            GetValues _newSoftware = table.CreateInstance<GetValues>();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._newSoftwareName)).Clear();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._newSoftwareName)).SendKeys(_newSoftware.NameSftwre);
            SupportingFunctions.selectSoftType(_newSoftware.SoftwareType);
            SupportingFunctions.selectBussinessUnitInEdit(_newSoftware.BussinessUnit);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._newStwShortDesc)).SendKeys(_newSoftware.ShortDesc);
          
        }

        [Then(@"Click on create button\.")]
        public void ThenClickOnCreateButton_()
        {
            SupportingFunctions.scrollToElement(ObjectIdentifiers._btnCreateStwre);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._btnCreateStwre)).Click();
        }
        [Then(@"Verify the success message\.")]
        public void ThenVerifyTheSuccessMessage_()
        {
            bool _isDisplayed = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._toastnewSftWreSuccess)).Displayed;
            if (!_isDisplayed)
            {
                Assert.Fail("Success message not displayed.");
            }
        }


    }

}
