using OpenQA.Selenium;
using SelectFrance.BrowsersConfigs;
using SelectFrance.StepsDefination;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectFrance.Helpers
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
        //public static void SelectOilQuestion(string _oilQuestion, bool _doubleValue, string _textData)
        //{
        //    string _oilData = "Y a-t-il des brouillards d'huile ou des aérosols ?";
        //    //string _oilData = "是否存在油雾或其他油性颗粒物？";
        //    string _gasData = "Vos contaminants sont des gaz ou des vapeurs. Des particules sont-elles également présentes (p. ex., brouillard de peinture au pistolet) ?";
        //    //string _gasData = "您的污染物为气体或蒸气。是否也存在颗粒物（例如：喷漆产生的漆雾）呢？";
        //    // string _nonHazardous = "您的污染物为颗粒物。是否也存在不构成危害水平的气体或蒸气呢？";
        //    string _nonHazardous = "Vos contaminants sont des particules. Des niveaux non dangereux de gaz ou de vapeurs sont-ils également présents ?"; 
        //    if (_doubleValue)
        //    {

        //        if (_textData.Equals(_oilData))
        //        {
        //            //Oil is to be selected first
        //            if (_oilQuestion != null)
        //            {
        //                if (_oilQuestion == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._firstYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
        //                }
        //                else if (_oilQuestion == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._firstNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Oil Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_gasData))
        //        {
        //            //Oil is to be selected second
        //            if (_oilQuestion != null)
        //            {
        //                if (_oilQuestion == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
        //                }
        //                else if (_oilQuestion == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Oil Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_nonHazardous))
        //        {
        //            //Oil is to be selected second
        //            if (_oilQuestion != null)
        //            {
        //                if (_oilQuestion == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
        //                }
        //                else if (_oilQuestion == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Oil Value is null");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (_textData.Equals(_oilData))
        //        {
        //            //Oil is first
        //            if (_oilQuestion != null)
        //            {
        //                if (_oilQuestion == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._firstYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstYes)).Click();
        //                }
        //                else if (_oilQuestion == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._firstNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._firstNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Oil Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_nonHazardous))
        //        {
        //            //Oil is first
        //            if (_oilQuestion != null)
        //            {
        //                if (_oilQuestion == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
        //                }
        //                else if (_oilQuestion == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Oil Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_gasData))
        //        {
        //            //Oil is second
        //            if (_oilQuestion != null)
        //            {
        //                if (_oilQuestion == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondYes)).Click();
        //                }
        //                else if (_oilQuestion == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._secondNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._secondNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Oil Value is null");
        //            }
        //        }

        //    }
        //}
        /// <summary>
        /// Function to Select Gas Question.
        /// </summary>
        /// <param name="_gasQuestions"></param>
        /// <param name="_doubleValue"></param>
        /// <param name="_textData"></param>
        public static void SelectGasQuestion(string _gasQuestions, bool _doubleValue, string _textData)
        {
            string _oilData = "Y a-t-il des brouillards d'huile ou des aérosols ?";
            string _nonHazardous = "Vos contaminants sont des gaz ou des vapeurs. Des particules sont-elles également présentes (p. ex., brouillard de peinture au pistolet) ?";
            string _gasData = "Vos contaminants sont des particules. Des niveaux non dangereux de gaz ou de vapeurs sont-ils également présents ?";
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
                        SelectFranceSteps.Logger.Info("Gas Value is null");
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
                        SelectFranceSteps.Logger.Info("Gas Value is null");
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
                        SelectFranceSteps.Logger.Info("Gas Value is null");
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
                        SelectFranceSteps.Logger.Info("Gas Value is null");
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
                        SelectFranceSteps.Logger.Info("Gas Value is null");
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
                        SelectFranceSteps.Logger.Info("Gas Value is null");
                    }
                }

            }
        }
        //thermal question for China///////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Function to Select Gas Question.
        /// </summary>
        /// <param name="_gasQuestions"></param>
        /// <param name="_doubleValue"></param>
        /// <param name="_textData"></param>
        //public static void SelectThermalQuestion(string _thermalQuestions, bool _doubleValue, string _textData)
        //{
        //    string _oilData = "是否存在油雾或其他油性颗粒物？";
        //    string _gasData = "您的污染物为气体或蒸气。是否也存在颗粒物（例如：喷漆产生的漆雾）呢？";
        //    string _nonHazardous = "您的污染物为颗粒物。是否也存在不构成危害水平的气体或蒸气呢？";
        //    if (_doubleValue)
        //    {

        //        if (_textData.Equals(_gasData))
        //        {
        //            //Gas is to be selected first
        //            if (_thermalQuestions != null)
        //            {
        //                if (_thermalQuestions == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdYes)).Click();
        //                }
        //                else if (_thermalQuestions == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Gas Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_oilData))
        //        {
        //            //Gas is to be selected second
        //            if (_thermalQuestions != null)
        //            {
        //                if (_thermalQuestions == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdYes)).Click();
        //                }
        //                else if (_thermalQuestions == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Gas Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_nonHazardous))
        //        {
        //            //Gas is to be selected second
        //            if (_thermalQuestions != null)
        //            {
        //                if (_thermalQuestions == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdYes)).Click();
        //                }
        //                else if (_thermalQuestions == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Gas Value is null");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (_textData.Equals(_gasData))
        //        {
        //            //Gas is first
        //            if (_thermalQuestions != null)
        //            {
        //                if (_thermalQuestions == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdYes)).Click();
        //                }
        //                else if (_thermalQuestions == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Gas Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_nonHazardous))
        //        {
        //            //Gas is first
        //            if (_thermalQuestions != null)
        //            {
        //                if (_thermalQuestions == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdYes)).Click();
        //                }
        //                else if (_thermalQuestions == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Gas Value is null");
        //            }
        //        }
        //        else if (_textData.Equals(_oilData))
        //        {
        //            //Gas is second
        //            if (_thermalQuestions != null)
        //            {
        //                if (_thermalQuestions == "Yes")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdYes);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdYes)).Click();
        //                }
        //                else if (_thermalQuestions == "No")
        //                {
        //                    ExplicitWaits.WaitForAnElement(Containers._thirdNo);
        //                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers._thirdNo)).Click();
        //                }
        //            }
        //            else
        //            {
        //                SelectFranceSteps.Logger.Info("Gas Value is null");
        //            }
        //        }

        //    }
        //}
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
                    SelectFranceSteps.Logger.Info("Setting the value of Respirator as Reusable");
                    FilterClass(_filter);
                    CartidgeType(_cartidge);
                }
                else if (_respiratorType == "PAPR")
                {
                    // ExplicitWait.WaitForAnElement(Containers.txtParp);
                    SelectFranceSteps.Logger.Info("Setting the value of Respirator as PARP");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.txtParp)).Click();
                    FilterClass(_filter);
                    CartidgeType(_cartidge);
                }
                else if (_respiratorType == "Disposable")
                {
                    //   ExplicitWait.WaitForAnElement(Containers.txtDisposable);
                    SelectFranceSteps.Logger.Info("Setting the value of Respirator as Disposable");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.txtDisposable)).Click();
                    FilterClass(_filter);
                    CartidgeType(_cartidge);
                }
            }
            else
            {
                SelectFranceSteps.Logger.Info("Respirator Type Value is null");
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
                SelectFranceSteps.Logger.Info("Value of Filter Class is Null.......Skipping Filter Class field");
                _filterClass = null;
            }
            if (_filterClass != null)
            {
                if (_filterClass == "P1")
                {
                    SelectFranceSteps.Logger.Info("Setting the value of Filter Class as P1");
                    ExplicitWaits.WaitForAnElement(Containers.btnP1);
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.btnP1)).Click();
                }
                else if (_filterClass == "P2")
                {
                    SelectFranceSteps.Logger.Info("Setting the value of Filter Class as P2");
                    ExplicitWaits.WaitForAnElement(Containers.btnP2);
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.btnP2)).Click();
                }
                else if (_filterClass == "P3")
                {
                    SelectFranceSteps.Logger.Info("Setting the value of Filter Class as P3");
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
                SelectFranceSteps.Logger.Info("Value of Cartidge Type is Null.......Skipping Cartidge Type field");
                _cartidge = null;
            }
            if (_cartidge != null)
            {
                if (_cartidge == "Formaldehyde" || _cartidge == "Form")
                {
                    ExplicitWaits.WaitForAnElement(Containers.formaldehyde_ele);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Formaldehyde");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.formaldehyde_ele)).Click();
                }
                else if (_cartidge == "Multigas/Vapor" || _cartidge == "Multi")
                {
                    ExplicitWaits.WaitForAnElement(Containers.multi_vapor_ele);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Multigas/Vapor");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.multi_vapor_ele)).Click();
                }
                else if (_cartidge == "Organic Vapor" || _cartidge == "VO")
                {
                    ExplicitWaits.WaitForAnElement(Containers.organi_vapor);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Organic Vapor");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.organi_vapor)).Click();
                }
                else if (_cartidge == "Organic Vapor/Acid Gas" || _cartidge == "VO/GA")
                {
                    ExplicitWaits.WaitForAnElement(Containers.organic_acid_vapor);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Organic Vapor/Acid Gas");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.organic_acid_vapor)).Click();
                }
                else if (_cartidge == "Ammonia" || _cartidge == "AM")
                {
                    ExplicitWaits.WaitForAnElement(Containers.ammonia);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Ammonia");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.ammonia)).Click();
                }
                else if (_cartidge == "Acid Gas" || _cartidge == "GA")
                {
                    ExplicitWaits.WaitForAnElement(Containers.acid_gas);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Acid Gas");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.acid_gas)).Click();
                }
                else if (_cartidge == "Mercury Vapor")
                {
                    ExplicitWaits.WaitForAnElement(Containers.mercury_vapor);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Mercury Vapor");
                    BrowserConfigs.webDriver.FindElement(By.XPath(Containers.mercury_vapor)).Click();
                }
                else if (_cartidge == "Hydrogen Fluoride")
                {
                    ExplicitWaits.WaitForAnElement(Containers.hydrogen_fluoride);
                    SelectFranceSteps.Logger.Info("Setting the value of Cartidge Type as Hydrogen Fluoride");
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
            SelectFranceSteps.Logger.Info("Clicking on Done button after validating the Contaminants");
            ExplicitWaits.WaitForAnElement(Containers._doneBtn);
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._doneBtn)).Click();
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
