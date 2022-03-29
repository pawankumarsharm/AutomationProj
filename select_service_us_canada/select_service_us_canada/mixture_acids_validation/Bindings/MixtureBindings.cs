using AventStack.ExtentReports;
using OpenQA.Selenium;
using select_service_us_canada.mixture_acids_validation.Configurations;
using select_service_us_canada.mixture_acids_validation.excel;
using select_service_us_canada.mixture_acids_validation.StepDefinations;
using select_service_us_canada.mixture_acids_validation.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace select_service_us_canada.mixture_acids_validation.Bindings
{
    [Binding]
    [Scope(Feature = "MixtureAcidValidations")]
    class MixtureBindings
    {
        static int rowCount = 1;
        static int counter = 0;        
        
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string _sourcePath = _rootPath + "ServiceLifeMixture" + ".log";
        public static string _destPath = _rootPath.Replace("\\bin\\Debug", "\\mixture_acids_validation\\Logs");

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void Browser()
        {
            MixtureAcidValidationsSteps._logger.Info("Setting up the Browser");
            BrowserConfig.Init();
        }
        [BeforeScenario]
        public void OpenExcelFile()
        {            
            ReadMixtureData.excel();            
        }
        [AfterFeature]
        public static void KillChromeDriverExcel()
        {
            MixtureAcidValidationsSteps._logger.Info("Killing the Chrome Driver process from the background");
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            string excelbatchfile = path + "\\killexcel" + ".bat";
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            MixtureAcidValidationsSteps._logger.Info("Closing the browser instance");
            BrowserConfig.Close();
            MixtureAcidValidationsSteps._logger.Info("Sending the test run report in the mail......Success...OK");
            MixtureAcidValidationsSteps._logger.Info("Sending the test run Log file in the mail......Success...OK");
            //System.Diagnostics.Process.Start(excelbatchfile);
            string _destFile = _destPath + "ServiceLifeMixture" + ".log";
            //Checking if Logs folder exists or not
            bool _destFolder = Directory.Exists(_destPath);
            if(_destFolder)
            {
                bool _isFilePresent = File.Exists(_destFile);
                if (_isFilePresent)
                {
                    File.Delete(_destFile);
                }
                File.Copy(_sourcePath, _destFile);
            }
            else
            {
                Directory.CreateDirectory(_destPath);
                bool _isFilePresent = File.Exists(_destFile);
                if (_isFilePresent)
                {
                    File.Delete(_destFile);
                }
                File.Copy(_sourcePath, _destFile);
            }
            //"C:\Users\kanak\Source\Repos\select_service_us_canada2\select_service_us_canada\bin\Debug\Tc_RunLogsMixture.log"

            // File.Copy(_sourcePath, _destFile);
            //sendMail.SendReportinMail();
            TriggerMail.SendMail();
        }
        [AfterStep]
        public void InsertReportingSteps()
        {
            var StepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError != null)
            {
                string _tsterr = ScenarioContext.Current.TestError.Message;
                MixtureAcidValidationsSteps._logger.Error(_tsterr);
                if (StepType == "Given")
                {
                    // scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;

                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        MixtureAcidValidationsSteps._logger.Error("Exception Occured .....Taking Screenshot");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
                else if (StepType == "Then")
                {
                    //scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;

                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        MixtureAcidValidationsSteps._logger.Error("Exception Occured .....Taking Screenshot");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
                else if (StepType == "When")
                {
                    // scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;

                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        MixtureAcidValidationsSteps._logger.Error("Exception Occured .....Taking Screenshot");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
                else if (StepType == "And")
                {
                    // scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;

                    var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
                    if (takesScreenshot != null)
                    {
                        MixtureAcidValidationsSteps._logger.Error("Exception Occured .....Taking Screenshot");
                        ScreenshotClass.ScreenshotClasses(stepinfo);
                    }
                }
            }
        }

        [AfterScenario]
        public void WriteResult()
        {
            Console.WriteLine(counter);
            rowCount = setRowCount(rowCount, counter);
            //TODO: implement logic that has to run after executing each scenario
            if (ScenarioContext.Current.TestError == null)
            {
                string currentScenario = ScenarioContext.Current.ScenarioInfo.Title;
                string errorMsg = "No error";
                //  Console.WriteLine(currentScenario);
                var res = "PASS";
                MixtureAcidValidationsSteps._logger.Info("No error.....dumping status as Pass and message as No error");
                MixtureResultWriteExcel.ExcelCode(res, rowCount, errorMsg);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                var res = "FAIL";
                string errorMsg = ScenarioContext.Current.TestError.Message;
                MixtureAcidValidationsSteps._logger.Info("Error.....dumping status as FAIL and message as "+errorMsg);
                MixtureResultWriteExcel.ExcelCode(res, rowCount, errorMsg);
            }

            Console.WriteLine(rowCount);
            //BrowserConfig.Close();
            ReadMixtureData.excelClose();

        }
        public int setRowCount(int rowCount, int counterx)
        {
            counter = counterx + 1;
            Console.WriteLine(counter);
            if(counter<=16)
            {
                rowCount = rowCount + 2;
            }
            else if(counter==17 || counter==18)
            {
                rowCount = rowCount + 3;
            }
            else if(counter == 19 || counter == 20 || counter == 21 || counter == 22 || counter == 23 || counter == 24)
            {
                rowCount = rowCount + 4;
            }
            else if(counter == 25)
            {
                rowCount = rowCount + 5;
            }
            //if (rowCount < 35)
            //{
            //    rowCount = rowCount + 2;
            //}
            //if (counter == 18 || counter == 19)
            //{
            //    rowCount = rowCount + 3;
            //}
            //if (counter == 20 || counter == 21 || counter == 22 || counter == 23 || counter == 24)
            //{
            //    rowCount = rowCount + 4;
            //}
            //if (counter == 25)
            //{
            //    rowCount = rowCount + 4;
            //}
            //if (counter == 26)
            //{
            //    rowCount = rowCount + 5;
            //}
            return rowCount;
        }
    }
}
