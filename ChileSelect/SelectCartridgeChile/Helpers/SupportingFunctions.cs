using NUnit.Framework;
using OpenQA.Selenium;
using SelectCartridgeChile.BrowsersConfigs;
using SelectCartridgeChile.StepsDefination;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SelectCartridgeChile.Helpers
{
    class SupportingFunctions:Containers
    {
        public static int inner_item_size = 0;
        public static int _rowCount = 3;
        public static string _fileName = "";
        //public static List<string> stringlist = new List<string>();
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        public static string destinationfile = "";
        public static string sourcefile = "";

        /// <summary>
        /// Function to select the Oil Question.
        /// </summary>
        /// <param name="_oilQuestion"></param>
        /// <param name="_doubleValue"></param>
        /// <param name="_textData"></param>
        public static void SelectOilQuestion(string _oilQuestion, bool _doubleValue, string _textData)
        {
            //string _oilData = "Are there oil mists or aerosols present?";
            string _oilData = "¿Hay presencia de aerosoles de aceites?";
            //string _gasData = "Sus contaminantes son partículas. ¿También existen niveles no peligrosos de gases o vapores?";
            string _gasData = "Sus contaminantes son gases o vapores. ¿También hay partículas presentes (por ejemplo, niebla de pintura en aerosol)?";
            string _nonHazardous = "Sus contaminantes son partículas. ¿También existen niveles no peligrosos de gases o vapores?";
            if (_doubleValue)
            {

                if (_textData.Equals(_oilData))
                {
                    //Oil is to be selected first
                    if (_oilQuestion != null)
                    {
                        if (_oilQuestion == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
                        }
                        else if (_oilQuestion == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Oil Value is null");
                    }
                }
                else if (_textData.Equals(_gasData))
                {
                    //Oil is to be selected second
                    if (_oilQuestion != null)
                    {
                        if (_oilQuestion == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
                        }
                        else if (_oilQuestion == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Oil Value is null");
                    }
                }
                else if (_textData.Equals(_nonHazardous))
                {
                    //Oil is to be selected second
                    if (_oilQuestion != null)
                    {
                        if (_oilQuestion == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
                        }
                        else if (_oilQuestion == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Oil Value is null");
                    }
                }
            }
            else
            {
                if (_textData.Equals(_oilData))
                {
                    //Oil is first
                    if (_oilQuestion != null)
                    {
                        if (_oilQuestion == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
                        }
                        else if (_oilQuestion == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Oil Value is null");
                    }
                }
                else if (_textData.Equals(_nonHazardous))
                {
                    //Oil is first
                    if (_oilQuestion != null)
                    {
                        if (_oilQuestion == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
                        }
                        else if (_oilQuestion == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Oil Value is null");
                    }
                }
                else if (_textData.Equals(_gasData))
                {
                    //Oil is second
                    if (_oilQuestion != null)
                    {
                        if (_oilQuestion == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
                        }
                        else if (_oilQuestion == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Oil Value is null");
                    }
                }

            }
        }
        /// <summary>
        /// Function to Select Gas Question.
        /// </summary>
        /// <param name="_gasQuestions"></param>
        /// <param name="_doubleValue"></param>
        /// <param name="_textData"></param>
        public static void SelectGasQuestion(string _gasQuestions, bool _doubleValue, string _textData)
        {
            string _oilData = "¿Hay presencia de aerosoles de aceites?";
            string _gasData = "Sus contaminantes son gases o vapores. ¿También hay partículas presentes (por ejemplo, niebla de pintura en aerosol)?";
            string _nonHazardous = "Sus contaminantes son partículas. ¿También existen niveles no peligrosos de gases o vapores?";
            if (_doubleValue)
            {

                if (_textData.Equals(_gasData))
                {
                    //Gas is to be selected first
                    if (_gasQuestions != null)
                    {
                        if (_gasQuestions == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
                        }
                        else if (_gasQuestions == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Gas Value is null");
                    }
                }
                else if (_textData.Equals(_oilData))
                {
                    //Gas is to be selected second
                    if (_gasQuestions != null)
                    {
                        if (_gasQuestions == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
                        }
                        else if (_gasQuestions == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Gas Value is null");
                    }
                }
                else if (_textData.Equals(_nonHazardous))
                {
                    //Gas is to be selected second
                    if (_gasQuestions != null)
                    {
                        if (_gasQuestions == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
                        }
                        else if (_gasQuestions == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Gas Value is null");
                    }
                }
            }
            else
            {
                if (_textData.Equals(_gasData))
                {
                    //Gas is first
                    if (_gasQuestions != null)
                    {
                        if (_gasQuestions == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
                        }
                        else if (_gasQuestions == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Gas Value is null");
                    }
                }
                else if (_textData.Equals(_nonHazardous))
                {
                    //Gas is first
                    if (_gasQuestions != null)
                    {
                        if (_gasQuestions == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
                        }
                        else if (_gasQuestions == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._firstNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Gas Value is null");
                    }
                }
                else if (_textData.Equals(_oilData))
                {
                    //Gas is second
                    if (_gasQuestions != null)
                    {
                        if (_gasQuestions == "Yes")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondYes);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
                        }
                        else if (_gasQuestions == "No")
                        {
                            ExplicitWaits.WaitForAnElement(Containers._secondNo);
                            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
                        }
                    }
                    else
                    {
                        ChileSelectSteps.Logger.Info("Gas Value is null");
                    }
                }

            }
        }
        /// <summary>
        /// Function to Select the Respirator Type.
        /// </summary>
        /// <param name="_respiratorType"></param>
        /// <param name="_filter"></param>
        /// <param name="_cartidge"></param>
        public static void SelectRespiratorType(string _respiratorType, string _filter, string _cartidge)
        {
            if (_respiratorType != null)
            {
                if (_respiratorType == "Reusable")
                {
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.txtResuable)).Click();
                    ChileSelectSteps.Logger.Info("Setting the value of Respirator as Reusable");
                    FilterClass(_filter);
                    CartidgeType(_cartidge);
                }
                else if (_respiratorType == "PAPR")
                {
                    // ExplicitWait.WaitForAnElement(Containers.txtParp);
                    ChileSelectSteps.Logger.Info("Setting the value of Respirator as PARP");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.txtParp)).Click();
                    FilterClass(_filter);
                    CartidgeType(_cartidge);
                }
                else if (_respiratorType == "Disposable")
                {
                    //   ExplicitWait.WaitForAnElement(Containers.txtDisposable);
                    ChileSelectSteps.Logger.Info("Setting the value of Respirator as Disposable");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.txtDisposable)).Click();
                    FilterClass(_filter);
                    CartidgeType(_cartidge);
                }
            }
            else
            {
                ChileSelectSteps.Logger.Info("Respirator Type Value is null");
            }
        }
        /// <summary>
        /// Function to select Filter Class
        /// </summary>
        /// <param name="_filterClass"></param>
        public static void FilterClass(string _filterClass)
        {

            if (_filterClass == "")
            {
                ChileSelectSteps.Logger.Info("Value of Filter Class is Null.......Skipping Filter Class field");
                _filterClass = null;
            }
            if (_filterClass != null)
            {
                if (_filterClass == "P1")
                {
                    ChileSelectSteps.Logger.Info("Setting the value of Filter Class as P1");
                    ExplicitWaits.WaitForAnElement(Containers.btnP1);
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.btnP1)).Click();
                }
                else if (_filterClass == "P2")
                {
                    ChileSelectSteps.Logger.Info("Setting the value of Filter Class as P2");
                    ExplicitWaits.WaitForAnElement(Containers.btnP2);
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.btnP2)).Click();
                }
                else if (_filterClass == "P3")
                {
                    ChileSelectSteps.Logger.Info("Setting the value of Filter Class as P3");
                    ExplicitWaits.WaitForAnElement(Containers.btnP3);
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.btnP3)).Click();
                }
            }
            else
            {
                // ClickDone();
            }

        }
        /// <summary>
        /// Function to Select Caritdge Type
        /// </summary>
        /// <param name="_cartidge"></param>
        public static void CartidgeType(string _cartidge)
        {
            if (_cartidge == "")
            {
                ChileSelectSteps.Logger.Info("Value of Cartidge Type is Null.......Skipping Cartidge Type field");
                _cartidge = null;
            }
            if (_cartidge != null)
            {
                if (_cartidge == "Formaldehyde" || _cartidge == "Form")
                {
                    ExplicitWaits.WaitForAnElement(Containers.formaldehyde_ele);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Formaldehyde");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.formaldehyde_ele)).Click();
                }
                else if (_cartidge == "Multigas/Vapor" || _cartidge == "Multi")
                {
                    ExplicitWaits.WaitForAnElement(Containers.multi_vapor_ele);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Multigas/Vapor");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.multi_vapor_ele)).Click();
                }
                else if (_cartidge == "Organic Vapor" || _cartidge == "VO")
                {
                    ExplicitWaits.WaitForAnElement(Containers.organi_vapor);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Organic Vapor");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.organi_vapor)).Click();
                }
                else if (_cartidge == "Organic Vapor/Acid Gas" || _cartidge == "VO/GA")
                {
                    ExplicitWaits.WaitForAnElement(Containers.organic_acid_vapor);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Organic Vapor/Acid Gas");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.organic_acid_vapor)).Click();
                }
                else if (_cartidge == "Ammonia" || _cartidge == "AM")
                {
                    ExplicitWaits.WaitForAnElement(Containers.ammonia);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Ammonia");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.ammonia)).Click();
                }
                else if (_cartidge == "Acid Gas" || _cartidge == "GA")
                {
                    ExplicitWaits.WaitForAnElement(Containers.acid_gas);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Acid Gas");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.acid_gas)).Click();
                }
                else if (_cartidge == "Mercury Vapor")
                {
                    ExplicitWaits.WaitForAnElement(Containers.mercury_vapor);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Mercury Vapor");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.mercury_vapor)).Click();
                }
                else if (_cartidge == "Hydrogen Fluoride")
                {
                    ExplicitWaits.WaitForAnElement(Containers.hydrogen_fluoride);
                    ChileSelectSteps.Logger.Info("Setting the value of Cartidge Type as Hydrogen Fluoride");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.hydrogen_fluoride)).Click();
                }
            }
            else
            {
                //ClickDone();
            }

        }
        /// <summary>
        /// Function to Click Done Button in the end.
        /// </summary>
        public static void ClickDone()
        {
            ChileSelectSteps.Logger.Info("Clicking on Done button after validating the Contaminants");
            ExplicitWaits.WaitForAnElement(Containers._doneBtn);
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._doneBtn)).Click();
        }
        /// <summary>
        /// Function to final validate the Cartidges.
        /// </summary>
        /// <param name="_casNumber"></param>
        /// <param name="region"></param>
        /// <param name="total_ele"></param>
        /// <param name="sno"></param>
        /// <param name="_txtMsg"></param>
        public static void ValidateListItems(string _casNumber, string region, string total_ele, string sno, string _txtMsg)
        {
            if (_txtMsg == "")
            {
                _txtMsg = null;
            }
            else
            {
                ChileSelectSteps.Logger.Info("3M does not have appropriate filters for one or more of your contaminants");
            }
            if (_txtMsg != null)
            {
                ExplicitWaits.WaitForAnElement(Containers._noResultMessage);
                string _txtMessage = BrowserConfigs.webDriver.FindElement(By.XPath(Containers._noResultMessage)).Text;
                Assert.AreEqual(_txtMsg, _txtMessage);
            }
            else
            {
                //IList<IWebElement> _cartidges=BrowserConfigs.webDriver.FindElements(By.CssSelector(Containers._cartidgescount));
                //foreach(IWebElement item in _cartidges)
                //{
                //    Console.WriteLine(item.Text);
                //}
                List<string> stringlist = new List<string>();
                string datacontent = "";
                IList<IWebElement> parent_class_items = BrowserConfigs.webDriver.FindElements(By.ClassName("productItem-list"));
                int size = parent_class_items.Count();
                foreach (IWebElement element in parent_class_items)
                {
                    IList<IWebElement> inner_products_item = element.FindElements(By.TagName("li"));
                    inner_item_size = inner_products_item.Count();
                    int final_ele_count = Int32.Parse(total_ele);
                    if (inner_item_size.Equals(final_ele_count))
                    {
                        ChileSelectSteps.Logger.Info("Elements number matched......Proceeding to match the elements");
                        Console.WriteLine("Elements number matched......Proceeding to match the elements");
                        //WriteDataToExcel.ExcelCode(final_ele_count,_rowCount);
                        //_rowCount++;

                    }
                    else
                    {
                        //Assert.Fail("Elements number mismatched... Expecting total number to be " + final_ele_count + " but was " + inner_item_size);
                    }
                    foreach (IWebElement item in inner_products_item)
                    {
                        IList<IWebElement> header = item.FindElements(By.ClassName("productItemMedia-content-hd"));

                        Console.WriteLine(header.Count());

                        foreach (IWebElement value in header)
                        {
                            datacontent = value.Text;
                        }
                        stringlist.Add(datacontent);
                    }
                }

                // Check if the DataFile Directory for exists

                string brazil_data_dir = path + "\\DataFileChile";
                //Check if the directory exists               
                bool dirBrazil = (System.IO.Directory.Exists(brazil_data_dir) ? true : false);
                //Create directory if does not exists               
                if (dirBrazil)
                {
                    Console.WriteLine("Directory exists");
                }
                else
                {
                    Directory.CreateDirectory(brazil_data_dir);
                }
                //Now working on input file

                if (region == "Chile")
                {
                    Console.WriteLine(stringlist);
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    sourcefile = Path.Combine(brazil_data_dir, Path.GetFileNameWithoutExtension(stepinfo)) + " " + sno + " and cas " + _casNumber + ".txt";
                    List<string> _internalList = new List<string>();
                    // _internalList = stringlist;

                    bool testdatafileexists = (System.IO.File.Exists(sourcefile));
                    if (testdatafileexists)
                    {
                        Console.WriteLine("File already exists");
                    }
                    else
                    {
                        System.IO.File.WriteAllLines(sourcefile, stringlist);

                    }
                }
                //Now working on real time data files
                //Create directory for runtime files
                //Check if the DataFile for  exists                
                var brazil_data_runtime = path + "\\RunTimeFileChile";
                //Check if the directory exists               
                bool dirBrazilRunTime = (System.IO.Directory.Exists(brazil_data_runtime) ? true : false);
                if (dirBrazilRunTime)
                {
                    Console.WriteLine("Directory exists");
                }
                else
                {
                    Directory.CreateDirectory(brazil_data_runtime);
                }
                if (region == "Chile")
                {
                    Console.WriteLine(stringlist);
                    //List<string> _internalList = new List<string>();
                    //_internalList = stringlist;
                    //stringlist.Clear();
                    string stepinfo = ScenarioStepContext.Current.StepInfo.Text;
                    destinationfile = Path.Combine(brazil_data_runtime, Path.GetFileNameWithoutExtension(stepinfo)) + " " + sno + " and cas " + _casNumber + ".txt";
                    bool fileExists = System.IO.File.Exists(destinationfile);
                    if (fileExists)
                    {
                        System.IO.File.Delete(destinationfile);
                    }

                    System.IO.File.WriteAllLines(destinationfile, stringlist);
                    //_internalList.Clear();
                    //Console.WriteLine(stringlist);
                    stringlist.Clear();
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

        /// <summary>
        /// Function to Take Screenshots in case of Test Failure.
        /// </summary>
        /// <param name="stepinfo"></param>
        public static void TakingScreenshot(string stepinfo)
        {
            var takesScreenshot = BrowserConfigs.webDriver as ITakesScreenshot;
            if (takesScreenshot != null)
            {
                var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(path + "\\Screenshots");
                var screenshot = takesScreenshot.GetScreenshot();
                var tempFileName = Path.Combine(path + "\\Screenshots", Path.GetFileNameWithoutExtension(stepinfo)) + ".jpg";
                int _fileSize = tempFileName.Length;
                if (_fileSize > 248 || tempFileName.Contains("Supplied air respirators may be appropriate to help reduce exposure depending on the protection factor of the respirator chosen."))
                {
                    _fileName = tempFileName.Replace(",3M does not have an appropriate filter for one or more of your contaminants. Supplied air respirators may be appropriate to help reduce exposure depending on the protection factor of the respirator chosen. Please see the supplied air respirators below or contact 3M at 1-800-243-4630 for more information", "");
                }
                else
                {
                    _fileName = tempFileName;
                }
                screenshot.SaveAsFile(_fileName, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
                Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");

            }
        }
    }
}
