using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class SelectElectronicsLinkSteps
    {
        HomePage CCHome;
        public SelectElectronicsLinkSteps()
        {
            CCHome = new HomePage();

        }

        [Given(@"I navigate to the Home page of DemoStore")]
        public void GivenINavigateToTheHomePageOfDemoStore()
        {
          
        }
        
        [When(@"I click the Electronic link")]
        public void WhenIClickTheElectronicLink()
        {
            CCHome.XCartElectronicsMethod();
        }
        
        [Then(@"I am navigated to the electronic page")]
        public void ThenIAmNavigatedToTheElectronicPage()
        {
            CCHome.VertifyTilteElecronicPage();
        }
    }
}
