using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_service_us_canada.single_acid_validation.Utilities
{
    class XpathContainer
    {
        internal static readonly string _acceptCookies = "consent_prompt_submit";
        internal static readonly string _aCookiesVisible = "//div[contains(text(),'Use of Cookies')]";
        public static string IAccept = "//button[@class='btn btn_primary']";
        public static string okBtn = "//button[contains(text(),'Ok')]";
        public static string doneBtn = "//button[contains(text(),'Feito')]";//"//button[contains(text(),'Done')]";        
        public static string tempDropDwn = "//select[@id='temperature']";
        public static string usRegionSelect = "//div[contains(text(),'United States (English)')]";
        public static string can_RegionSelect = "//div[contains(text(),'Canada (English)')]";
        public static string eLSI_selector = "//input[@id='serviceLifeType']";
        public static string searchBxCas = "//input[@id='search']";
        public static string searchBxCartidge = "//input[@id='Search']";
        public static string chkBx = "//label[@class='inputBox-label']";
        public static string wrkRate = "//select[@id='work-rate']";
        public static string humidityDrpDwn = "//select[@id='relative-humidity']";
        public static string fahrenheitSelect = "//label[contains(text(),'Fahrenheit')]";
        public static string celciusSelect = "//label[contains(text(),'Celsius')]";
        public static string hoursStringVerify = "//div[@class='serviceLife-bd']";
        public static string nextFinal = "//body/div[@id='root']/main[@class='site']/div[@class='site-bd']/div[@class='site-bd-content']/div[@class='site-bd-content-inner']/div[@class='pageContainer']/div[@class='pageContainer-actionBar']/div[@class='actionBar']/div[@class='actionBar-btnGroup']/div[@class='actionBar-btnGroup-right']/button[@class='btn btn_primary']/*[1]";
        public static string atmPressure = "//input[@id='atmospheric-pressure']";
        public static string sel_Con = "//button[contains(text(),'Selecionar e Continuar')]"; //"//button[contains(text(),'Select and Continue')]";
        public static string espain = "//div[contains(text(),'Colombia (Español)')]";
        public static string _masterExposureValue = "//input[@name='exposureValue']";
        public static string _masterExposureUnit = "//select[@name='exposureUnit']";
        internal static string mex_RegionSelect= "//div[contains(text(),'Mexico (Español)')]";
        public static string Brazil_RegionSelect = "//div[@class='countryOfRegulation-labeltext' and text()='Brasil (Português)']";
    }
}
