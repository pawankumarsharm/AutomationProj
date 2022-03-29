using SalemWeb.ConfigFiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SalemWeb.Bindings
{
    [Binding]
    [Scope(Feature = "SoftwarePortal")]
    public sealed class SoftwarePortalVal
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //TODO: implement logic that has to run before executing each scenario
            BrowserConfig.Init();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            //TODO: implement logic that has to run after executing each scenario
            //BrowserConfig._driver = null;
            BrowserConfig._driver.Quit();
            //BrowserConfig._driver.Dispose();
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            //TODO: implement logic that has to run after executing each scenario
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            //Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            //foreach (var chromeDriverProcess in chromeDriverProcesses)
            //{
            //    chromeDriverProcess.Kill();
            //}

        }
    }
}

