using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Speckflow2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Speckflow2.PageObject
{
    public class ContactUsPage
    {
        public ContactUsPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body.area-c.skin-customer.skin-crisp_white-customer.skin-theme_tweaker-customer.unauthorized.target-contact-us.one-sidebar.sidebar-first.sidebar-first-empty.country-AR.responsive-desktop:nth-child(2) div.mm-page.mm-slideout:nth-child(4) div.desktop-header.affix-top div.container div.navbar.navbar-inverse.mobile-hidden:nth-child(4) div.collapse.navbar-collapse ul.nav.navbar-nav.top-main-menu li.leaf.active.last:nth-child(6) a.active > span:nth-child(1)")]
        public IWebElement ContactUsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='name']")]
        public IWebElement ContactUsName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        public IWebElement ContactUsEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='subject']")]
        public IWebElement ContactUs_Form_Subject { get; set; }

        [FindsBy(How = How.XPath, Using = " //textarea[@id='message']")]
        public IWebElement ContactUs_Form_Message { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn regular-main-button submit submit btn-warning'] ")]
        public IWebElement ContactUs_Form_Send { get; set; }

        [FindsBy(How = How.ClassName, Using = "info")]
        public IWebElement Validat_SendMessage { get; set; }


        public void EnterContactUsDetail()
        {
            
            ContactUsTab.Click();
            ContactUsName.SendKeys("test1");
            ContactUsEmail.SendKeys("test@email.com");
            ContactUs_Form_Subject.SendKeys("Test Subject");
            ContactUs_Form_Message.SendKeys("Test message for Contact us form");
            ContactUs_Form_Send.Submit();
        }

        public void Validate_SendMessageContactUs()
        {
            Assert.AreEqual(Validat_SendMessage.Text, "The message has been sent");
            Console.WriteLine(Validat_SendMessage.Text);
        }

    }
}
