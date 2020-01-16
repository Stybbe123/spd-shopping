using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class ProductPage : BasePage
    {
        //div.swapSize li:not([class*='greyOut'])
        [FindsBy(How = How.CssSelector, Using = "div.swapSize li:nth-of-type(1)")]
        private IWebElement FirstAvailableSize;
        [FindsBy(How = How.CssSelector, Using = "span[class*=addToBagInner]")]
        private IWebElement AddToBagButton;

        public ProductPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void SelectFirstAvailableSize()
        {
            WaitAndClick(FirstAvailableSize);
        }

        public void ClickAddToBag()
        {
            WaitAndClick(AddToBagButton);
        }
    }
}
