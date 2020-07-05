using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class SubscribeEmailSteps
    {
        HomePage CCHome;
        public SubscribeEmailSteps()
        {
            CCHome = new HomePage();
        }
        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            
        }

        [When(@"I subscribe the email '(.*)'")]
        public void WhenISubscribeTheEmail(string email)
        {
            CCHome.HomeSignupNews(email);
            CCHome.HomeSubscribe();
        }

        [Then(@"I am successfully able to subscribe")]
        public void ThenIAmSuccessfullyAbleToSubscribe()
        {
            CCHome.HomeSuscribeValidation();
        }
    }
}
