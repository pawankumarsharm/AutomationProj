using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_service_us_canada.single_acid_validation.Utilities
{
    class ScreenshotClass
    {
        public static void ScreenshotClasses(string stepinfo)
        {
            var takesScreenshot = Configurations.BrowserAndUrlConfig.webDriver as ITakesScreenshot;
            if (takesScreenshot != null)
            {
                var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\single_acid_validation");
                DirectoryInfo di = Directory.CreateDirectory(path + "\\Screenshots");
                //var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
                var screenshot = takesScreenshot.GetScreenshot();
                Console.WriteLine(Path.GetFileNameWithoutExtension(stepinfo));
                var tempFileName = Path.Combine(path + "\\Screenshots", Path.GetFileNameWithoutExtension(stepinfo)) + ".jpg";

                screenshot.SaveAsFile(tempFileName, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);

                Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");

            }
        }
    }
}
