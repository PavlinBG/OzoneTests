using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Pages
{
    public class CategoriesTab : BasePage
    {

        public CategoriesTab(IWebDriver driver) : base(driver)
        {

        }

        public override string PageUrl => "https://www.ozone.bg/homepage.php/";


























        //add tabs 

        public string GameingPageUrl => "https://www.ozone.bg/gaming/";

        public string BookStorePageUrl => "https://www.ozone.bg/knijarnica/";

        public string MusicAndMoviesPageUrl => "https://www.ozone.bg/filmi/";

        public string MerchandisePageUrl => "https://www.ozone.bg/drehi-merchandise/";
        public string LaptopsPCsMonitorsPageUrl => "https://www.ozone.bg/laptopi-monitori-i-kompyutri/";
        
        public string AudioAndHiFiSystemsPageUrl => "https://www.ozone.bg/audio-i-video/";

        public string SmartPhonesAndTabletsPageUrl => "https://www.ozone.bg/mobilni-ustroistva/";

        public string TVPhotoVideoPageUrl => "https://www.ozone.bg/tv-foto-i-video/";

        public string SmallElecticalAppliancesPageUrl => "https://www.ozone.bg/malki-elektrouredi/";

        public string ToysPageUrl => "https://www.ozone.bg/igrachki-i-pazeli/";


        public string ProducstsForBabyAndMotherPageUrl => "https://www.ozone.bg/mama-i-bebe/";

        public string GamesAndPuzzelesPageUrl => "https://www.ozone.bg/pazeli-2d-3d/";

        public string HealthAndBeautyPageUrl => "https://www.ozone.bg/zdrave-i-krasota/";

        public string SportAndOutdoorPageUrl => "https://www.ozone.bg/sport-i-autdor/";

        public string ForTheHomePageUrl => "https://www.ozone.bg/za-ofisa/";

        public string ForTheOfficePageUrl => "https://www.ozone.bg/za-ofisa/";


    }
}
