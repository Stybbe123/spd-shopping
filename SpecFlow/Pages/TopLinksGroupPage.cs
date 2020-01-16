using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class TopLinksGroupPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "header#HeaderGroup a[class=login]")]
        private IWebElement LoginIcon;
        [FindsBy(How = How.CssSelector, Using = "div.ToplinksGroup [id=txtSearch]")]
        private IWebElement SearchField;
        [FindsBy(How = How.CssSelector, Using = "div.ToplinksGroup a[id=cmdSearch]")]
        private IWebElement SubmitSearch;
        [FindsBy(How = How.CssSelector, Using = "div.ToplinksGroup a[class=HeaderCheckoutLink]")]
        private IWebElement CheckoutButton;

        public TopLinksGroupPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void ClickLoginIcon()
        {
            WaitAndClick(LoginIcon);
        }

        public void SearchFieldFill(string searchString)
        {
            WaitAndClick(SearchField);
            SearchField.Clear();
            SearchField.SendKeys(searchString);
            WaitAndClick(SubmitSearch);
        }

        public void HeaderCheckoutClick()
        {
            WaitAndClick(CheckoutButton);
        }
    }
}
