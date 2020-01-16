using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Pages
{
    class LoginPage : BasePage
    {
        
        [FindsBy(How = How.CssSelector, Using = "div.loginContainer input[type=email]")]
        private IWebElement EmailAddressField;
        [FindsBy(How = How.CssSelector, Using = "div.loginContainer input[type=password]")]
        private IWebElement PasswordField;
        [FindsBy(How = How.CssSelector, Using = ".existingCustomer a.InvalidateCustDataStorage")]
        private IWebElement SignInSecurelyButton;

        public LoginPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void LoginUsing(string Email, string Password)
        {
            WaitAndClick(EmailAddressField);
            EmailAddressField.Clear();
            EmailAddressField.SendKeys(Email);

            WaitAndClick(PasswordField);
            PasswordField.Clear();
            PasswordField.SendKeys(Password);

            WaitAndClick(SignInSecurelyButton);
        }
    }
}
