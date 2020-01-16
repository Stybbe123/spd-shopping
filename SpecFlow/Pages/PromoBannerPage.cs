using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow.Pages
{
    class PromoBannerPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div#advertPopup button[class=close")]
        private IWebElement PromoCloseButton;

        public PromoBannerPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void ClosePromoPage()
        {
            WaitAndClick(PromoCloseButton);
        }
    }
}