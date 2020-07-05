using Speckflow2.PageObject;
using Speckflow2.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class SearchForItemSteps
    {
        HomePage HomeSearch;
        public SearchForItemSteps()
        {
            HomeSearch = new HomePage();
        }
        [Given(@"I am on demostore website")]
        public void GivenIAmOnDemostoreWebsite()
        {
            Hooks.driver.Navigate().GoToUrl("https://demostore.x-cart.com");
            Hooks.driver.Manage().Window.Maximize();
        }
        
        //[Given(@"I enter the item name is search box")]
        //public void GivenIEnterTheItemNameIsSearchBox()
        //{
        //    HomeSearch.SubmitSearchText();
        //}
        
        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            HomeSearch.ClickSearchButton();
        }
        
        //[Then(@"search item is displayed")]
        //public void ThenSearchItemIsDisplayed()
        //{
       
        //}
    }
}
