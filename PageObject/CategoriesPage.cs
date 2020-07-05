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
    public class CategoriesPage
    {
        public CategoriesPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        //Fashion
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Fashion')]")]
        public IWebElement Cartegory_Fashion { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='category-label'][contains(text(),'Clothing')]")]
        public IWebElement Cartegory_Fashion_Clothing { get; set; }

        [FindsBy(How = How.XPath, Using = " //span[@class='category-label'][contains(text(),'Shoes')]")]
        public IWebElement Cartegory_Fashion_Shoes { get; set; }

        [FindsBy(How = How.XPath, Using = " //span[@class='category-label'][contains(text(),'Accessories')]")]
        public IWebElement Cartegory_Fashion_Accessories { get; set; }

        //Beauti & Health
        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'Beauty & Health')]")]
        public IWebElement Cartegory_BeautyHealth { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Cosmetics')]")]
        public IWebElement Cartegory_BeautyHealth_Cosmetics { get; set; }

        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'Healthy Food & Snacks')]")]
        public IWebElement Cartegory_BeautyHealth_FoodSnacks { get; set; }

        //Electronics
        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'Electronics')]")]
        public IWebElement Cartegory_Electronics { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Smart watches')]")]
        public IWebElement Cartegory_Electronics_SmartWatch { get; set; }

        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'Mobile phones')]")]
        public IWebElement Cartegory_Electronics_Mobiles { get; set; }

    }
}
