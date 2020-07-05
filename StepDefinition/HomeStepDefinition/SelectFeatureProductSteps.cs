using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class SelectFeatureProductSteps
    {
        HomePage CCHome;  
        public SelectFeatureProductSteps()
        {
            CCHome = new HomePage();
        }
        [Given(@"I am on Home page")]
        public void GivenIAmOnHomePage()
        {
          
        }
        
        [When(@"I click the Feature Product \(AppleAirPod\)")]
        public void WhenIClickTheFeatureProductAppleAirPod()
        {
            CCHome.FeatureProductSelection();
        }
        
        [Then(@"Apple Air Pod is selected")]
        public void ThenAppleAirPodIsSelected()
        {
            CCHome.ValidationFeatureProduct();
        }
    }
}
