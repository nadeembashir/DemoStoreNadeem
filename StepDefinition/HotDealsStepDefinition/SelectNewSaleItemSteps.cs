using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HotDealsStepDefinition
{
    [Binding]
    public class SelectNewSaleItemSteps
    {
        HotDealsPage HDeals;

        public SelectNewSaleItemSteps()
        {
            HDeals = new HotDealsPage();
        }
        [Given(@"I am on demo website")]
        public void GivenIAmOnDemoWebsite()
        {
           
        }
        
        [When(@"I select to sort by new")]
        public void WhenISelectToSortByNew()
        {
            HDeals.ClickHotDealLink();
            HDeals.ClickHotDealSale();
            HDeals.ClickSortByNewest();
        }
        
        [Then(@"sorted by new items")]
        public void ThenSortedByNewItems()
        {
            HDeals.ValidateNewestItem();
        }
    }
}
