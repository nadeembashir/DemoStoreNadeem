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
    public class BestSellerPage
    {
        public BestSellerPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath,Using = "//div[@class='content']//span[@class='cloud-filters-filter-label__value" +
            " cloud-filters-filter-label__text'][contains(text(),'Red')]")]
        public IWebElement Filter_Colour_Red { get; set; }

        //Capasity, 256GB
        [FindsBy(How = How.XPath, Using = "//div[@class='content']//span[@class=" +
         "'cloud-filters-filter-label__value cloud-filters-filter-label__text'][contains(text(),'256')]")]
        public IWebElement Filter_Capacity256GB{ get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='content']//span[@class='cloud-filters-filter-label" +
            "__value cloud-filters-filter-label__text'][contains(text(),'2436x1125')]")]
        public IWebElement Filter_Resolution { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='content']//span[@class='cloud-filters-filter-label__value" +
            " cloud-filters-filter-label__text'][contains(text(),'Apple A11 Bionic')]")]
        public IWebElement Filter_Chip { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='content']//div[@class='cloud-filters-filter" +
            " cloud-filters-filter-bluetooth']//input")]
        public IWebElement Filter_BlueTooth { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='content']//div[@class='cloud-filters-filter cloud-filters-filter-dimension-inches']//input")]
        public IWebElement Filter_Dimention { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='content']//div[@class='cloud-filters-filter cloud-filters-filter-display-type']//input")]
        public IWebElement Filter_Display { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='content']//div[@class='cloud-filters-filter cloud-filters-filter-gps']//input")]
        public IWebElement Filter_GPS { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='content']//div[@class='cloud-filters-filter cloud-filters-filter-gsm-model']//input")]
        public IWebElement Filter_GSM_Model { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='content']//small[contains(text(),'Reset all filters')]")]
        public IWebElement RestAllFilters { get; set; }


    }
}
