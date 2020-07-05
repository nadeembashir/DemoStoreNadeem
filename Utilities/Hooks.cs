using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Speckflow2.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;
            
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demostore.x-cart.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }        
        
        [AfterScenario]
        public void AfterScenario()
        {
          //  driver.Close();
        }

        
    }
}
