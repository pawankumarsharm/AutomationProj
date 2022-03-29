using Hello.Xpath;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Hello.steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private IWebDriver driver;


        public SpecFlowFeature1Steps(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Open shopping webapplication in the browser")]
        public void GivenOpenShoppingWebapplicationInTheBrowser()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            Thread.Sleep(3000);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"select Dress")]
        public void GivenSelectDress()
        {
            driver.FindElement(By.XPath(xpath.selectDress)).Click();
            Thread.Sleep(5000);
            // ScenarioContext.Current.Pending();
        }
        
        [When(@"a message will appear")]
        public void WhenAMessageWillAppear()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"select Casual Dress")]
        public void ThenSelectCasualDress()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"Add to cart the project")]
        public void ThenAddToCartTheProject()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"Proceed to checkout")]
        public void ThenProceedToCheckout()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"login with (.*) and (.*)")]
        public void ThenLoginWithAnd(string p0, string p1)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on Update the Address")]
        public void ThenClickOnUpdateTheAddress()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Change the State and save")]
        public void ThenChangeTheStateAndSave()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Add the comment")]
        public void ThenAddTheComment()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on proceed to checkout")]
        public void ThenClickOnProceedToCheckout()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on proceed to checkout terms")]
        public void ThenClickOnProceedToCheckoutTerms()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on close")]
        public void ThenClickOnClose()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Now Check the Terms of Service checkbox")]
        public void ThenNowCheckTheTermsOfServiceCheckbox()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Proceed to checkoutt")]
        public void ThenProceedToCheckoutt()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"now read total price")]
        public void ThenNowReadTotalPrice()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on pay by bank wire")]
        public void ThenClickOnPayByBankWire()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on confirm my order")]
        public void ThenClickOnConfirmMyOrder()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"save the screenshot from for the confirmation page")]
        public void ThenSaveTheScreenshotFromForTheConfirmationPage()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
