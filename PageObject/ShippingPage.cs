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
    public class ShippingPage
    {
        public ShippingPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav top-main-menu']//span[contains(text(),'Shipping')]")]
        public IWebElement ShippingLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[@class='title']")]
        public IWebElement ShippingTitle { get; set; }

        public void ClickShippingLink()
        {
            ShippingLink.Click();
        }

        public void Validate_ShipplingPageTitle()
        {
            Assert.AreEqual(ShippingTitle.Text, "Shipping");
            Console.WriteLine("Page Title Displayed: "+ ShippingTitle.Displayed); //true or False
            Console.WriteLine("Page Title Displayed: " + ShippingTitle.Text); //Page Title : Shipping
        }
    }

}
