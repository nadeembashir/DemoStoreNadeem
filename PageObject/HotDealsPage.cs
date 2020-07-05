using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Speckflow2.Utilities;

namespace Speckflow2.PageObject
{
    class HotDealsPage
    {
        public HotDealsPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = " //ul[@class='nav navbar-nav top-main-menu']//span[@class='primary-title'][contains(text(),'Hot deals')]")]
        public IWebElement HotDeal { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='leaf has-sub']//span[contains(text(),'Sale')]")]
        public IWebElement HotDeal_Sale { get; set; }
        
        //Sortby New
        [FindsBy(How = How.XPath, Using = " //div[@class='sort-box']//div")]
        public IWebElement HotDeal_Sale_SortBy { get; set; }

        [FindsBy(How = How.XPath, Using = " //a[contains(text(),'Newest first')]")]
        public IWebElement HotDeal_Sale_SortBy_Newest { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Pink Sneakers with White Soles')]")]
        public IWebElement ValidateNewest { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'regular-button add-to-cart product-add2cart productid-8')]//span[contains(text(),'Add to cart')]")]
        public IWebElement ImagAddtoCart { get; set; }

        

        // add quantity     
        [FindsBy(How = How.Id, Using = "amount")]
        public IWebElement Quantity { get; set; }

        // add to cart (PinkSneaker)
        //[FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//div//div//div//form//div//div//div//button//span[contains(text(),'Add to cart')]")]
        //public IWebElement AddtoCart_PinkSneaker { get; set; }

        // add to cart Laceup Boots
        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//div//div//div//form//div//div//div//button")]
        public IWebElement AddtoCart_LaceUpBoot { get; set; }

        //view cart
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'item-buttons')]//span[contains(text(),'View cart')]")]
        public IWebElement ViewCart { get; set; }

        //check out
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'item-buttons')]//span[contains(text(),'Checkout')]")]
        public IWebElement CheckOut { get; set; }

        //continue shopping
        [FindsBy(How = How.XPath, Using = "//div[@id='cart-right']//span[contains(text(),'Continue shopping')]")]
        public IWebElement ContinueShopping { get; set; }

        // second item LaceupBoot from Sale Page
        [FindsBy(How = How.XPath, Using = " //li[2]//div[1]//div[1]//a[1]//img[1]")]
        public IWebElement LaceUpBootsClick { get; set; }

        //Proceed th checkout
        [FindsBy(How = How.XPath, Using = "//button[@class='btn regular-button regular-main-button checkout_fastlane_section-next']")]
        public IWebElement ProceedtoCheckoutClick { get; set; }

        //Payment method selection
        [FindsBy(How = How.Id, Using = "pmethod29")]
        public IWebElement PaymentClick { get; set; }

        //place Order
        [FindsBy(How = How.XPath, Using = " //button[@class='btn regular-button regular-main-button checkout_fastlane_section-place_order place-order']")]
        public IWebElement PlacOrderClick { get; set; }


        // order confirmation - Thank you message
        [FindsBy(How = How.Id, Using = "page-title")]
        public IWebElement OrderConfirmation { get; set; }


        [FindsBy(How = How.ClassName, Using = "primary-title")]
        public IWebElement HotDeals { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='leaf has-sub']//span[contains(text(),'Sale')]")]
        public IWebElement Sales { get; set; }

        [FindsBy(How = How.ClassName, Using = "add-to-cart-button")]
        public IWebElement WatchAddtoCart { get; set; }
        
        //View Type
        [FindsBy(How = How.XPath, Using = "//i[@class='grid icon-grid-view']")]
        public IWebElement HotDeal_Sale_ViewGrid { get; set; }

        [FindsBy(How = How.XPath, Using = " //i[@class='list icon-list-view']")]
        public IWebElement HotDeal_Sale_ViewList { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='table icon-table-view']")]
        public IWebElement HotDeal_Sale_ViewTable { get; set; }

        // View per page
        [FindsBy(How = How.XPath, Using = "//span[@class='per-page-label']")]
        public IWebElement HotDeal_Sale_ProductPerPage { get; set; }

        //24 per page
        [FindsBy(How = How.XPath, Using = "h //a[contains(text(),'24')]")]
        public IWebElement HotDeal_Sale_24PerPage { get; set; }

        public void ClickHotDealLink()
        {
            HotDeal.Click();
        }

        public void ClickHotDealSale()
        {
            HotDeal_Sale.Click();
        }
       
        public void ClickSortByNewest()
        {
            HotDeal_Sale_SortBy.Click();
            HotDeal_Sale_SortBy_Newest.Click();
        }

        public void ValidateNewestItem()
        {
            Assert.AreEqual(ValidateNewest.Text, "Pink Sneakers with White Soles");
            System.Console.WriteLine(ValidateNewest.Text);
            //Assert.IsTrue(ValidateNewest.Displayed);           
            //System.Console.WriteLine(ValidateNewest.Text);
        }

        public void Click_PinkSneaker_Addtocart()
        {
            Actions action = new Actions(Hooks.driver);
            IWebElement Hover = Hooks.driver.FindElement(By.XPath(" //div[contains(@class,'product productid-8')]//img[contains(@class,'photo ls-is-cached lazyloaded')]"));
            action.MoveToElement(Hover).Perform();
            ImagAddtoCart.Click();
        }

        //public void Click_LaceupBoot_Addtocart()
        //{
        //    Actions action = new Actions(Hooks.driver);
        //    IWebElement Hover = Hooks.driver.FindElement(By.XPath(" //div[contains(@class,'product productid-8')]//img[contains(@class,'photo ls-is-cached lazyloaded')]"));
        //    action.MoveToElement(Hover).Perform();
        //    ImagAddtoCart.Click();
        //}


        public void AddQuanitity()
        {
            Quantity.Click();
        }
        public void AddToCartImage()
        {
            ImagAddtoCart.Click();
        }

        public void ViewCartItem()
        {
            ViewCart.Click();
        }

        public void CheckoutItem()
        {
            CheckOut.Click();
        }

        public void ContinueShopingFromCart()
        {
            ContinueShopping.Click();
        }

        public void LaceUpBootClick()
        {
            LaceUpBootsClick.Click();
        }
        
        public void AddtoCartLaceupBoot()
        {
            AddtoCart_LaceUpBoot.Click();
        }

        public void ProceedtoCheckout()
        {
            ProceedtoCheckoutClick.Click();
        }

        public void PaymentOptionSelection()
        {
            PaymentClick.Click();
        }

        public void PlaceOrder()
        {
            PlacOrderClick.Click();
        }

        public void OrderConfirmation_Message()
        {
            Assert.AreEqual(OrderConfirmation.Text, "Thank you for your order");
            System.Console.WriteLine("Message displayed "+ OrderConfirmation.Text);
        }
        public void ClickHotDealViewGrid()
        {

        }
    }

}


/*
            Actions action = new Actions(Hooks.driver);
            IWebElement Hover = Hooks.driver.FindElement(By.XPath("//ul[@class='nav navbar-nav top-main-menu']//span[@class='primary-title'][contains(text(),'Hot deals')]"));
            action.MoveToElement(Hover).Perform();
           
            Sales.Click();
            Thread.Sleep(1000);

            Actions action1 = new Actions(Hooks.driver);
            IWebElement Hover1 = Hooks.driver.FindElement(By.ClassName("add-to-cart-button"));
            action1.MoveToElement(Hover1).Perform();
            WatchAddtoCart.Click();
*/