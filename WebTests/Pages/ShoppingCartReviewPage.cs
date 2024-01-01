using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTests.Objects;

namespace WebTests.Pages
{
    public class ShoppingCartReviewPage : BasePage
    {
        public ShoppingCartReviewPage(IWebDriver driver) : base(driver)
        {

        }


        public void FillShippingAddress(User user)
        {
            // Code to fill the shipping address with the provided user information
        }

        public void PlaceOrder()
        {
            // Code to place the order from the shopping cart review page
        }
    }
}
