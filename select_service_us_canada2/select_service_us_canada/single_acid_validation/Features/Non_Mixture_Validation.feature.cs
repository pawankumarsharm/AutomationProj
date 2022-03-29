﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace select_service_us_canada.Single_Acid_Validation.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Non_Mixture_Validation")]
    public partial class Non_Mixture_ValidationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Non_Mixture_Validation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Non_Mixture_Validation", "\tValidating all the non-mixtures acid", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validating the life hours for each acids.")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.TestCaseAttribute("1", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "20", "Celsius", "Medium", "31 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("2", "Toulene", "108-88-3", "383.28", "mg/m3 ", "6001", "<65%", "1", "20", "Celsius", "Medium", "31 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("3", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "0", "Celsius", "Medium", "35 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("4", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "10", "Celsius", "Medium", "33 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("5", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "30", "Celsius", "Medium", "29 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("6", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "40", "Celsius", "Medium", "27 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("7", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "50", "Celsius", "Medium", "24 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("8", "Toulene", "108-88-3", "100", "ppm", "6003", "<65%", "1", "20", "Celsius", "Medium", "27 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("9", "Toulene", "108-88-3", "100", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "23 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("10", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "20", "Celsius", "Light", "63 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("11", "Toulene", "108-88-3", "100", "ppm", "6001", "<65%", "1", "20", "Celsius", "Heavy", "21 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("12", "Benzene", "71-43-2", "0.4", "ppm", "6003", "<65%", "1", "30", "Celsius", "Medium", "669 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("13", "Xylene (o-, m-, p-isomers)", "1330-20-7", "50", "ppm", "6001", "<65%", "0.8", "20", "Celsius", "Medium", "78 horas", "78", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("14", "Xylene (o-, m-, p-isomers)", "1330-20-7", "50", "ppm", "6001", "<65%", "1", "20", "Celsius", "Medium", "64 horas", "78", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("15", "Xylene (o-, m-, p-isomers)", "1330-20-7", "50", "ppm", "6001", "<65%", "1.2", "20", "Celsius", "Medium", "54 horas", "78", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("16", "Hexane (n-hexane)", "110-54-3", "10", "ppm", "6001", "<65%", "1", "20", "Celsius", "Medium", "110 horas", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("17", "Hexane (n-hexane)", "110-54-3", "10", "ppm", "6001", "0.65", "1", "20", "Celsius", "Medium", "42 horas", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("18", "Hexane (n-hexane)", "110-54-3", "10", "ppm", "6001", "75%", "1", "20", "Celsius", "Medium", "19 horas", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("19", "Hexane (n-hexane)", "110-54-3", "10", "ppm", "6001", "85%", "1", "20", "Celsius", "Medium", "13 horas", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("20", "Hexane (n-hexane)", "110-54-3", "10", "ppm", "6001", "90%", "1", "20", "Celsius", "Medium", "11 horas", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("21", "Hexane (n-hexane)", "110-54-3", "1", "ppm", "6001", "<65%", "1", "50", "Celsius", "Medium", "257 horas", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("22", "Hexane (n-hexane)", "110-54-3", "1", "ppm", "6001", "85%", "1", "50", "Celsius", "Medium", "440 minutes", "50", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("23", "Divinyl benzene", "1321-74-0", "100", "ppm", "6001", "<65%", "1", "0", "Celsius", "Medium", "33 horas", "10", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("24", "Divinyl benzene", "1321-74-0", "100", "ppm", "6001", "85%", "1", "0", "Celsius", "Medium", "33 horas", "10", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("25", "Ammonia", "7664-41-7", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Light", "19 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("26", "Ammonia", "7664-41-7", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "9 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("27", "Ammonia", "7664-41-7", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Heavy", "370 minutes", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("28", "Ammonia", "7664-41-7", "30", "ppm", "6004", "<65%", "1", "20", "Celsius", "Medium", "77 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("29", "Ammonia", "7664-41-7", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "9 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("30", "Ammonia", "7664-41-7", "20.55", "mg/m3 ", "6004", "<65%", "1", "30", "Celsius", "Medium", "77 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("31", "Ammonia", "7664-41-7", "30", "ppm", "6004", "85%", "0.95", "30", "Celsius", "Heavy", "51 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("32", "Cyanogen", "460-19-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "42 horas", "8", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("33", "Chlorine", "7782-50-5", "30", "ppm", "6003", "<65%", "1", "20", "Celsius", "Medium", "65 horas", "0.1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("34", "Chlorine", "7782-50-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "200 horas", "0.1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("35", "Formaldehyde", "50-00-0", "30", "ppm", "6005", "<65%", "1", "20", "Celsius", "Medium", "366 minutes", "0.1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("36", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Light", "253 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("37", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "126 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("38", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Heavy", "84 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("39", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "2076HF", "<65%", "1", "20", "Celsius", "Medium", "13 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("40", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "6002", "<65%", "1", "20", "Celsius", "Medium", "154 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("41", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "6003", "<65%", "1", "20", "Celsius", "Medium", "71 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("42", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "126 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("43", "Hydrogen fluoride", "7664-39-3", "30", "ppm", "7093C", "<65%", "1", "20", "Celsius", "Medium", "8 horas", "0.5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("44", "Hydrogen sulfide", "7783-06-4", "30", "ppm", "6002", "<65%", "1", "20", "Celsius", "Medium", "1428 horas", "1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("45", "Hydrogen sulfide", "7783-06-4", "30", "ppm", "6003", "<65%", "1", "20", "Celsius", "Medium", "760 horas", "1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("46", "Hydrogen sulfide", "7783-06-4", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "679 horas", "1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("47", "Hydrogen sulfide", "7783-06-4", "30", "ppm", "6009S", "<65%", "1", "20", "Celsius", "Medium", "21 horas", "1", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("48", "Methylamine", "74-89-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Light", "89 horas", "5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("49", "Methylamine", "74-89-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "45 horas", "5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("50", "Methylamine", "74-89-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Heavy", "30 horas", "5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("51", "Methylamine", "74-89-5", "30", "ppm", "6004", "<65%", "1", "20", "Celsius", "Medium", "245 horas", "5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("52", "Methylamine", "74-89-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "45 horas", "5", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("53", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Light", "88 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("54", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "44 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("55", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Heavy", "29 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("56", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6002", "<65%", "1", "20", "Celsius", "Medium", "164 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("57", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6003", "<65%", "1", "20", "Celsius", "Medium", "46 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("58", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6006", "<65%", "1", "20", "Celsius", "Medium", "44 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("59", "Sulfur dioxide", "7446-09-5", "30", "ppm", "6009S", "<65%", "1", "20", "Celsius", "Medium", "125 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("60", "Sulfur dioxide", "7446-09-5", "15", "ppm", "6003", "<65%", "1", "30", "Celsius", "Light", "222 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("61", "Sulfur dioxide", "7446-09-5", "79.9", "mg/m3 ", "6002", "<65%", "1", "20", "Celsius", "Medium", "164 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("62", "2-Propanol", "67-63-0", "1.87", "ppm", "6006", "65%", "1", "20", "Celsius", "Medium", "247 minutes", "200", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("63", "Toluene", "108-88-3", "100", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Tight fitting - standard airflow", "26 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("64", "Toluene", "108-88-3", "100", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Tight fitting - medium airflow", "23 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("65", "Toluene", "108-88-3", "100", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Tight fitting - high airflow", "20 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("66", "Toluene", "108-88-3", "100", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Loose fitting - standard airflow", "18 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("67", "Toluene", "108-88-3", "100", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Loose fitting - medium airflow", "17 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("68", "Toluene", "108-88-3", "100", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Loose fitting - high airflow", "16 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("69", "Toluene", "108-88-3", "100", "ppm", "TR-6310E", "<65%", "1", "20", "Celsius", "Tight fitting - standard airflow", "38 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("70", "Toluene", "108-88-3", "100", "ppm", "TR-6310E", "<65%", "1", "20", "Celsius", "Tight fitting - medium airflow", "34 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("71", "Toluene", "108-88-3", "100", "ppm", "TR-6310E", "<65%", "1", "20", "Celsius", "Tight fitting - high airflow", "30 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("72", "Toluene", "108-88-3", "100", "ppm", "TR-6310E", "<65%", "1", "20", "Celsius", "Loose fitting - standard airflow", "27 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("73", "Toluene", "108-88-3", "100", "ppm", "TR-6310E", "<65%", "1", "20", "Celsius", "Loose fitting - medium airflow", "25 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("74", "Toluene", "108-88-3", "100", "ppm", "TR-6310E", "<65%", "1", "20", "Celsius", "Loose fitting - high airflow", "23 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("75", "Toluene", "108-88-3", "100", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - standard airflow", "32 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("76", "Toluene", "108-88-3", "100", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - medium airflow", "29 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("77", "Toluene", "108-88-3", "100", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - high airflow", "26 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("78", "Toluene", "108-88-3", "100", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - standard airflow", "23 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("79", "Toluene", "108-88-3", "100", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - medium airflow", "21 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("80", "Toluene", "108-88-3", "100", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - high airflow", "20 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("81", "Ammonia", "7664-41-7", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - standard airflow", "30 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("82", "Ammonia", "7664-41-7", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - medium airflow", "26 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("83", "Ammonia", "7664-41-7", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - high airflow", "23 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("84", "Ammonia", "7664-41-7", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - standard airflow", "21 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("85", "Ammonia", "7664-41-7", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - medium airflow", "19 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("86", "Ammonia", "7664-41-7", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - high airflow", "18 horas", "20", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("87", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Tight fitting - standard airflow", "42 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("88", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Tight fitting - medium airflow", "38 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("89", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Tight fitting - high airflow", "34 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("90", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Loose fitting - standard airflow", "30 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("91", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Loose fitting - medium airflow", "28 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("92", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6130E", "<65%", "1", "20", "Celsius", "Loose fitting - high airflow", "26 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("93", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - standard airflow", "129 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("94", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - medium airflow", "117 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("95", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Tight fitting - high airflow", "103 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("96", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - standard airflow", "92 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("97", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - medium airflow", "85 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("98", "Sulfur dioxide", "7446-09-5", "30", "ppm", "TR-6580E", "<65%", "1", "20", "Celsius", "Loose fitting - high airflow", "79 horas", "0.25", "ppm", "Brazil", new string[] {
                "source:ServiceLifeBrazilData.xlsx:sheet1"}, Category="source:ServiceLifeBrazilData.xlsx:sheet1")]
        public virtual void ValidatingTheLifeHoursForEachAcids_(
                    string sNo_, 
                    string contaminate, 
                    string cas_Number, 
                    string exposure, 
                    string exposure_Unit, 
                    string cartridge, 
                    string relative_Humidity, 
                    string atmospheric_Pressure, 
                    string temperature, 
                    string temperature_Unit, 
                    string work_Rate, 
                    string hours, 
                    string exposure_Limit, 
                    string exposure_Limit_Unit, 
                    string region, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validating the life hours for each acids.", null, @__tags);
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
testRunner.Given("I have navigated to the SLS Website Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
testRunner.Then(string.Format("I select the provided {0} as the Country Region", region), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
testRunner.And("I click on next button after region selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.Then("I select the Service Life Estimate/End of Service Life Indicator (ESLI) Compatibi" +
                    "lity using the radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
testRunner.And("Click on IAccept button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.Then(string.Format("I filter the data using {0} in the Contaminate Page and select the filtered produ" +
                        "ct.", cas_Number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
testRunner.And(string.Format("Enter the {0} value and {1} for the {2} provided.", exposure, exposure_Unit, cas_Number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.Then(string.Format("Click on the Done button to proceed further{0}.", cas_Number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
testRunner.And(string.Format("In cartidge page  filter the products using the {0}", cartridge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.Then(string.Format("Select the  product filtered using the {0} number", cartridge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
testRunner.Then(string.Format("Read the description and Click on Select and Continue according to the {0} value", cartridge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
testRunner.And(string.Format("In the Environment  condition enter the {0} ,{1},{2},{3} and {4}", relative_Humidity, atmospheric_Pressure, temperature, temperature_Unit, work_Rate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
testRunner.Then("Click on the next button and verify the data entered.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
testRunner.And(string.Format("After verifying the details in the Environment page, if {0} matches the Actual Ho" +
                        "urs displayed then click on on Done button.", hours), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion