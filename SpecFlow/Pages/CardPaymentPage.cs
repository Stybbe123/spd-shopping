using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class CardPaymentPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[id*=lnkEditCart]")]
        private IWebElement EditBagLink;

        public CardPaymentPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void GoToEditBag()
        {
            WaitAndClick(EditBagLink);
        }
    }
}
