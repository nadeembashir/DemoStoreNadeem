using Speckflow2.PageObject;
using Speckflow2.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2
{
    [Binding]
    public class StoreRegistrationSteps
    {
        RegistrationPage reg;
        public StoreRegistrationSteps()
        {
            reg = new RegistrationPage();
        }

        
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.driver.Navigate().GoToUrl("https://demostore.x-cart.com/?target=order_list");
            Hooks.driver.Manage().Window.Maximize();
        }
        
        [Given(@"I click on SignIN/SignUp link")]
        public void GivenIClickOnSignINSignUpLink()
        {
            reg.ClickSignIn();
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Given(@"I click CretaNewAccount link")]
        public void GivenIClickCretaNewAccountLink()
        {
            reg.ClickSignInCreatAccount();
        }
        
        [When(@"I entered email ""(.*)""")]
        public void WhenIEnteredEmail(string email)
        {
            reg.EnterEmailAddress(email);
        }
        
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            reg.Password();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            reg.ConfirmPasswordAgain();
        }
        
        [When(@"I click the create button")]
        public void WhenIClickTheCreateButton()
        {
            reg.CreateAccount();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            
        }
    }
}
