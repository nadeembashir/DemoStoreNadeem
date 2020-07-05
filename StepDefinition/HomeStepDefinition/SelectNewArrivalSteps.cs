using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2
{
    [Binding]
    public class SelectNewArrivalSteps
    {
        HomePage CCHome;
        public SelectNewArrivalSteps()
        {
            CCHome = new HomePage();

        }
        [Given(@"I am on New Arrival page")]
        public void GivenIAmOnNewArrivalPage()
        {
            
        }
        
        [When(@"I select the new arrival item")]
        public void WhenISelectTheNewArrivalItem()
        {
            CCHome.HomeNewArrival();
        }
        
        [Then(@"I can see the new areival item")]
        public void ThenICanSeeTheNewAreivalItem()
        {
            CCHome.Validat_NerArrivals();
        }
    }
}
