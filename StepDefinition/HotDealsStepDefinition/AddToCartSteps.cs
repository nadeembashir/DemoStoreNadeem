using Speckflow2.PageObject;
using Speckflow2.StepDefinition;
using System;
using TechTalk.SpecFlow;

namespace Speckflow2
{
    [Binding]
    public class AddToCartSteps
    {
        LoginPage Lpage;
        HotDealsPage HDeal;
        public AddToCartSteps()
        {
            HDeal = new HotDealsPage();
            Lpage =new LoginPage();
        }
        [Given(@"I am on DemoStore website")]
        public void GivenIAmOnDemoStoreWebsite()
        {
            
        }
        
        [When(@"I added the item to the cart")]
        public void WhenIAddedTheItemToTheCart()
        {
            HDeal.ClickHotDealLink();
            HDeal.ClickHotDealSale();
            HDeal.ClickSortByNewest();
            HDeal.Click_PinkSneaker_Addtocart();
           // HDeal.AddQuanitity();
            HDeal.AddToCartImage();
            HDeal.ViewCartItem();
            HDeal.ContinueShopingFromCart();
            HDeal.LaceUpBootClick();
            HDeal.AddtoCartLaceupBoot();
            HDeal.CheckoutItem();
            Lpage.Login_Checkout();
            HDeal.ProceedtoCheckout();
            HDeal.PaymentOptionSelection();
            HDeal.PlaceOrder();
            HDeal.OrderConfirmation_Message();
        }
        
        //[Then(@"I am able to place the order")]
        //public void ThenIAmAbleToPlaceTheOrder()
        //{
            
        //}
    }
}
