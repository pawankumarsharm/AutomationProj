using OpenQA.Selenium;
using ServiceLifeChile.Helpers;
using ServiceLifeChile.StepsDefinations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ServiceLifeChile.Hooks
{
    [Binding]
    public sealed class ChileBindings
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        static int rowCount = 3;
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string _sourcePath = _rootPath + "\\ChileServiceLife" + ".log";
        public static string _destpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Singles\\Logs");

        [BeforeFeature]
        public static void BrowserInstance()
        {
            //TODO: implement logic that has to run before executing each scenario
            BrowserConfig.Init();
        }
        [AfterScenario]
        public void WriteStatus()
        {
            if (ScenarioContext.Current.TestError == null)
            {
                string msg = "Data Matched successfully";
                var res = "PASS";

                WriteDataToExcel.ExcelCode(res, msg, rowCount);
                ValidatingServiceLifeHoursSteps.Logger.Info("No Exception occured.......Dumping result to the Result Excel File");
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                string msg = ScenarioContext.Current.TestError.Message;
                var res = "FAIL";

                WriteDataToExcel.ExcelCode(res, msg, rowCount);
                ValidatingServiceLifeHoursSteps.Logger.Info("Exception occured " + "Status= " + res + " Exception is " + msg + ".......Dumping result to the Result Excel File");
            }

            rowCount = rowCount + 1;
        }
        [AfterFeature]
        public static void CloseBrowser()
        {
            //TODO: implement logic that has to run after executing each scenario
            ValidatingServiceLifeHoursSteps.Logger.Info("Killing the Browser instance");
            BrowserConfig.webDriver.Close();
            BrowserConfig.webDriver.Dispose();
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            string excelbatchfile = path + "\\killexcel" + ".bat";
            ValidatingServiceLifeHoursSteps.Logger.Info("Killing the chrome process from the backgroung task");
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            ValidatingServiceLifeHoursSteps.Logger.Info("Sending the test run report in the mail......Success...OK");
            ValidatingServiceLifeHoursSteps.Logger.Info("Sending the test run Log file in the mail......Success...OK");
            //System.Diagnostics.Process.Start(excelbatchfile);
            //Checking if folder exists or not
            bool _destFolder = Directory.Exists(_destpath);
            if (_destFolder)
            {
                string _destFile = _destpath + "\\ChileServiceLife" + ".log";
                bool _isFilePresent = File.Exists(_destFile);
                if (_isFilePresent)
                {
                    File.Delete(_destFile);
                }
                File.Copy(_sourcePath, _destFile);
            }
            else
            {
                //Create Director
                Directory.CreateDirectory(_destpath);
                string _destFile = _destpath + "\\ChileServiceLife" + ".log";
                bool _isFilePresent = File.Exists(_destFile);
                if (_isFilePresent)
                {
                    File.Delete(_destFile);
                }
                File.Copy(_sourcePath, _destFile);
            }
        }
        [AfterStep]
        public static void FetchResult()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                ValidatingServiceLifeHoursSteps.Logger.Info("No error occured.");
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    //Taking screenshot of the failed testcases
                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    ValidatingServiceLifeHoursSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        ValidatingServiceLifeHoursSteps.Logger.Info("Exception occured.......Taking screenshots");
                        HelperFunctions.TakingScreenshot(stepinfo);
                    }
                }
                else if (stepType == "Then")
                {
                    //_cusScenarios.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    ValidatingServiceLifeHoursSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        ValidatingServiceLifeHoursSteps.Logger.Info("Exception occured.......Taking screenshots");
                        HelperFunctions.TakingScreenshot(stepinfo);
                    }
                }
                else if (stepType == "When")
                {
                    //_cusScenarios.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    ValidatingServiceLifeHoursSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        ValidatingServiceLifeHoursSteps.Logger.Info("Exception occured.......Taking screenshots");
                        HelperFunctions.TakingScreenshot(stepinfo);

                    }
                }
                else if (stepType == "And")
                {
                    //_cusScenarios.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    ValidatingServiceLifeHoursSteps.Logger.Error(ScenarioContext.Current.TestError.Message);
                    if (takesScreenshot != null)
                    {
                        ValidatingServiceLifeHoursSteps.Logger.Info("Exception occured.......Taking screenshots");
                        HelperFunctions.TakingScreenshot(stepinfo);

                    }
                }
            }
        }
    }
}
