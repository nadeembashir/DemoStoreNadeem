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
    class MyAccountPage
    {
        public MyAccountPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav top-main-menu']//span[contains(text(),'My Account')]")]
        public IWebElement MyAccountTab { get; set; }


        [FindsBy(How = How.XPath, Using = "//li[@class='leaf active has-sub']//span[contains(text(),'My orders')]")]
        public IWebElement MyOrderTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav top-main-menu']//span[contains(text(),'My Account')]")]
        public IWebElement MyAccount_Order { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='tab-current active']//a[contains(text(),'Address book')]")]
        public IWebElement MyAccount_AddressBook { get; set; }

        [FindsBy(How = How.XPath, Using = " //a[contains(text(),'Profile details')]")]
        public IWebElement MyAccount_ProfileDetail { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Messages')]")]
        public IWebElement MyAccount_Message { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Saved credit cards')]")]
        public IWebElement MyAccount_Cr_Card { get; set; }

        [FindsBy(How = How.XPath, Using = " //li[@class='leaf active has-sub']//span[contains(text(),'My address book')]")]
        public IWebElement MyAddressBookTab { get; set; }

        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'Add new address')]")]
        public IWebElement MyAddressBookLink { get; set; }

        [FindsBy(How = How.XPath, Using = " //input[@id='field__firstname']")]
        public IWebElement MyAddress_Form_FName { get; set; }

        [FindsBy(How = How.XPath, Using = " //input[@id='field__lastname']")]
        public IWebElement MyAddress_Form_LName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='field__street']")]
        public IWebElement MyAddress_Form_Address { get; set; }

        [FindsBy(How = How.XPath, Using = "  //input[@id='field__city']")]
        public IWebElement MyAddress_Form_City{ get; set; }

        //DropDown
        [FindsBy(How = How.XPath, Using = " //select[@id='field__country_code']")]
        public IWebElement MyAddress_Form_Country { get; set; }
               
        [FindsBy(How = How.XPath, Using = "//input[@id='field__custom_state']")]
        public IWebElement MyAddress_Form_State { get; set; }

        [FindsBy(How = How.XPath, Using = " //input[@id='field__zipcode']")]
        public IWebElement MyAddress_Form_ZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='field__phone']")]
        public IWebElement MyAddress_Form_Phone { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'regular-main-button action submit')]")]
        public IWebElement MyAddress_Form_SaveChanges_Btn { get; set; }

        // Check xpath when confirming the message
        [FindsBy(How = How.XPath, Using = " //div[contains(@class,'selected')]")]
        public IWebElement MyAddress_Form_Confirmation { get; set; }
       
    }
}
