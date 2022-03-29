
using log4net;
using OpenQA.Selenium;
using SelectGermany.BrowsersConfigs;
using SelectGermany.Helpers;
using SelectGermany.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SelectGermany.StepsDefination 
{
    [Binding]
    public class GermanySelectSteps : Containers
    {
        public static ILog Logger = GenerateLogs.GetLogger(typeof(GermanySelectSteps));
        public bool _doubleValue = false;


        [Given(@"I have navigated to the SLS Website")]
    public void GivenIHaveNavigatedToTheSLSWebsite()
    {
        Logger.Info("Searching for Browser Type in App Config");
        BrowserConfigs.Init();
    }

    [When(@"I select the  (.*) provided  and click on the next button")]
    public void WhenISelectTheProvidedAndClickOnTheNextButton(string _region)
    {
        string _countryRegion = _region.ToLower();
        if (_countryRegion.Equals("germany"))
        {
            Logger.Info("Selected region as Germany");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._Germanycountry)).Click();
            Thread.Sleep(4000);
        }
        //Wait for next button to be visible.
        ExplicitWaits.WaitForAnElement(Containers._btnNextCountry);

        Logger.Info("Clicking on next button after selecting the region");
        BrowserConfigs.webDriver.FindElement(By.XPath(Containers._btnNextCountry)).Click();
    }

    [Then(@"I select Cartidge/Filter check box and proceed further till data validation")]
    public void ThenISelectCartidgeFilterCheckBoxAndProceedFurtherTillDataValidation()
    {
        ExplicitWaits.WaitForAnElement(Containers._selectRadio);
        Logger.Info("Selecting Cartidge/Filter Section");
        BrowserConfigs.webDriver.FindElement(By.XPath(Containers._selectRadio)).Click();
        BrowserConfigs.webDriver.FindElement(By.XPath(Containers._elsiAcceptBtn)).Click();
        Logger.Info("Clicking on IAccept button after selecting Cartidge/Filter Section");
        ExplicitWaits.WaitForAnElement(Containers._oxygenDefiency);
        //Tap on the No button asking for severity issue
        BrowserConfigs.webDriver.FindElement(By.XPath(Containers._oxygenDefiency)).Click();
        Logger.Info("Is there a potential for oxygen deficiency, unknown environments, or contaminant concentrations that are immediately dangerous to life or health?");
    }

    [Then(@"I have (.*) and (.*) to filter the product and I filter the product")]
    public void ThenIHaveAndToFilterTheProductAndIFilterTheProduct(string _cas, string contaminant)
    {
        ExplicitWaits.WaitForAnElement(Containers._casSearch);
        if (_cas == "" || _cas.Equals("none") || _cas.Equals("varies") || _cas.Equals("vários"))
        {
            Logger.Info("Value of Cas is null....Sending Contaminant " + contaminant + " in the search field");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._casSearch)).SendKeys(contaminant);
        }
        else
        {
            Logger.Info("Entering the value of CAS as " + _cas + " in the Search field to filter the contaminants");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._casSearch)).SendKeys(_cas);
        }
    }

    [Then(@"I select the filtered products using the Cas (.*) or the Contaminants Value (.*)")]
    public void ThenISelectTheFilteredProductsUsingTheCasOrTheContaminantsValue(string _cas, string contaminants)
    {
        if (contaminants.Equals("ManganeseRespirable") || (contaminants.Equals("Ozone, light work")))
        {
            ExplicitWaits.WaitForAnElement(Containers._mgnseReschkBx);
            Logger.Info("Selecting the filtered contaminant");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._mgnseReschkBx)).Click();
        }
        else if (contaminants.Equals("Nickel soluble "))
        {
            ExplicitWaits.WaitForAnElement(Containers._nickelSoluble);
            Logger.Info("Selecting the filtered contaminant");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._nickelSoluble)).Click();

        }
        else if (contaminants.Equals("Ozone, moderate work"))
        {
            ExplicitWaits.WaitForAnElement(Containers._ozoneHeavy);
            Logger.Info("Selecting the filtered contaminant");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._ozoneHeavy)).Click();
        }
        else if (contaminants.Equals("Arsênio, compostos orgânicos (como As)"))
        {
            ExplicitWaits.WaitForAnElement(Containers._aerosolOrganic);
            Logger.Info("Selecting the filtered contaminant");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._aerosolOrganic)).Click();
        }
        else
        {
            ExplicitWaits.WaitForAnElement(Containers._contaminantChckBox);
            Logger.Info("Selecting the filtered contaminant");
            BrowserConfigs.webDriver.FindElement(By.XPath(Containers._contaminantChckBox)).Click();
        }
    }

    [Then(@"Click on the next button")]
    public void ThenClickOnTheNextButton()
    {
        Logger.Info("Clicking on next button.");
        BrowserConfigs.webDriver.FindElement(By.XPath(Containers._btnNextCountry)).Click();
    }
    [Then(@"I Filter the contaminants using the filter values (.*),(.*),(.*),(.*),(.*),(.*) and (.*)")]
    public void ThenIFilterTheContaminantsUsingTheFilterValuesAnd(string _gasQuestions, string _particle, string _respiratorType, string _filterClass, string _cartidgeType, string _casNumber, string _txtMsg)
    {
        string _txtOil = "Y a-t-il des brouillards d'huile ou des aérosols ?";
        // string _txtGas = "Sus contaminantes son partículas. ¿También existen niveles no peligrosos de gases o vapores?";
        string _nonHazardous = "Vos contaminants sont des gaz ou des vapeurs. Des particules sont-elles également présentes (p. ex., brouillard de peinture au pistolet) ?";
        string _txtGas = "Vos contaminants sont des particules. Des niveaux non dangereux de gaz ou de vapeurs sont-ils également présents ?";
        if (_txtMsg == "" || _txtMsg == "<txtMessage>")
        {
            _txtMsg = null;
        }
        else
        {
            Logger.Info(_txtMsg);
        }
        if (_txtMsg != null)
        {
            Logger.Info("No filters available for one or more of your contaminants");
            //if (_oilQuestion == "")
            //{
            //    _oilQuestion = null;
            //}
            if (_particle == "")
            {
                _particle = null;
            }
            if (_gasQuestions == "")
            {
                _gasQuestions = null;
            }
            //if (_thermalQuestions == "")
            //{
            //    _thermalQuestions = null;
            //}
            bool _trigger = (_particle == null && _gasQuestions == null);
            if (_trigger)
            {
                Logger.Info("No filters available for one or more of your contaminants");
            }

            else
            {
                Logger.Info("No filters available for one or more of your contaminants");
                ExplicitWaits.WaitForAnElement(Containers._textMessage);
                string _textData = BrowserConfigs.webDriver.FindElement(By.XPath(Containers._textMessage)).Text;
                if (_gasQuestions == null)
                {
                    if (_particle != null)
                    {
                        _gasQuestions = _particle;
                    }
                    else
                    {
                        //_gasQuestions = null;
                        Logger.Info("The value of Gas is" + _gasQuestions + " and value of Particles is " + _particle);
                    }
                }
                if (_particle != null && _gasQuestions != null)
                {
                    _doubleValue = _particle.Equals(_gasQuestions) ? true : false;
                }

                if (_textData.Equals(_txtOil))
                {
                    //SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
                    SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
                    //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
                }
                else if (_textData.Equals(_txtGas))
                {

                    SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
                    // SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
                    //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
                }
                else if (_textData.Equals(_nonHazardous))
                {
                    SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
                    //SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
                    // SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
                }
                SupportingFunctions.SelectRespiratorType(_respiratorType, _filterClass, _cartidgeType);
                SupportingFunctions.ClickDone();
            }
            // CartidgeValidation.ValidateListItem(_cas, _region, _totalCount, _serial, _txtMsg);

        }
        else
        {
            ExplicitWaits.WaitForAnElement(Containers._textMessage);
            string _textData = BrowserConfigs.webDriver.FindElement(By.XPath(Containers._textMessage)).Text;

            //if (_oilQuestion == "")
            //{
            //    _oilQuestion = null;
            //}
            if (_particle == "")
            {
                _particle = null;
            }
            if (_gasQuestions == "")
            {
                _gasQuestions = null;
            }
            //if (_thermalQuestions == "")
            //{
            //    _thermalQuestions = null;
            //}

            if (_gasQuestions == null)
            {
                if (_particle != null)
                {
                    _gasQuestions = _particle;
                }
                else
                {
                    _gasQuestions = null;
                }
            }
            if (_particle != null && _gasQuestions != null)
            {
                _doubleValue = _particle.Equals(_gasQuestions) ? true : false;
            }

            if (_textData.Equals(_txtOil))
            {
                // SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
                SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
                // SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
            }
            else if (_textData.Equals(_txtGas))
            {

                SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
                // SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
                //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
            }
            else if (_textData.Equals(_nonHazardous))
            {
                SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
                //SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
                //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
            }
            SupportingFunctions.SelectRespiratorType(_respiratorType, _filterClass, _cartidgeType);
            SupportingFunctions.ClickDone();
        }
        Thread.Sleep(1000);
    }


    //[Then(@"I Filter the contaminants using the filter values (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*) and (.*)")]
    //public void ThenIFilterTheContaminantsUsingTheFilterValuesAnd(string _gasQuestions, string _oilQuestion, string _thermalQuestions, string _particle, string _respiratorType, string _filterClass, string _cartidgeType, string _casNumber, string _txtMsg)
    //{
    //    string _txtOil = "Y a-t-il des brouillards d'huile ou des aérosols ?";
    //    // string _txtGas = "Sus contaminantes son partículas. ¿También existen niveles no peligrosos de gases o vapores?";
    //    string _txtGas = "Vos contaminants sont des gaz ou des vapeurs. Des particules sont-elles également présentes (p. ex., brouillard de peinture au pistolet) ?";
    //    string _nonHazardous = "Vos contaminants sont des particules. Des niveaux non dangereux de gaz ou de vapeurs sont-ils également présents ?";
    //    if (_txtMsg == "" || _txtMsg == "<txtMessage>")
    //    {
    //        _txtMsg = null;
    //    }
    //    else
    //    {
    //        Logger.Info(_txtMsg);
    //    }
    //    if (_txtMsg != null)
    //    {
    //        Logger.Info("No filters available for one or more of your contaminants");
    //        if (_oilQuestion == "")
    //        {
    //            _oilQuestion = null;
    //        }
    //        if (_particle == "")
    //        {
    //            _particle = null;
    //        }
    //        if (_gasQuestions == "")
    //        {
    //            _gasQuestions = null;
    //        }
    //        if (_thermalQuestions == "")
    //        {
    //            _thermalQuestions = null;
    //        }
    //        bool _trigger = (_oilQuestion == null && _particle == null && _gasQuestions == null && _thermalQuestions == null);
    //        if (_trigger)
    //        {
    //            Logger.Info("No filters available for one or more of your contaminants");
    //        }

    //        else
    //        {
    //            Logger.Info("No filters available for one or more of your contaminants");
    //            ExplicitWaits.WaitForAnElement(Containers._textMessage);
    //            string _textData = BrowserConfigs.webDriver.FindElement(By.XPath(Containers._textMessage)).Text;
    //            if (_gasQuestions == null)
    //            {
    //                if (_particle != null)
    //                {
    //                    _gasQuestions = _particle;
    //                }
    //                else
    //                {
    //                    //_gasQuestions = null;
    //                    Logger.Info("The value of Gas is" + _gasQuestions + " and value of Particles is " + _particle);
    //                }
    //            }
    //            if (_oilQuestion != null && _gasQuestions != null)
    //            {
    //                _doubleValue = _oilQuestion.Equals(_gasQuestions) ? true : false;
    //            }

    //            if (_textData.Equals(_txtOil))
    //            {
    //                SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
    //                SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
    //                //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
    //            }
    //            else if (_textData.Equals(_txtGas))
    //            {

    //                SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
    //                SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
    //                //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
    //            }
    //            else if (_textData.Equals(_nonHazardous))
    //            {
    //                SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
    //                SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
    //               // SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
    //            }
    //            SupportingFunctions.SelectRespiratorType(_respiratorType, _filterClass, _cartidgeType);
    //            SupportingFunctions.ClickDone();
    //        }
    //        // CartidgeValidation.ValidateListItem(_cas, _region, _totalCount, _serial, _txtMsg);

    //    }
    //    else
    //    {
    //        ExplicitWaits.WaitForAnElement(Containers._textMessage);
    //        string _textData = BrowserConfigs.webDriver.FindElement(By.XPath(Containers._textMessage)).Text;

    //        if (_oilQuestion == "")
    //        {
    //            _oilQuestion = null;
    //        }
    //        if (_particle == "")
    //        {
    //            _particle = null;
    //        }
    //        if (_gasQuestions == "")
    //        {
    //            _gasQuestions = null;
    //        }
    //        if (_thermalQuestions == "")
    //        {
    //            _thermalQuestions = null;
    //        }

    //        if (_gasQuestions == null)
    //        {
    //            if (_particle != null)
    //            {
    //                _gasQuestions = _particle;
    //            }
    //            else
    //            {
    //                _gasQuestions = null;
    //            }
    //        }
    //        if (_oilQuestion != null && _gasQuestions != null)
    //        {
    //            _doubleValue = _oilQuestion.Equals(_gasQuestions) ? true : false;
    //        }

    //        if (_textData.Equals(_txtOil))
    //        {
    //            SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
    //            SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
    //           // SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
    //        }
    //        else if (_textData.Equals(_txtGas))
    //        {

    //            SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
    //            SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
    //            //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
    //        }
    //        else if (_textData.Equals(_nonHazardous))
    //        {
    //            SupportingFunctions.SelectGasQuestion(_gasQuestions, _doubleValue, _textData);
    //            SupportingFunctions.SelectOilQuestion(_oilQuestion, _doubleValue, _textData);
    //            //SupportingFunctions.SelectThermalQuestion(_thermalQuestions, _doubleValue, _textData);
    //        }
    //        SupportingFunctions.SelectRespiratorType(_respiratorType, _filterClass, _cartidgeType);
    //        SupportingFunctions.ClickDone();
    //    }
    //    Thread.Sleep(1000);
    //}

    [Then(@"I do the final validation of the elements with the serial no\. (.*) , (.*),(.*),(.*) and (.*)")]
    public void ThenIDoTheFinalValidationOfTheElementsWithTheSerialNo_And(string _serial, string _cas, string _region, string _txtMsg, string _totalCount)
    {
        CartidgeValidation.ValidateListItems(_cas, _region, _totalCount, _serial, _txtMsg);
    }
}
}
