using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.ContactUsStepDefinition
{
    [Binding]
    public class ContactUsFeatureSteps
    {
        ContactUsPage ContUsPage;
        public ContactUsFeatureSteps()
        {
            ContUsPage = new ContactUsPage();
        }
        [Given(@"I am on Contact us page")]
        public void GivenIAmOnContactUsPage()
        {
           
        }
        
        [When(@"I enter all deatails and Click Send button")]
        public void WhenIEnterAllDeatailsAndClickSendButton()
        {
            ContUsPage.EnterContactUsDetail();
                    }
        
        [Then(@"request is sent")]
        public void ThenRequestIsSent()
        {
            ContUsPage.Validate_SendMessageContactUs();
        }
    }
}
