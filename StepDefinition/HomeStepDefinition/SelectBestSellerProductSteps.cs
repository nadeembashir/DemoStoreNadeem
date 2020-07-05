using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2
{
    [Binding]
    public class SelectBestSellerProductSteps
    {
        HomePage CCHome;
        public SelectBestSellerProductSteps()
        {
            CCHome = new HomePage();
        }
        [Given(@"I am on Home  page")]
        public void GivenIAmOnHomePage()
        {
           
        }
        
        [When(@"I click the Best Seller \(WaistTieDress\)")]
        public void WhenIClickTheBestSellerWaistTieDress()
        {
            CCHome.HomeBestSeller();
        }
        
        [Then(@"WaistTieDress is selected")]
        public void ThenWaistTieDressIsSelected()
        {
            CCHome.Validat_BestSaller();
        }
    }
}
