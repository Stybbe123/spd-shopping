using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class SearchResultPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div#productlistcontainer ul li:nth-of-type(1)")]
        private IWebElement FirstAvailableProduct;

        public SearchResultPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void ClickFirstItem()
        {
            WaitAndClick(FirstAvailableProduct);
        }
    }
}
