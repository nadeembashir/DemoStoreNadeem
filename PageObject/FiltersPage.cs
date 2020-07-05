using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Speckflow2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speckflow2.PageObject
{
    class FiltersPage
    {
        public FiltersPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        //price - Filter
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//input[@placeholder='$6.49']")]
        public IWebElement Filter_StartPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "h //div[@class='content']//input[@placeholder='$47.99']")]
        public IWebElement FilterEndPrice { get; set; }

        //Mufacturer
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//div[@class='cloud-filters-filter cloud-filters-filter-manufacturer']//input")]
        public IWebElement FilterCheckBox_Mnftr { get; set; }

        // Catetory - Filter (Not Done)
        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement FilterCategoryClothing { get; set; }

        // Size UK 12 (Not Done)
        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement FilterSizeUk12 { get; set; }

    }
}
