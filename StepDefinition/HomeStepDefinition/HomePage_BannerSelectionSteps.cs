using Speckflow2.PageObject;
using Speckflow2.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class HomePage_BannerSelectionSteps
    {
        HomePage BannerSelection;
        public HomePage_BannerSelectionSteps()
        {
            BannerSelection = new HomePage();

        }
        
        [Given(@"I naviget to the XCart Home page")]
        public void GivenINavigetToTheXCartHomePage()
        {
           
        }
        
        [When(@"I click the Banner")]
        public void WhenIClickTheBanner3()
        {
            BannerSelection.GoToThirdBanner();
            BannerSelection.ClickThirdBanner();
        }

        [Then(@"I navigeted to the selected banner")]
        public void ThenINavigetedToTheSelectedBanner()
        {          
            BannerSelection.VertifyTilteElecronicPage();
        }
    }
}
