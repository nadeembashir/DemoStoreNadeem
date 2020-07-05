using Speckflow2.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class SelectSaleProductSteps
    {
        HomePage CCHome;
        public SelectSaleProductSteps()
        {
            CCHome = new HomePage();
        }
        [Given(@"I navigated the sales page")]
        public void GivenINavigatedTheSalesPage()
        {
            
        }
        
        [When(@"I selected the sales item")]
        public void WhenISelectedTheSalesItem()
        {

            CCHome.HomeSale();
        }
        
        [Then(@"I am taken to the selected sales item")]
        public void ThenIAmTakenToTheSelectedSalesItem()
        {
            CCHome.ValidateSaleProduct();
        }
    }
}
