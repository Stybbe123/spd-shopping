using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class CartPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.newBasketSummary a.ContinueOn")]
        private IWebElement ContinueSecurelyButton;
        [FindsBy(How = How.CssSelector, Using = "input[type=number]")]
        private IWebElement ItemNumber;
        [FindsBy(How = How.CssSelector, Using = "a.NewUpdateQuant")]
        private IWebElement BagUpdateNumbersButton;
        //a.NewUpdateQuant

        public CartPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void ContinueSecurelyClick()
        {
            WaitAndClick(ContinueSecurelyButton);
        }

        public void RemoveAllItemsFromTheCart()
        {
            WaitAndClick(ItemNumber);
            ItemNumber.Clear();
            ItemNumber.SendKeys("0");
            BagUpdateNumbersButton.Click();
        }
    }
}
