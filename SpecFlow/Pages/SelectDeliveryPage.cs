using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class SelectDeliveryPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.DeliveryOptions li.DeliveryOptionsItem_EUR")]
        private IWebElement StandardDelivery;
        private string ToGoPaymentLocator = "[onclick*=DeliveryOptionSelector]";

        public SelectDeliveryPage()
        {
            PageFactory.InitElements(Driver, this);
        }
        
        public void SelectStandardDelivery()
        {
            WaitAndClick(StandardDelivery);
        }

        public void ContinueWithSelectedDelivery()
        {
            IReadOnlyCollection<IWebElement> anchors = Driver.FindElements(By.CssSelector(ToGoPaymentLocator));
            foreach (IWebElement anchor in anchors)
            {
                if(anchor.Displayed)
                {
                    WaitAndClick(anchor);
                }
            }
                
        }

    }
}