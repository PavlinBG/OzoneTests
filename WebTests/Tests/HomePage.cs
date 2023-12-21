using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebTests.Pages;

namespace WebTests.Tests
{
    public class HomeScreen
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            var home_page = new HomePage(driver);
            home_page.Open();
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
        public void Test_Homepage_LoadsSuccessfully()
        {

            Assert.That(!string.IsNullOrEmpty(driver.Title));
        }



        [Test]
        public void Test_Homepage_Title()
        {
            string epectedTitle = "Mагазин за игри, книги, геймърски аксесоари и играчки | Ozone.bg";


            Assert.That(driver.Title, Is.EqualTo(epectedTitle));

        }

        [Test]
        public void Test_Homepage_LogoDisplayed()
        {
             IWebElement logoElement = driver.FindElement(By.XPath("/html/body/header/div[1]/div/div[1]/a/img"));

             Assert.That(logoElement.Displayed);
        }

        [Test]
        public void Test_HomePage_SearchBarDisplayed()
        {
            IWebElement searchBarElement = driver.FindElement(By.Id("search"));

            Assert.That(searchBarElement.Displayed);
        }




        [Test]
        public void Test_HomePage_NavBarDisplayed()
        {
            IWebElement categoriesSection = driver.FindElement(By.CssSelector("body > header > div.wide-area.navigation > div > div > div > nav"));

            Assert.That(categoriesSection.Displayed);
        }


        /*
        //The test passes 


        [Test]
        public void Test_HomePage_NavigatesToHomePage()
        {

            //The test passes 

            var homePage = new HomePage(driver);

            string initialUrl = driver.Url;

            homePage.HomeLink.Click();

            string navigatedUrl = driver.Url;

            Assert.That(navigatedUrl, Is.EqualTo(homePage.PageUrl));


        }

        */ 

        [Test]
        public void Test_HomePage_NavigatesToLastAddedPageUrl()
        {
            var homePage = new HomePage(driver);

             homePage.LastAdded.Click();

             Assert.That(driver.Url, Is.EqualTo(homePage.LastAddedPageUrl));  
        }

        [Test]
        public void Test_HomePage_NavigatesToOutletPageUrl()
        {
            var homePage = new HomePage(driver);

            homePage.OutLet.Click();

            Assert.That(driver.Url, Is.EqualTo(homePage.OutletPageUrl));
        }

        [Test]
        public void Test_HomePage_NavigatesToUnpackedPageUrl()
        {
            var homePage = new HomePage(driver);

            homePage.Unpacked.Click();

            Assert.That(driver.Url, Is.EqualTo(homePage.UnpackedPageUrl));
        }

      

        [Test]
        public void Test_HomePage_NavitesDiscontPageUrl()
        {
            var homePage = new HomePage(driver);

             homePage.Discount.Click();

             Assert.That(driver.Url, Is.EqualTo(homePage.DiscontPageUrl)); 
        }


        [Test]
        public void Test_HomePage_NavitesOurStorePageUrl()
        {
            var homePage = new HomePage(driver);

            homePage.OurStore.Click();

            Assert.That(driver.Url, Is.EqualTo(homePage.OurStorePageUrl));
        }




      




        [Test]
        public void Test_Homepage_FooterDisplayed()
        {
            // Find the footer section on the homepage
            IWebElement footerSection = driver.FindElement(By.XPath("/html/body/footer"));

            // Assert that the footer section is displayed
            Assert.That(footerSection.Displayed);
        }



        [Test]
        public void Test_Homepage_FooterLinks()
        {
            IWebElement footerLink = driver.FindElement(By.XPath("/html/body/footer/div[1]/div[1]/div/div[1]/div/a[1]/img"));

            footerLink.Click();

            string currentPageTitle = driver.Title;

            Assert.That(!string.IsNullOrEmpty(currentPageTitle));
        }




        [Test]
        public void Test_HomePage_SocialMediaLink()
        {

            IWebElement socialMediaLink = driver.FindElement(By.XPath("/html/body/footer/div[1]/div[1]/div/div[1]/div/a[2]"));

            string actualHref = socialMediaLink.GetAttribute("href");

            string expectedHref = "https://www.facebook.com/Ozone.bg";

            Assert.AreEqual(expectedHref, actualHref, $"Expected URL: {expectedHref}. Actual URL: {actualHref}");
        }




        [Test]
        public void Test_Homepage_ResponsiveDesign()
        {
           
            Assert.That(driver.FindElement(By.TagName("body")).Displayed);

             driver.Manage().Window.Maximize();
        }



    }
}