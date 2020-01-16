using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class SPDHomePage : BasePage
    {

        private const String PageTitle = "SportsDirect.com – The UK’s No 1 Sports Retailer";
        private const String PageUrl = "https://www.sportsdirect.com/";

        public SPDHomePage()
        {
            PageFactory.InitElements(Driver, this);
        }

        private String GetPageTitle()
        {
            return Driver.Title;
        }

        public void OpenHomePage()
        {
            Driver.Navigate().GoToUrl(PageUrl);
        }

        public void CheckTitle()
        {
            AssertHelper.TwoStringsMatch(PageTitle, GetPageTitle());
        }

    }
}
