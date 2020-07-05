using Speckflow2.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Speckflow2.StepDefinition.HomeStepDefinition
{
    [Binding]
    public class CurrencyCountryDefinition
    {
        HomePage CCHome;
        public CurrencyCountryDefinition()
        {
            CCHome = new HomePage();
        }
        [Given(@"I  am on xcart  website")]
        public void GivenIAmOnXcartWebsite()
        {
            
        }

        [When(@"I have selected all details and click save")]
        public void WhenIHaveSelectedAllDetailsAndClickSave()
        {
            CCHome.CountryCurrencyMethod();
        }

        //[Then(@"details are saved")]
        //public void ThenDetailsAreSaved()
        //{
        //    CCHome.ConfirmCountryCurency();
        //}

    }
}
