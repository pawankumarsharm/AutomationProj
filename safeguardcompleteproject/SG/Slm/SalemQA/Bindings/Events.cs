using SalemQA.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SalemQA.Bindings
{
    [Binding]
    public sealed class Events:BrowserConfig
    {
        static int rowCount = 3;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            BrowserConfig.Init();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            if(scenarioName.Equals("Org Admin Accessiblity Improvements."))
            {
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
            }
            else if(scenarioName.Equals("Software has been realeased to Organization without an Org Admin"))
            {
                rowCount = 4;
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
            }
            else if (scenarioName.Equals("Org Admin Localization issue."))
            {
                rowCount = 5;
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
            }
            else if (scenarioName.Equals("Org Admin should able to create another org admin."))
            {
                rowCount = 6;
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
            }
            else if (scenarioName.Equals("Org Admin should not see expires on in the Software Section."))
            {
                rowCount = 7;
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    WriteDataToExcel.ExcelCode(res, msg, rowCount);

                }
            }
            // rowCount = rowCount + 1;
           // _driver = null;
            _driver.Close();
            _driver.Quit();
            _driver = null;
        }
            
        }
    }

