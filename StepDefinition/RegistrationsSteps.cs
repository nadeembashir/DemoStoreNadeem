using June_Specflow.PageObject;
using June_Specflow.Utilities;
using System;
using TechTalk.SpecFlow;

namespace June_Specflow
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;
        public RegistrationsSteps()
        {
            registration = new RegistrationPage();
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.driver.Navigate().GoToUrl("https://www.giftrete.com/account/authentication?ref=2");
            Hooks.driver.Manage().Window.Maximize();

        }

        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registration.ClickOnRegister();

        }

        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }

        [When(@"I enter lastname")]
        public void WhenIEnterLastname()
        {
            registration.EnterLastName();
        }

        [When(@"I entered email ""(.*)""")]
        public void WhenIEnteredEmail(string email)
        {
            registration.EnterEmail(email);
        }


        [When(@"I enter mobilie number")]
        public void WhenIEnterMobilieNumber()
        {
            registration.EnterMobile();
        }

        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword();
        }

        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.ConfirmPassword();
        }

        [When(@"I click the signup button")]
        public void WhenIClickTheSignupButton()
        {
            registration.ClickSignup();
        }

        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {

        }
    }
}
