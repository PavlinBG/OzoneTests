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
    public  class FooterTests
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            var home_page = new FooterTab(driver);
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
        public void Test_FooterTab_NavigatesToAboutUsPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.AboutUs.Click();

            Assert.That(driver.Url, Is.EqualTo(footerTabLink.AboutUsPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToGeneraltermsPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Generalterms.Click();

            Assert.That(driver.Url, Is.EqualTo(footerTabLink.GeneraltermsPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToPrivacyPolicyPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.PrivacyPolicy.Click();

            Assert.That(driver.Url, Is.EqualTo(footerTabLink.PrivacyPolicyPageUrl));
        }


        [Test]
        public void Test_FooterTab_NavigatesToWorkAtOzonePageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.WorkAtOzone.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.WorkAtOzonePageUrl));
        }


        [Test]
        public void Test_FooterTab_NavigatesToBlogPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.BlogPage.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.BlogPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToContactsPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Contacts.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.ContactsPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesFrequentlyAskedQuestionsToPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.FrequentlyAskedQuestions.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.FrequentlyAskedQuestionsPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToHowToShopPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.HowToShop.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.HowToShopPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToDeliveryPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Delivery.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.DeliveryPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToPaymentOfInstallmentsPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.PaymentOfInstallments.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.PaymentOfInstallmentsPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToQuestionsAndDisputeResolutionPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.QuestionsAndDisputeResolution.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;


            Assert.That(currentUrl, Is.EqualTo(footerTabLink.QuestionsAndDisputeResolutionPageUrl));
        }



        [Test]
        public void Test_FooterTab_NavigatesToSiteMapPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.SiteMap.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.SiteMapPageUrl));
        }



        [Test]
        public void Test_FooterTab_NavigatesToOzoneBooksPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Delivery.Click();



            Assert.That(driver.Url, Is.EqualTo(footerTabLink.DeliveryPageUrl));
        }


        [Test]
        public void Test_FooterTab_NavigatesToBabyBGPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.BabyBG.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.BabyBGPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToOzoneROPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.OzoneRO.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.OzoneROPageUrl));
        }

        [Test]
        public void Test_FooterTab_NavigatesToOzoneHRPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.OzoneHR.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.OzoneHRPageUrl));
        }


        [Test]
        public void Test_FooterTab_NavigatesToOzonGRPageUrl()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.OzonGR.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.OzonGRPageUrl));
        }


        [Test]
        public void Test_FooterTab_SocialNavigateFacebook()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Facebook.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.FacebookPageUrl));
        }

        [Test]
        public void Test_FooterTab_SocialNavigateInstagram()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Instagram.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.InstagramPageUrl));
        }

        [Test]
        public void Test_FooterTab_SocialNavigateTiktok()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Tiktok.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.TiktokPageUrl));
        }

        /*
         * The test passes

        [Test]
        public void Test_FooterTab_SocialNavigateYoutube()
        {
            var footerTabLink = new FooterTab(driver);

            footerTabLink.Youtube.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(1000);
            string currentUrl = driver.Url;

            Assert.That(currentUrl, Is.EqualTo(footerTabLink.YoutubePageUrl));
        }

         */
    }
}
