using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Speckflow2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speckflow2.PageObject
{
    public class ComingSoonPage
    {
        public ComingSoonPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav top-main-menu']//span[contains(text(),'Coming soon')]")]
        public IWebElement CommingSoonTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[@id='page-title']")]
        public IWebElement ComingSoonTitle { get; set; }

        public void ClickCommingSoonTab()
        {
            CommingSoonTab.Click();
        }
        public void Validate_CommingSoonTitle()
        {
            Assert.AreEqual(ComingSoonTitle.Text, "Coming soon");
            Console.WriteLine("Page title : " + ComingSoonTitle.Text);
        }

    }
}
