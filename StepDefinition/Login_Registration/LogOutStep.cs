using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.Login
{
    [Binding]
    public class LoginSteps
    {
        LoginPage log;
        public LoginSteps()
        {
            log = new LoginPage();
        }
        [When(@"I click Logout button")]
        public void WhenIClickLogoutButton()
        {
            // first login than logged out
            log.ExistingUser();
            log.LogoutUser();

        }
        
        [Then(@"I can successfully loged out")]
        public void ThenICanSuccessfullyLogedOut()
        {
           
        }
    }
}
