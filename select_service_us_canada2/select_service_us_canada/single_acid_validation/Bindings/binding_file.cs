using AventStack.ExtentReports;
using OpenQA.Selenium;
using select_service_us_canada.single_acid_validation.Configurations;
using select_service_us_canada.single_acid_validation.excel;
using select_service_us_canada.single_acid_validation.StepDefinations;
using select_service_us_canada.single_acid_validation.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace select_service_us_canada.single_acid_validation.Bindings
{
    [Binding]
    [Scope(Feature = "Non_Mixture_Validation")]
    public sealed class binding_file
    {
        static int rowCount = 3;
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string _sourcePath = _rootPath + "\\ServiceLife" + ".log";
        public static string _destPath = _rootPath.Replace("\\bin\\Debug", "\\single_acid_validation\\Logs");
        public static ExtentTest featureName;
        public static ExtentTest scenario;
        public static ExtentReports extent;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void BrowserInstance()
        {
            BrowserAndUrlConfig.Init();
            //Create feature node
        }

        [AfterFeature]
        public static void CloseDriverInstance()
        {
            Non_Mixture_ValidationSteps._logger.Info("Killing the Browser instance");
            BrowserAndUrlConfig.webDriver.Close();
            BrowserAndUrlConfig.webDriver.Dispose();
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            string excelbatchfile = path + "\\killexcel" + ".bat";
            Non_Mixture_ValidationSteps._logger.Info("Killing the chrome process from the backgroung task");
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            Non_Mixture_ValidationSteps._logger.Info("Sending the test run report in the mail......Success...OK");
            Non_Mixture_ValidationSteps._logger.Info("Sending the test run Log file in the mail......Success...OK");
            //System.Diagnostics.Process.Start(excelbatchfile);
            //Checking if folder exists or not
            bool _destFolder = Directory.Exists(_destPath);
            if(_destFolder)
            {
                string _destFile = _destPath + "\\ServiceLife" + ".log";
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
                Directory.CreateDirectory(_destPath);
                string _destFile = _destPath + "\\ServiceLife" + ".log";
                bool _isFilePresent = File.Exists(_destFile);
                if (_isFilePresent)
                {
                    File.Delete(_destFile);
                }
                File.Copy(_sourcePath, _destFile);
            }

            //sendMail.SendReportinMail();
          //  TriggerMail.SendMail();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            if (ScenarioContext.Current.TestError == null)
            {
                string msg = "No Error ";
                var res = "PASS";
                Non_Mixture_ValidationSteps._logger.Info("No Exception occured...");
                Non_Mixture_ValidationSteps._logger.Info("Dumping the test result as PASS and test message as No Error");
                Program.ExcelCode(res, rowCount, msg);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                Non_Mixture_ValidationSteps._logger.Info("Some exception occured..."+"\n");
                string msg = ScenarioContext.Current.TestError.Message;
                Non_Mixture_ValidationSteps._logger.Error(msg);
                var res = "FAIL";
                Non_Mixture_ValidationSteps._logger.Info("Dumping the test result as FAIL and test message as "+msg);
                Program.ExcelCode(res, rowCount, msg);
            }
            rowCount++;
        }
        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {

                //if (stepType == "Given")
                //{
                //    //  scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

                //}
                //else if (stepType == "When")
                //{
                //    //  scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);

                //}
                //else if (stepType == "Then")
                //{
                //    //  scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);


                //}

            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    var takesScreenshot = BrowserAndUrlConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        Non_Mixture_ValidationSteps._logger.Info("Some exception occured.....taking screenshots");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
                else if (stepType == "When")
                {
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    var takesScreenshot = BrowserAndUrlConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        Non_Mixture_ValidationSteps._logger.Info("Some exception occured.....taking screenshots");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
                else if (stepType == "Then")
                {
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    var takesScreenshot = BrowserAndUrlConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        Non_Mixture_ValidationSteps._logger.Info("Some exception occured.....taking screenshots");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
            }

        }
    }
}
