using NUnit.Framework;
using Speckflow2.StepDefinition;
using Speckflow2.Utilities;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Speckflow2
{
    [Binding]
    public class LoginSteps
    {
        LoginPage log;
        public LoginSteps()
        {
            log = new LoginPage();
        }
        [Given(@"I navigate to the DemoStore site")]
        public void GivenINavigateToTheDemoStoreSite()
        {
           
        }
        
        [Given(@"I entered the crednetials")]
        public void GivenIEnteredTheCrednetials()
        {
            
            log.ExistingUser();            
        }
        
        [When(@"I click signin button")]
        public void WhenIClickSigninButton()
        {
     
        }
        
        [Then(@"I successfully logged in")]
        public void ThenISuccessfullyLoggedIn()
        {
         // Assert.
        }
    }
}
