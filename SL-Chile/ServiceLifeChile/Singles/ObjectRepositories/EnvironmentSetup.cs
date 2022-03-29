using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeChile.ObjectRepositories
{
    class EnvironmentSetup
    {
        IWebDriver driver;
        public EnvironmentSetup(IWebDriver _driver)
        {
            this.driver = _driver;
        }
    }
}
