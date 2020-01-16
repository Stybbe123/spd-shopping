using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow.Helpers
{
    public class ElementActions
    {
        private Actions Actions;
        public ElementActions(Actions Actions)
        {
            this.Actions = Actions;
        }

        public void ScrollToElement(IWebElement WebElement)
        {
            Actions.MoveToElement(WebElement);
            Actions.Perform();
        }

        
    }
}
