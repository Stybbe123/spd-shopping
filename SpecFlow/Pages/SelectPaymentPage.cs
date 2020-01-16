using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class SelectPaymentPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "ul.PaymentMethodList span.eur")]
        private IWebElement PayWithCardPayment;

        public SelectPaymentPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void SelectPayWithCard()
        {
            WaitAndClick(PayWithCardPayment);
        }
    }
}
