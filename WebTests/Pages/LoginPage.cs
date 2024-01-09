using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Pages
{
    public class LoginPage : BasePage
    {
        private readonly string username;
        private readonly string password;

        public override string PageUrl => "https://www.ozone.bg/customer/account/login/";

        public LoginPage(IWebDriver driver, string username, string password) : base(driver)
        {
            {
                this.username = username;
                this.password = password;
            }

        }
         

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void Login()
        {
            // Find the username and password input fields and enter the credentials
            IWebElement usernameInput = driver.FindElement(By.Id("email"));
            IWebElement passwordInput = driver.FindElement(By.Id("pass"));
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);


            // Submit the form
            IWebElement loginButton = driver.FindElement(By.Id("send2"));
            loginButton.Click();
        }

    }
}
