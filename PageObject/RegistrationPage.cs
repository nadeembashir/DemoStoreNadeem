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
    public class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'header_bar-sign_in')]//span[contains(text(),'Sign in')]")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='popup-button default-popup-button create-account-link']")]
        public IWebElement CreateSininAccountButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Login with Facebook')]")]
        public IWebElement FaceBookButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign in with Google')]")]
        public IWebElement GoogleButton { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement EnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        public IWebElement EnterPassWord { get; set; }

        [FindsBy(How = How.Id, Using = "password-conf")]
        public IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Create')]")]
        public IWebElement EnterCreateButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "popup-button popup-login")]
        public IWebElement AlreadyAccout { get; set; }

        public void ClickSignIn()
        {
            SignInButton.Click();
        }

        public void ClickSignInCreatAccount()
        {
            CreateSininAccountButton.Click();
        }

        public void EnterEmailAddress(string myemail)
        {
            EnterEmail.SendKeys(myemail);
        }

        public void Password()
        {
            EnterPassWord.SendKeys("123qwe");
        }
        public void ConfirmPasswordAgain()
        {
            ConfirmPassword.SendKeys("123qwe");
        }

        public void CreateAccount()
        {
            EnterCreateButton.Click();
        }

        public void AlreadyRegistered()
        {
            AlreadyAccout.Click();
        }
    }
}
