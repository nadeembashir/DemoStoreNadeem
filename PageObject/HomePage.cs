
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Speckflow2.Utilities;
using System;
using System.Threading;

namespace Speckflow2.PageObject
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        //Moving Banners
        [FindsBy(How = How.XPath, Using = "//div[@id='banner-rotation-widget']//li[1]")]
        public IWebElement NewColectionSale_Banner1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[@id='banner-rotation-widget']//li[2]")]
        public IWebElement HealthFoodSnack_Banner2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='banner-rotation-widget']//li[3]")]
        public IWebElement SmartLimitedEdion_Banner3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[3]//img[1]")]
        public IWebElement Click_Banner3 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//h1")]
        public IWebElement VertifyTitle_Electronic { get; set; }

       
        //Top Search bar
        [FindsBy(How = How.XPath, Using = "//form[@id='form-1592588511192']//input[@placeholder='Search items...']")]
        public IWebElement SearchText { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//form[@id='form-1592167893601']//button[contains(@class,'regular-button submit-button submit')]")]
        public IWebElement SearchButton { get; set; }

        //Validate the product appears
        [FindsBy(How = How.XPath, Using = " //div[@class='product productid-29 compare']//img[@class='photo ls-is-cached lazyloaded']")]
        public IWebElement SearchValidation { get; set; }

        
        //Country & Currency
        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'country-indicator')]")]
        public IWebElement SelectCountryLink { get; set; }

        // dropdown command required in method
        [FindsBy(How = How.XPath, Using = "//select[@id='country_code_1']//option[contains(text(),'Argentina')]")]
        public IWebElement SelectCountryDropDown { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//select[@id='currency_code_1']//option[contains(text(),'Australian Dollar')]")]
        public IWebElement SelectCurrencyCodeDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='language_1']")]
        public IWebElement CountryLanguageSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='language_1']//option[contains(text(),'English')]")]
        public IWebElement LanguageSelectedEnglish { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[2]/div[2]/div[1]/ul[1]/li[1]/form[1]/div[4]/button[1]")]
        public IWebElement CountrySave { get; set; }
        
        [FindsBy(How = How.ClassName, Using = "country-indicator")]
        public IWebElement ValidateCountry { get; set; }
        //This is another save button Xpath
        ////form[@id='form-1592166264662']//span[contains(text(),'Save')]


        //MyAccount / Signup-SignIn 
        // Method is not added yet
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My account')]")]
        public IWebElement ClickMyAccountLink { get; set; }

        //Welcome to X-Cart Demo Store! *(We have verified the electronic page)

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Fashion')]")]
        public IWebElement XCart_Fashion_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Beauty & Health')]")]
        public IWebElement XCart_BeautyHealth_Link { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[3]//a[1]//span[1]//img[1]")]
        public IWebElement XCart_Electronics_Link { get; set; }


        //Feature Products
        [FindsBy(How = How.XPath, Using = " //div[4]//div[1]//div[1]//div[1]//ul[1]//li[4]//div[1]//div[1]//a[1]//img[1]")]
        public IWebElement Feature_AppleAirPod { get; set; }
        //This is another  Xpath
        //-----//div[@class='product productid-35']//li[@class='product-price-base']

        //Validation for feature product
        [FindsBy(How = How.XPath, Using = "//li[1]//div[1]//div[1]//a[1]//img[1]")]
        public IWebElement Validation_AppleAirPod { get; set; }


        //Sale
        [FindsBy(How = How.XPath, Using = " //div[5]//div[1]//div[1]//div[1]//ul[1]//li[2]//div[1]//div[1]//a[1]//img[1]")]
        public IWebElement Sale_LaceupBoots { get; set; }

        // --//div[@class='product productid-6']//img[@class='photo lazyloaded']

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/div/div/div/div/div/div/div/div/div/img[1]")]
        public IWebElement Validat_LaceupBoots { get; set; }


        //Bestsellers
        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div[6]//div[1]//div[1]//div[1]//ul[1]//li[1]//div[1]//div[1]//a[1]//img[1]")]
        public IWebElement Bestsellers_WaistTieDress { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/div/div/div/div/div/div/div/div/div/img[1] ")]
        public IWebElement Validate_BestSeller_Waist { get; set; }


        //New Arrivals
        [FindsBy(How = How.XPath, Using = "//div[7]//div[1]//div[1]//div[1]//ul[1]//li[2]//div[1]//div[1]//a[1]//img[1]")]
        public IWebElement NewArrivals_SkinnyDress { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/div/div/div/div/div/div/div/div/div/img[1]")]
        public IWebElement Validation_NewArrivals_Dress { get; set; }


        // Sign up for x-cart demo store company news
        [FindsBy(How = How.Id, Using = "newlettersubscription-email")]
        public IWebElement NewsLetterSubscrptionEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/form/div/button/span[1]")]
        public IWebElement SubscribeButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='subscription-success-block']")]
        public IWebElement Validate_Subscribe { get; set; }

        
        // ----------------------- Methods ----------------------------------------

        // Banner method
        public void GoToThirdBanner()
        {
            SmartLimitedEdion_Banner3.Click();
        }

        public void ClickThirdBanner()
        {
            Click_Banner3.Click();
        }
        // Verify banner3 
        public void VertifyTilteElecronicPage()
        {
            Assert.AreEqual(VertifyTitle_Electronic.Text, "Electronics");
            Console.WriteLine(VertifyTitle_Electronic + "Electronics page displayed");             
        }

                  
        // Search bar method
        public void SubmitSearchText()
        {
            SearchText.SendKeys("IPhone");
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }
        // need to verify 
        // Verify search from search bar 
        public void ConfirmSearchValidation()
        {
            //Assert.IsTrue(SearchValidation.Text, "IPhone");
           
        }

        // Country, currency and language method
        public void CountryCurrencyMethod()
        {
            Thread.Sleep(1000);
            SelectCountryLink.Click(); // Click on country 

            //SelectElement DropDownCountry = new SelectElement(SelectCountryDropDown);
            //DropDownCountry.SelectByText("AU");
            Thread.Sleep(1000);

            SelectCountryDropDown.Click(); // Country selected from dropdown box

            SelectCurrencyCodeDropDown.Click(); // Currency selected from dropdown box
           
            //SelectElement DropDownCurrency = new SelectElement(SelectCountryDropDown);
            //DropDownCurrency.SelectByText("");

            CountryLanguageSelection.Click(); // Click on language dropdown box
            //SelectElement DropDownLanguage = new SelectElement(LanguageSelectedRus);
            //DropDownLanguage.SelectByText("Русский");
            //CountryLanguageSelection.Click();
            
            LanguageSelectedEnglish.Submit(); // English language selected
            Thread.Sleep(1000);
            CountrySave.Click(); // Click on <Save> button
        }

        // Verify country
        public void ConfirmCountryCurency()
        {
            Assert.AreEqual(ValidateCountry.Text, "Argentina");
            Console.WriteLine(ValidateCountry + "Country is displayed");
        }


        //select Categories from 'Welcome to X-Cart Demo store!' 
        // Fashion
        public void XCartFashionMethod()
        {
            XCart_Fashion_Link.Click();
        }

        // Beauty & Health
        public void XCartBeautyMethod()
        {
            XCart_BeautyHealth_Link.Click();

        }

        // Elctronics
        public void XCartElectronicsMethod()
        {
            XCart_Electronics_Link.Click();
        }

        //Select Feature Product - AppleAirpod  
        public void FeatureProductSelection()
        {
            Feature_AppleAirPod.Click();
        }

        // Verify feature product
        public void ValidationFeatureProduct()
        {
            Assert.IsTrue(Validation_AppleAirPod.Displayed);           
            Console.WriteLine(VertifyTitle_Electronic + "Apple airpods displayed");                     
        }

        // Sale method
        public void HomeSale()
        {
            Sale_LaceupBoots.Click();
        }

        // Verify Sale product - Lace-Up boots
        public void ValidateSaleProduct()
        {
            Assert.IsTrue(Validat_LaceupBoots.Displayed);
            Console.WriteLine(Validat_LaceupBoots + "LaceBoots displayed");

        }

        // Best seller method
        public void HomeBestSeller()
        {
            Bestsellers_WaistTieDress.Click();
        }

        // Verify 
        public void Validat_BestSaller()
        {
            Assert.IsTrue(Validate_BestSeller_Waist.Displayed);
            Console.WriteLine(Validate_BestSeller_Waist + "Best seller displayed");
        }

        // New Arrivals method
        public void HomeNewArrival()
        {
            NewArrivals_SkinnyDress.Click();
        }

        // Verify 
        public void Validat_NerArrivals()
        {
            Assert.IsTrue(Validation_NewArrivals_Dress.Displayed);
            Console.WriteLine(Validation_NewArrivals_Dress + "New arrival displayed"); ;
        }

        // Sign up method
        public void HomeSignupNews(string email)
        {
            NewsLetterSubscrptionEmail.SendKeys(email);
        }

        // Click <Subscribe>
        public void HomeSubscribe()
        {
            SubscribeButton.Click();
        }

        // Verify 
        public void HomeSuscribeValidation()
        {
            Thread.Sleep(1000);
            //Assert.Contains((Validate_Subscribe.Text, "Thank you");
            Assert.AreEqual(Validate_Subscribe.Text, "Thank you for subscribing to the newsletter! We hope you enjoy shopping at X-Cart Demo store company");
        }


    }

}

