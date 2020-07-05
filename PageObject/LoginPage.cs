using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Speckflow2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Speckflow2.StepDefinition
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'header_bar-sign_in')]//span[contains(text(),'Sign in')]")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='login-email']")]
        public IWebElement EnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='login-password']")]
        public IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[contains(@class,'login-form')]//button[contains(@class,'submit')]")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.LinkText, Using = "My account")]
        public IWebElement MyAccountTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='account-links dropdown-menu']//span[contains(text(),'Log out')]")]
        public IWebElement LogOut { get; set; }


        public void ExistingUser()
        {
            SignInButton.Click();
            Thread.Sleep(1000);
            EnterEmail.SendKeys("test@email1.com");
            EnterPassword.SendKeys("123qwe");
            Login.Submit();          
            
        }

        public void LogoutUser()
        {
            MyAccountTab.Click();
            LogOut.Click();
        }

        public void Login_Checkout()
        {
            EnterEmail.SendKeys("test@email1.com");
            EnterPassword.SendKeys("123qwe");
            Login.Submit();
        }
    }
}
