
using NUnit.Framework;
using OpenQA.Selenium;
using SelectGermany.BrowsersConfigs;
using SelectGermany.StepsDefination;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SelectGermany.Helpers
{
    class CartidgeValidation:Containers
    {
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        protected static string destinationfile = "";
        protected static string sourcefile = "";
        public static void ValidateListItems(string _casNumber, string region, string total_ele, string sno, string _txtMsg)
        {
            int final_ele_count = Int32.Parse(total_ele);
            List<string> _cartidgeData = new List<string>();
            if (_txtMsg == "")
            {
                _txtMsg = null;
            }
            else
            {
                GermanySelectSteps.Logger.Info("3M does not have appropriate filters for one or more of your contaminants");
            }
            if (_txtMsg != null)
            {
                ExplicitWaits.WaitForAnElement(Containers._noResultMessage);
                string _txtMessage = BrowserConfigs.webDriver.FindElement(By.XPath(Containers._noResultMessage)).Text;
                Assert.AreEqual(_txtMsg, _txtMessage);
            }
            else
            {
                IList<IWebElement> _cartidges = BrowserConfigs.webDriver.FindElements(By.CssSelector(Containers._cartidgescount));
                if ((_cartidges.Count()).Equals(final_ele_count))
                {
                    GermanySelectSteps.Logger.Info("Elements number matched......Proceeding to match the elements");
                    Console.WriteLine("Elements number matched......Proceeding to match the elements");
                }
                else
                {

                   Assert.Fail("Elements number mismatched... Expecting total number to be " + final_ele_count + " but was " + _cartidges.Count());
                }
                foreach (IWebElement item in _cartidges)
                {
                    _cartidgeData.Add(item.Text);
                }

                //Check if the DataFile Directory for exists
                string aus_data_dir = path + "\\DataFileGermany";
                //Check if the directory exists               
                bool dirAusNz = (System.IO.Directory.Exists(aus_data_dir) ? true : false);
                //Create directory if does not exists               
                if (dirAusNz)
                {
                    Console.WriteLine("Directory exists");
                }
                else
                {
                    Directory.CreateDirectory(aus_data_dir);
                }
                //Now working on input file

                if (region == "Germany")
                {
                    // Console.WriteLine(stringlist);
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    sourcefile = Path.Combine(aus_data_dir, Path.GetFileNameWithoutExtension(stepinfo)) + " " + sno + " and cas " + _casNumber + ".txt";
                    bool testdatafileexists = (System.IO.File.Exists(sourcefile));
                    if (testdatafileexists)
                    {
                        Console.WriteLine("File already exists");
                    }
                    else
                    {
                        System.IO.File.WriteAllLines(sourcefile, _cartidgeData);

                    }
                }

                //Now working on real time data files
                //Create directory for runtime files
                //Check if the DataFile for  exists                
                var aus_data_runtime = path + "\\RunTimeFileGermany";
                //Check if the directory exists               
                bool dirAusRunTime = (System.IO.Directory.Exists(aus_data_runtime) ? true : false);
                if (dirAusRunTime)
                {
                    Console.WriteLine("Directory exists");
                }
                else
                {
                    Directory.CreateDirectory(aus_data_runtime);
                }
                if (region == "Germany")
                {
                    //Console.WriteLine(stringlist);
                    //List<string> _internalList = new List<string>();
                    //_internalList = stringlist;
                    //stringlist.Clear();
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    destinationfile = Path.Combine(aus_data_runtime, Path.GetFileNameWithoutExtension(stepinfo)) + " " + sno + " and cas " + _casNumber + ".txt";
                    bool fileExists = System.IO.File.Exists(destinationfile);
                    if (fileExists)
                    {
                        System.IO.File.Delete(destinationfile);
                    }

                    System.IO.File.WriteAllLines(destinationfile, _cartidgeData);
                    //_internalList.Clear();
                    //Console.WriteLine(stringlist);
                    _cartidgeData.Clear();
                }

                // Compare the files
                //var DataMatching = System.IO.File.ReadLines(sourcefile).SequenceEqual((System.IO.File.ReadLines(destinationfile)));
                List<string> fileSource = new List<string>();
                fileSource = System.IO.File.ReadAllLines(sourcefile).ToList();
                List<string> fileDestination = new List<string>();
                fileDestination = System.IO.File.ReadAllLines(destinationfile).ToList();
                bool isEqual = Enumerable.SequenceEqual(fileSource.OrderBy(e => e), fileDestination.OrderBy(e => e));
                if (isEqual)
                {
                    Console.WriteLine("Data Matched");
                }
                else
                {
                    Assert.Fail("Data Mismatched");
                }

            }
        }
    }
}
