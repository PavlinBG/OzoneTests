using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://www.ozone.bg/homepage.php/";


        //Nav bar
 
        public string CategoriesPageUrl => "https://www.ozone.bg/categories.php";
        public string LastAddedPageUrl => "https://www.ozone.bg/posledno-dobaveni/";


        public string UnpackedPageUrl => "https://www.ozone.bg/razopakovani/";

        public string OutletPageUrl => "https://www.ozone.bg/outlet/";

        public string DiscontPageUrl => "https://www.ozone.bg/promotions/?%D0%BF%D1%80%D0%BE%D0%BC%D0%BE%D1%86%D0%B8%D0%B8";

        public string OurStorePageUrl => "https://www.ozone.bg/our-shops/";


        

  
    }
}
