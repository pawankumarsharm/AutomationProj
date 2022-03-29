using OpenQA.Selenium;
using System;
using System.Net;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace Safeguard.Feature
{
    [Binding]
    public class SafeguardSteps2
    {
        private IWebDriver driver;

        public SafeguardSteps2(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        [Given(@"click on the links and close the browser")]
        public async System.Threading.Tasks.Task GivenClickOnTheLinksAndCloseTheBrowserAsync()
        {
            int valid_links = 0, broken_links = 0;
            driver.Url = "https://safeguardqa.azurewebsites.net/Guest#/Validation";
            var client = new HttpClient();
            var links = driver.FindElements(By.TagName("a"));

            Console.WriteLine("Looking at all the URLs in SafeGuard :");
            /* Loop through all the urls */
            foreach (var link in links)
            {
                if ((link.Text.Contains("https://engage.3m.com/covid-19_anti_fraud_id") || link.Text.Contains("https://engage.3m.com/covidfraud") || link.Text == "" || link.Equals(null)))
                {
                    try
                    {
                        /* Get the URI */
                        HttpResponseMessage response = await client.GetAsync(link.GetAttribute("href"));
                        System.Console.WriteLine($"URL: {link.GetAttribute("href")} status is :{response.StatusCode}");
                        /* Reference - https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebresponse.statuscode?view=netcore-3.1 */
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            valid_links++;
                        }
                        else
                        {
                            broken_links++;
                        }
                    }
                    catch (Exception ex)
                    {
                        if ((ex is ArgumentNullException) ||
                           (ex is NotSupportedException))
                        {
                            System.Console.WriteLine("Exception occured\n");
                        }
                    }
                }
            }
            /* Perform wait to check the output */ 
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Detection of broken links completed with " + broken_links + " broken links and " + valid_links + " valid links");
            driver.Close();
        }

        //ScenarioContext.Current.Pending();
        }
    }

