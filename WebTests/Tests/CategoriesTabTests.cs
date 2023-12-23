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
    public class CategoriesTabTests
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

            driver.FindElement(By.LinkText("Категории")).Click();
            Thread.Sleep(500);
        }

        [TearDown]
        public void BrowserShutDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToGameingCategoriePageUrl()
        {
            
            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.Gameing.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.GameingPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToBookStoreCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.BookStore.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.BookStorePageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToMusicAndMoviesCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.MusicAndMovies.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.MusicAndMoviesPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToMerchandiseCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.Merchandise.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.MerchandisePageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToLaptopsPCsMonitorsCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.LaptopsPCsMonitors.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.LaptopsPCsMonitorsPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToAudioAndHiFiSystemsCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.AudioAndHiFiSystems.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.AudioAndHiFiSystemsPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToSmartPhonesAndTabletsCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.SmartPhonesAndTablets.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.SmartPhonesAndTabletsPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToTVPhotoVideoCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.TVPhotoVideo.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.TVPhotoVideoPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToSmallElecticalAppliancesCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.SmallElecticalAppliances.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.SmallElecticalAppliancesPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToToysCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.Toys.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.ToysPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToProducstsForBabyAndMotherCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.ProducstsForBabyAndMother.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.ProducstsForBabyAndMotherPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToProducstGamesAndPuzzelesCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.GamesAndPuzzeles.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.GamesAndPuzzelesPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToHealthAndBeautyCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.HealthAndBeauty.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.HealthAndBeautyPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToSportAndOutdoorCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.SportAndOutdoor.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.SportAndOutdoorPageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToForTheHomeCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.ForTheHome.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.ForTheHomePageUrl));
        }

        [Test]
        public void Test_CategoriesTab_NavigatesToForTheOfficeCategoriePageUrl()
        {

            var categoriesTabLink = new CategoriesTab(driver);

            categoriesTabLink.ForTheOffice.Click();

            Assert.That(driver.Url, Is.EqualTo(categoriesTabLink.ForTheOfficePageUrl));
        }
    }
}
