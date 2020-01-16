using SpecFlow.Helpers;
using SpecFlow.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    public class MintosQASteps
    {
        readonly SPDHomePage SPDHomePage = new SPDHomePage();
        readonly PromoBannerPage PromoBannerPage = new PromoBannerPage();
        readonly TopLinksGroupPage TopLinksGroupPage = new TopLinksGroupPage();
        readonly LoginPage LoginPage = new LoginPage();
        readonly SearchResultPage SearchResultPage = new SearchResultPage();
        readonly ProductPage ProductPage = new ProductPage();
        readonly CartPage CartPage = new CartPage();
        readonly SelectPaymentPage SelectPaymentPage = new SelectPaymentPage();
        readonly SelectDeliveryPage SelectDeliveryPage = new SelectDeliveryPage();
        readonly CardPaymentPage CardPaymentPage = new CardPaymentPage();

        [Given(@"I can open sportdirect home page")]
        public void GivenICanOpenSportdirectHomePage()
        {
            SPDHomePage.OpenHomePage();
        }

        [When(@"Home page title check")]
        public void HomePageTitleCheck()
        {
            SPDHomePage.CheckTitle();
        }

        [When(@"Accept Promo Banner")]
        public void WhenAcceptPromoBanner()
        {
            PromoBannerPage.ClosePromoPage();
        }

        [When(@"Login with '(.*)' and '(.*)'")]
        public void WhenLoginAsWith(string email, string password)
        {
            TopLinksGroupPage.ClickLoginIcon();
            LoginPage.LoginUsing(email, password);
        }

        [When(@"Search field input '(.*)'")]
        public void WhenSearchFieldInput(string searchString)
        {
            TopLinksGroupPage.SearchFieldFill(searchString);
        }

        [When(@"Click first item on results page")]
        public void WhenClickFirstItemOnResultsPage()
        {
            SearchResultPage.ClickFirstItem();
        }

        [When(@"Select first available size on product page")]
        public void WhenSelectFirstAvailableSizeOnProductPage()
        {
            ProductPage.SelectFirstAvailableSize();
        }

        [When(@"Click add to Bag button")]
        public void WhenClickAddToBagButton()
        {
            ProductPage.ClickAddToBag();
        }

        [When(@"Click Checkout button")]
        public void WhenClickCheckoutButton()
        {
            TopLinksGroupPage.HeaderCheckoutClick();
        }

        [When(@"Click Continue Securely")]
        public void WhenClickContinueSecurely()
        {
            CartPage.ContinueSecurelyClick();
        }

        [When(@"Select standard delivery")]
        public void WhenSelectStandardDelivery()
        {
            SelectDeliveryPage.SelectStandardDelivery();
        }

        [When(@"Continue Securely")]
        public void WhenContinueSecurely()
        {
            SelectDeliveryPage.ContinueWithSelectedDelivery();
        }

        [When(@"Pay With Card")]
        public void WhenPayWithCard()
        {
            SelectPaymentPage.SelectPayWithCard();
        }

        [Then(@"Go to Edit Bag")]
        public void ThenGoToEditBag()
        {
            CardPaymentPage.GoToEditBag();
        }

        [Then(@"Clean up the Cart")]
        public void ThenCleanUpTheCart()
        {
            CartPage.RemoveAllItemsFromTheCart();
        }



    }
}
