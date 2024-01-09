using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTests.Base;
using WebTests.Pages;

namespace WebTests.Tests
{
    public class LoginTests
    {

        private IWebDriver driver;
        private string username;
        private string password;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            username = LoadProperties.GetProperty("user.username");
            password = LoadProperties.GetProperty("user.password");

            var login_page = new LoginPage(driver);
            login_page.Open();
        }

        [Test]
        public void Login_Successful()
        {
            var loginPage = new LoginPage(driver, username, password);
            loginPage.Login();

            // Add assertions to verify that the login was successful
        }


        [Test]
        public void Login_IncorrectUsername()
        {
            var incorrectUsername = "incorrect_username";
            var loginPage = new LoginPage(driver, incorrectUsername, password);
            loginPage.Login();

            // Add assertions to verify that the login failed due to incorrect username
        }

        [Test]
        public void Login_InvalidCredentials()
        {
            var invalidUsername = "invalid_username";
            var invalidPassword = "invalid_password";
            var loginPage = new LoginPage(driver, invalidUsername, invalidPassword);
            loginPage.Login();

            // Add assertions to verify that the login failed due to invalid credentials
        }


    }
}
