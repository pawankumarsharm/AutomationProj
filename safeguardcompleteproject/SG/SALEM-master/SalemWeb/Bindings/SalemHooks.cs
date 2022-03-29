using SalemWeb.ConfigFiles;
using SalemWeb.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SalemWeb.Bindings
{
    [Binding]
    public sealed class SalemHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        static int _rowCount = 3;
       // static int _r1 = 3;
        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }
        [AfterStep]
        public static void InitiateScreenshotInFailure()
        {
            var _stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError != null)
            {
                if (_stepType == "Given")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
                else if (_stepType == "Then")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
                else if (_stepType == "When")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
                else if (_stepType == "And")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
            }
            else
            {
                //TODO: implement logic that has to run before executing each scenario
            }
        }
        [AfterScenario]
        public void FlushResultToDataFile()
        {
            //kv
            //int _rowNumber = _sno;
            string _fileName = "";
            int _colNumber = 11;
            int _sheet = 1;
            if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Requesting Software for a particular platform"))
            {
                _fileName = "RequestDataResult";
                _colNumber = 11;
               
            }
            else if ((ScenarioContext.Current.ScenarioInfo.Title.Equals("Login to the WebApp using valid credentials.")) || (ScenarioContext.Current.ScenarioInfo.Title.Equals("Login to WebApp using invalid credentials")))
            {
                _fileName = "LoginResult";
                _colNumber = 11;
               
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Create a new Organisation."))
            {
                _fileName = "CreateNewOrg";
                _colNumber = 13;
               
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Approving Software Request for a particular platform."))
            {

                _fileName = "ApproveSoftwareRequest";
                _colNumber = 13;
                _sheet = 1;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Merge to an exsisting organistaion."))
            {

                _fileName = "ApproveSoftwareRequest";
                _colNumber = 13;
                _sheet = 2;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals(" Testing merge fuctionality."))
            {

                _fileName = "ApproveSoftwareRequest";
                _colNumber = 13;
                _sheet = 3;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Testing search functionality of merge."))
            {

                _fileName = "ApproveSoftwareRequest";
                _colNumber = 13;
                _sheet = 4;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Reject unapproved Request."))
            {

                _fileName = "ApproveSoftwareRequest";
                _colNumber = 13;
                _sheet = 5;
            }
            //Release Software
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Release Software."))
            {

                _fileName = "ReleaseSoftware";
                _colNumber = 13;
                _sheet = 1;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Verifying Product dropdown."))
            {

                _fileName = "ReleaseSoftware";
                _colNumber = 13;
                _sheet = 2;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Verifying version dropdown."))
            {

                _fileName = "ReleaseSoftware";
                _colNumber = 13;
                _sheet = 3;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Verifying license expiry date."))
            {

                _fileName = "ReleaseSoftware";
                _colNumber = 13;
                _sheet = 4;
            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Verifying max activation per day."))
            {

                _fileName = "ReleaseSoftware";
                _colNumber = 13;
                _sheet = 5;
            }
            //post organisation creation
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Adding user to Organisation"))
            {

                _fileName = "PostOrganisationCreation";
                _colNumber = 13;
                _sheet = 1;
            }

            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Deleting an Organisation"))
            {

                _fileName = "PostOrganisationCreation";
                _colNumber = 13;
                _sheet =2;
            }


            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Send Email"))
            {

                _fileName = "PostOrganisationCreation";
                _colNumber = 13;
                _sheet = 3;
            }


            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Add role to user"))
            {

                _fileName = "PostOrganisationCreation";
                _colNumber = 13;
                _sheet = 4;
            }


            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Remove role from user"))
            {

                _fileName = "PostOrganisationCreation";
                _colNumber = 13;
                _sheet = 5;
            }


            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Edit user"))
            {

                _fileName = "PostOrganisationCreation";
                _colNumber = 13;
                _sheet = 6;
            }



            if (ScenarioContext.Current.TestError == null)
            {
                string _msg = "Test passed successfully.";
                string _res = "PASS";
                WriteResult.writeResultToExcel(_res, _msg, _rowCount, _fileName, _colNumber, _sheet);

            }
            else if (ScenarioContext.Current.TestError != null)
            {
                string _msg = ScenarioContext.Current.TestError.Message;
                string _res = "FAIL";
                WriteResult.writeResultToExcel(_res, _msg, _rowCount, _fileName, _colNumber,_sheet);
            }
            _rowCount = _rowCount + 1;

         
          
            
        }
        [AfterFeature]
        public static void CloseBrowserInstance()
        {
            BrowserConfig._driver.Quit();
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            //TODO: implement logic that has to run after executing each scenario
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            BrowserConfig._driver = null;
        }
    }
}


