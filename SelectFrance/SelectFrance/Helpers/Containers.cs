using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectFrance.Helpers
{
    public class Containers
    {
        protected static string _Francecountry = "//div[text()='France - Français']";
        protected static string _btnNextCountry = "//button[@class='btn btn_primary']";
        protected static string _selectRadio = "//input[@id='cartridgeAndFilterType']";
        protected static string _elsiAcceptBtn = "//button[@class='btn btn_primary']";
        protected static string _oxygenDefiency = "//button[contains(text(),'Non')]";
        protected static string _casSearch = "//input[@id='search']";
        protected static string _contaminantChckBox = "//label[@class='inputBox-label']";
        protected static string _firstYes = "(//label[@class='radioGroup-item-label' and text()='Oui'])[1]";
        protected static string _secondYes = "(//label[@class='radioGroup-item-label' and text()='Oui'])[2]";
        protected static string _thirdYes = "(//label[@class='radioGroup-item-label' and text()='是的'])[3]";
        protected static string _firstNo = "(//label[@class='radioGroup-item-label' and text()='Non'])[1]";
        protected static string _secondNo = "(//label[@class='radioGroup-item-label' and text()='Non'])[2]";
        protected static string _thirdNo = "(//label[@class='radioGroup-item-label' and text()='不是'])[3]";
        protected static string _resetBtn = "//button[contains(text(),'Réinitialiser')]";
        protected static string _doneBtn = "//button[contains(text(),'Terminé')]";
        protected static string _mgnseReschkBx = "//label[@class='inputBox-label']";
        protected static string _aerosolOrganic = "(//label[@class='inputBox-label'])[2]";
        protected static string _nickelSoluble = " / html / body / div / main / div / div / div / div / div[1] / div / form / div[1] / div / div / div[1] / div[1] / div[1] / div / label";
        protected static string _ozoneHeavy = "//*[@id='root']/main/div/div/div/div/div[1]/div/form/div[1]/div/div/div[3]/div[1]/div[2]/div[1]/label";
        protected static string _textMessage = "//div[@class='radioGroup-caption']";
        protected static string txtResuable = "//label[text()='Non']";           //"//label[contains(text(),'可更换式')]";
        protected static string txtParp = "//label[text()='Non']";      //xpathissue //*[@id="root"]/main/div[2]/form/span/div/div/ul/li[2]/label         //"//label[contains(text(),'动力送风过滤式呼吸器（PAPR)')]";
        protected static string txtDisposable = "//label[text()='Non']";    //"//label[contains(text(),'随弃式')]";
        protected static string btnP1 = "//label[contains(text(),'P1')]";
        protected static string btnP2 = "//label[contains(text(),'P2')]";
        protected static string btnP3 = "//label[contains(text(),'P3')]";
        protected static string formaldehyde_ele = "//label[contains(text(),'Formaldehyde')]";
        protected static string multi_vapor_ele = "//label[contains(text(),'Multigas/Vapor')]";
        protected static string organi_vapor = "//label[@class='radioGroup-item-label' and text()='Organic Vapor']";
        protected static string organic_acid_vapor = "//label[contains(text(),'Organic Vapor/Acid Gas')]";
        protected static string ammonia = "//label[text()='Ammonia']";
        protected static string acid_gas = "//label[text()='Acid Gas']";
        protected static string mercury_vapor = "//label[text()='Mercury Vapor']";
        protected static string hydrogen_fluoride = "//label[text()='Hydrogen Fluoride']";
        protected static string _noResultMessage = "//div[@class='noResults-message']";
        protected static string _aCookiesVisible = "//div[@id='consent_prompt_submit' and text()='CONFIRM']";
        protected static string _cartidgescount = "div[class='productItemMedia-content-hd']";
    }
}
