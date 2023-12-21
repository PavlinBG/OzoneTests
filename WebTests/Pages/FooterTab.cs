using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Pages
{
    public class FooterTab : BasePage   
    {
        public FooterTab(IWebDriver driver) : base(driver) {

        }

        public string AboutUsPageUrl => "https://www.ozone.bg/about-us/";

        public string GeneraltermsPageUrl => "https://www.ozone.bg/terms/";
        public string PrivacyPolicyPageUrl => "https://www.ozone.bg/confidentiality/";

        public string WorkAtOzonePageUrl => "https://www.ozone.bg/blog/category/rabota/";
        public string BlogPageUrl => "https://www.ozone.bg/blog/";

 
        public string ContactsPageUrl => "https://www.ozone.bg/contacts/";

        public string FrequentlyAskedQuestionsPageUrl => "https://www.ozone.bg/help/";

        public string HowToShopPageUrl => "https://www.ozone.bg/help/article-12/";
        public string DeliveryPageUrl => "https://www.ozone.bg/help/article-19/";
        public string PaymentOfInstallmentsPageUrl => "https://www.ozone.bg/leasing/";

        public string QuestionsAndDisputeResolutionPageUrl => "https://ec.europa.eu/consumers/odr/main/index.cfm?event=main.home.chooseLanguage";


        public string SiteMapPageUrl => "https://www.ozone.bg/catalog/seo_sitemap/category/";
        public string OzoneBooksPageUrl => "https://www.ozone.bg/landing/ebook";


        //Fix after Christmas
        public string BabyBGPageUrl => "https://www.baby.bg/";
        public string OzoneROPageUrl => "https://www.ozone.ro/";
        public string OzoneHRPageUrl => "https://www.ozone.hr/";
        public string OzonGRPageUrl => "https://www.ozon.gr/";


        public string FacebookPageUrl => "https://www.facebook.com/Ozone.bg";
        public string InstagramPageUrl => "https://www.instagram.com/ozone.bg/";
        public string TiktokPageUrl => "https://www.tiktok.com/@ozone.bg";
        public string YoutubePageUrl => "https://www.youtube.com/@izigraiskukata";




    }
}
