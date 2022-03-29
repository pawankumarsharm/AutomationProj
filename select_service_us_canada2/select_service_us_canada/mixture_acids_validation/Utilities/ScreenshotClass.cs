using OpenQA.Selenium;
using select_service_us_canada.mixture_acids_validation.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_service_us_canada.mixture_acids_validation.Utilities
{
    class ScreenshotClass
    {
        public static void ScreenshotClasses(string stepinfo)
        {
            var takesScreenshot = BrowserConfig.webDriver as ITakesScreenshot;
            if (takesScreenshot != null)
            {
                var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\mixture_acids_validation");
                DirectoryInfo di = Directory.CreateDirectory(path + "\\Screenshots");
                //var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
                var screenshot = takesScreenshot.GetScreenshot();
                var tempFileName = Path.Combine(path + "\\Screenshots", Path.GetFileNameWithoutExtension(stepinfo)) + ".jpg";
                var _filePath = tempFileName.Replace(" and then click on Done button to complete the verification process","");
                screenshot.SaveAsFile(_filePath, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);

                Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");

            }
        }
    }
}
