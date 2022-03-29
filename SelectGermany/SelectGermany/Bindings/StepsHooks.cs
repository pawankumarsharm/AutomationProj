using OpenQA.Selenium;
using SelectGermany.BrowsersConfigs;
using SelectGermany.Helpers;

using SelectGermany.StepsDefination;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SelectGermany.Bindings
{
    [Binding]
    public sealed class StepsHooks
    {
        static int rowCount = 3;
        public static string _sourcepath = AppDomain.CurrentDomain.BaseDirectory;
        public static string _destpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Logs");


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
        /// <summary>
        /// Function to Fetch the test result after every step execution.
        /// </summary>
        [AfterStep]
        public static void FetchTestResult()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                GermanySelectSteps.Logger.Info("No error occured.");
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    //Taking screenshot of the failed testcases
                    var takesScreenshot = BrowserConfigs.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    GermanySelectSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        GermanySelectSteps.Logger.Info("Exception occured.......Taking screenshots");
                        SupportingFunctions.TakingScreenshot(stepinfo);
                    }
                }
                else if (stepType == "Then")
                {
                    //_cusScenarios.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    var takesScreenshot = BrowserConfigs.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    GermanySelectSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        GermanySelectSteps.Logger.Info("Exception occured.......Taking screenshots");
                        SupportingFunctions.TakingScreenshot(stepinfo);
                    }
                }
                else if (stepType == "When")
                {
                    //_cusScenarios.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    var takesScreenshot = BrowserConfigs.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    GermanySelectSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        GermanySelectSteps.Logger.Info("Exception occured.......Taking screenshots");
                        SupportingFunctions.TakingScreenshot(stepinfo);

                    }
                }
                else if (stepType == "And")
                {
                    //_cusScenarios.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    var takesScreenshot = BrowserConfigs.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    GermanySelectSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        GermanySelectSteps.Logger.Info("Exception occured.......Taking screenshots");
                        SupportingFunctions.TakingScreenshot(stepinfo);

                    }
                }
            }
        }

        [AfterScenario]
        public void WriteStatus()
        {
            if (ScenarioContext.Current.TestError == null)
            {
                string msg = "Data Matched successfully";
                var res = "PASS";

                WriteDataToExcel.ExcelCode(res, msg, rowCount);
                GermanySelectSteps.Logger.Info("No Exception occured.......Dumping result to the Result Excel File");
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                string msg = ScenarioContext.Current.TestError.Message;
                var res = "FAIL";

                WriteDataToExcel.ExcelCode(res, msg, rowCount);
                GermanySelectSteps.Logger.Info("Exception occured " + "Status= " + res + " Exception is " + msg + ".......Dumping result to the Result Excel File");
            }

            rowCount = rowCount + 1;
            //Console.WriteLine(rowCount);
            //string output = Process.StandardOutput.ReadToEnd();
        }

        [AfterFeature]
        public static void TearDown()
        {
            GermanySelectSteps.Logger.Info("Closing the Browser Instance........");
            BrowserConfigs.QuitBrowsersInstance();
            //Close chrome process
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            string excelbatchfile = path + "\\killexcel" + ".bat";
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            GermanySelectSteps.Logger.Info("Killing chromedriver process........");
            GermanySelectSteps.Logger.Info("Successfully sent the Test Result File in email........");
            GermanySelectSteps.Logger.Info("Successfully sent the Log File in email........");
            string _sourcefile = _sourcepath + "\\Tc_RunLogs" + ".log";
            string _destFile = _destpath + "\\Tc_RunLogs" + ".log";
            bool _desFileExists = System.IO.File.Exists(_destFile);
            if (_desFileExists)
            {
                System.IO.File.Delete(_destFile);
            }
            File.Copy(_sourcefile, _destFile);


        }
    }
}
