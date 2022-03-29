using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectCartridgeChile.Helpers
{
    public class Containers
    {
        protected static string _chilecountry = "//div[contains(text(),'Chile (Español)')]";
        protected static string _btnNextCountry = "//button[@class='btn btn_primary']";
        protected static string _selectRadio = "//input[@id='cartridgeAndFilterType']";
        protected static string _elsiAcceptBtn = "//button[contains(text(),'Estoy de acuerdo')]";
        protected static string _oxygenDefiency = "//button[contains(text(),'No')]";
        protected static string _casSearch = "//input[@id='search']";
        protected static string _contaminantChckBox = "//label[@class='inputBox-label']";
        protected static string _firstYes = "(//label[@class='radioGroup-item-label' and text()='Sí'])[1]";
        protected static string _secondYes = "(//label[@class='radioGroup-item-label' and text()='Sí'])[2]";
        protected static string _firstNo = "(//label[@class='radioGroup-item-label' and text()='No'])[1]";
        protected static string _secondNo = "(//label[@class='radioGroup-item-label' and text()='No'])[2]";
        protected static string _resetBtn = "//button[@class='btn mix-btn_block' and text()='Reiniciar']";
        protected static string _doneBtn = "//button[@class='btn mix-btn_block' and text()='Finalizar']";
        protected static string _mgnseReschkBx = "//label[@class='inputBox-label']";
        protected static string _aerosolOrganic = "(//label[@class='inputBox-label'])[2]";
        protected static string _nickelSoluble = " / html / body / div / main / div / div / div / div / div[1] / div / form / div[1] / div / div / div[1] / div[1] / div[1] / div / label";
        protected static string _ozoneHeavy = "//*[@id='root']/main/div/div/div/div/div[1]/div/form/div[1]/div/div/div[3]/div[1]/div[2]/div[1]/label";
        protected static string _textMessage = "//div[@class='radioGroup-caption']";
        protected static string txtResuable = "//label[contains(text(),'Reusable')]";
        protected static string txtParp = "//label[contains(text(),'PAPR')]";
        protected static string txtDisposable = "//label[contains(text(),'Disposable')]";
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
