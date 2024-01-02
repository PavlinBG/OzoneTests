using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTests.Pages;

namespace WebTests.Tests
{
    public class SearchFunctionalityTests
    {

        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            var home_page = new HomePage(driver);
            home_page.Open();

            IWebElement saveCookieStettngs = driver.FindElement(By.LinkText("Запази настройките"));

            saveCookieStettngs.Click();
        }

        [TearDown]
        public void BrowserShutDown()
        {
            driver.Quit();
        }


        [Test]
        public void HomeScreenTest()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            Assert.That(driver.Title, Is.EqualTo(home_page.GetPageUrl()));
        }


        [Test]
        public void Test_FooterTab_NavigatesToBlogPageUrl()
        {

             var searchFildBar  = new BasePage(driver).SearchBar;


             

            searchFildBar.Click();
            Thread.Sleep(2000);

            IWebElement SearchBarDropDown = driver.FindElement(By.Id("ui-id-1"));



            Assert.That(SearchBarDropDown.Displayed);
        }

        [Test]
        public void Test_HeaderFunctionality_VerifyNavigationToHomePage()
        {
            // Find the header element
            IWebElement headerElement = driver.FindElement(By.XPath("/html/body/header"));

            // Assert that the header element is displayed
            Assert.That(headerElement.Displayed);
        }


    }
}
