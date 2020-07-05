using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.ShippingStepDefinition
{
    [Binding]
    public class ShippingPageVerificationsSteps
    {
        ShippingPage Spage;
        public ShippingPageVerificationsSteps()
        {
            Spage = new ShippingPage();
        }
        [Given(@"I am  on Demostore website")]
        public void GivenIAmOnDemostoreWebsite()
        {
            
        }
        
        [When(@"I click  the  shipping tab")]
        public void WhenIClickTheShippingTab()
        {
            Spage.ClickShippingLink();
        }
        
        [Then(@"I navigated  to shipping page")]
        public void ThenINavigatedToShippingPage()
        {
            Spage.Validate_ShipplingPageTitle();
        }
    }
}
