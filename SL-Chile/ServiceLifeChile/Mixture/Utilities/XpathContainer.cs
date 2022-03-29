using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Utilities
{
    class XpathContainer
    {
        public static string _btnOK = "//button[@class='btn btn_primary' and text()='Ok']";
        public static string cookies = "//div[@id='consent_prompt_submit']";
        public static string CASBox = "//input[@id='search']";
        public static string next = "//button[@class='btn btn_primary']";
        public static string btnDone = "//button[contains(text(),'Finalizar')]";//"//button[contains(text(),'Done')]";
        public static string SelCon = "//button[contains(text(),'Seleccionar y Continuar')]";
        public static string region = "//div[contains(text(),'Chile (Español)')]";//"//div[contains(text(),'United States (English)')]"; 
        public static string region_canada= "//div[contains(text(),'Canada (English)')]";
        public static string chkbox = "//input[@id='serviceLifeType']";
        public static string contaminant = "//label[@class='inputBox-label']";
        public static string casbox = "//input[@id='Search']";
        public static string cart_ele = "//div[@class='productItemMedia-content-bd']";
        public static string cart_ele6006 = "//div[@class='productItemMedia-content-hd'][contains(text(),'6006')]";
        public static string _masterContaminant = "//div[@class='productItemMedia-content-hd']";
        public static string espain = "//div[contains(text(),'Colombia (Español)')]";
        public static string selected = "//div[@class='contaminants-header-meta']//div[3]//label[1]";
        public static string ok = "//button[contains(text(),'Ok')]";
        public static string nextfinal = "//body/div[@id='root']/main[@class='site']/div[@class='site-bd']/div[@class='site-bd-content']/div[@class='site-bd-content-inner']/div[@class='pageContainer']/div[@class='pageContainer-actionBar']/div[@class='actionBar']/div[@class='actionBar-btnGroup']/div[@class='actionBar-btnGroup-right']/button[@class='btn btn_primary']/*[1]";
        public static string pressurele = "//input[@id='atmospheric-pressure']";
        public static string rel_humidity = "//select[@id='relative-humidity']";
        public static string hours_value = "//div[@class='serviceLife-bd']";
        public static string temp_drpdwn = "//select[@id='temperature']";
        public static string btn_fahrenheit = "//label[contains(text(),'Fahrenheit')]";
        public static string btn_celcius = "//label[contains(text(),'Celsius')]";
        public static string wrkrate_drpdwn = "//select[@id='work-rate']";
        //Exposures Xpath locators
        public static string MethExposure = "//input[@id='exposure-label_2c5f79a9-7b49-4b0d-9017-c10ba752882a']";
        public static string TouleneExposure = "//input[@id='exposure-label_ccb4a274-6648-4d94-877f-a2941361c91e']";
        public static string XyleneExposure = "//input[@id='exposure-label_8b0ba8fb-7623-472b-9fc9-4e10041bbe0f']";
        public static string H2SExposureEle = "//input[@id='exposure-label_35b6e488-c215-4c53-b56e-af9a2515d321']";
        public static string AcetonitrileExposure = "//input[@id='exposure-label_fddeaf3b-ebb0-4dde-be37-7a94bd42e6c4']";
        public static string AcetoneExposureEle = "//input[@id='exposure-label_3265cde1-d7fc-4120-927e-f7b8b98e2913']";
        public static string SO2Exposure = "//input[@id='exposure-label_6aa8303c-4851-4d67-b38d-913644e3a2c3']";
        public static string FormamideExposure = "//input[@id='exposure-label_131e2bf9-87a2-4d1b-9cfe-a2a64e0a37fb']";
        public static string AceticExposure = "//input[@id='exposure-label_3a5047b5-feb9-4fd0-a86b-1dbc5398f302']";
        public static string MekExposure = "//input[@id='exposure-label_42c80f8e-0444-44bb-bf87-184b8db81347']";
        public static string HFExposure = "//input[@id='exposure-label_fddeaf3b-ebb0-4dde-be37-7a94bd42e6c4']";
        public static string AmmoniaExposure = "//input[@id='exposure-label_edb202e4-0d14-4179-bbb9-0f89c3b59712']";
        public static string HexaneExposure = "//input[@id='exposure-label_fddeaf3b-ebb0-4dde-be37-7a94bd42e6c4']";
        public static string MethChlorideExposure = "//input[@id='exposure-label_2c5f79a9-7b49-4b0d-9017-c10ba752882a']";
        public static string HexExposure = "//input[@id='exposure-label_ed6edda0-7b73-4451-8ee8-6efbfbfd521a']";
        public static string StyExposure = "//input[@id='exposure-label_1548d28e-ae21-40d6-b1b4-3e4283381f7d']";
        public static string methchlorideeleExposure = "//input[@id='exposure-label_2c5f79a9-7b49-4b0d-9017-c10ba752882a']";
        public static string HFExposureEle = "//input[@id='exposure-label_0e7a4fcd-8a0f-4c70-8f9f-d16e9b3bd30c']";
        public static string AmmoniaExposureEle = "//input[@id='exposure-label_edb202e4-0d14-4179-bbb9-0f89c3b59712']";
        public static string SoExposure = "//input[@id='exposure-label_6aa8303c-4851-4d67-b38d-913644e3a2c3']";
        public static string HSExposure = "//input[@id='exposure-label_35b6e488-c215-4c53-b56e-af9a2515d321']";
        public static string MethyExposure = "//input[@id='exposure-label_b92f391f-5b7a-4b8a-8d67-edd02135efa7']";
        public static string methylamine = "//input[@id='exposure-label_b92f391f-5b7a-4b8a-8d67-edd02135efa7']";
        //Exposures Unit locators
        public static string methylamineLoc = "//select[@id='unit-label_b92f391f-5b7a-4b8a-8d67-edd02135efa7-2']";
        public static string H2SExposLoc = "//select[@id='unit-label_35b6e488-c215-4c53-b56e-af9a2515d321-2']";
        public static string SO2ExposLoc = "//select[@id='unit-label_6aa8303c-4851-4d67-b38d-913644e3a2c3-2']";
        public static string AcetoneExposLoc = "//select[@id='unit-label_3265cde1-d7fc-4120-927e-f7b8b98e2913-2']";
        public static string AcetExpounit = "//select[@id='unit-label_fddeaf3b-ebb0-4dde-be37-7a94bd42e6c4-2']";
        public static string FormaExpounit = "//select[@id='unit-label_131e2bf9-87a2-4d1b-9cfe-a2a64e0a37fb-2']";
        public static string TouleneExposLoc = "//select[@id='unit-label_ccb4a274-6648-4d94-877f-a2941361c91e-2']";
        public static string AceticAcidButylesterExposLoc = "//select[@id='unit-label_3a5047b5-feb9-4fd0-a86b-1dbc5398f302-2']";
        public static string MEKExposLoc = "//select[@id='unit-label_42c80f8e-0444-44bb-bf87-184b8db81347-2']";
        public static string XyleneExposLoc = "//select[@id='unit-label_8b0ba8fb-7623-472b-9fc9-4e10041bbe0f-2']";
        public static string HFExposLoc = "//select[@id='unit-label_0e7a4fcd-8a0f-4c70-8f9f-d16e9b3bd30c-2']";
        public static string AmmoniaExposLoc = "//select[@id='unit-label_edb202e4-0d14-4179-bbb9-0f89c3b59712-2']";
        public static string MethyleneExposLoc = "//select[@id='unit-label_2c5f79a9-7b49-4b0d-9017-c10ba752882a-2']";
        public static string HexaneExposLoc = "//select[@id='unit-label_ed6edda0-7b73-4451-8ee8-6efbfbfd521a-2']";
        public static string AcetoExposLoc = "//select[@id='unit-label_fddeaf3b-ebb0-4dde-be37-7a94bd42e6c4-2']";
        public static string FormamideExposLoc = "//select[@id='unit-label_131e2bf9-87a2-4d1b-9cfe-a2a64e0a37fb-2']";
        public static string StyreneExposLoc = "//select[@id='unit-label_1548d28e-ae21-40d6-b1b4-3e4283381f7d-2']";
        public static string MethyExposLoc = "//select[@id='unit-label_b92f391f-5b7a-4b8a-8d67-edd02135efa7-2']";
        public static string HSExposLoc = "//select[@id='unit-label_35b6e488-c215-4c53-b56e-af9a2515d321-2']";
        public static string MethylamineExposLoc = "//select[@id='unit-label_2c5f79a9-7b49-4b0d-9017-c10ba752882a-2']";
        public static string _masterExposureValue = "//input[@name='exposureValue']";
        public static string _masterExposureUnit = "//select[@name='exposureUnit']";
    }
}
