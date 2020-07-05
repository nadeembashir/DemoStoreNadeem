using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.CommingSoonStepDef
{
    [Binding]
    public class CommingSoonSteps
    {
        ComingSoonPage ComSoon;
        public CommingSoonSteps()
        {
            ComSoon = new ComingSoonPage();
        }

        [Given(@"I  am on Demostore website")]
        public void GivenIAmOnDemostoreWebsite()
        {
            
        }
        
        [When(@"I click  the Comming Soon tab")]
        public void WhenIClickTheCommingSoonTab()
        {
            ComSoon.ClickCommingSoonTab();
        }
        
        [Then(@"I navigated  to Comming Soon page")]
        public void ThenINavigatedToCommingSoonPage()
        {
            ComSoon.Validate_CommingSoonTitle();
        }
    }
}
