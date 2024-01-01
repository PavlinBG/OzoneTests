using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTests.Enums;

namespace WebTests.Pages
{
    public class ProductPage : BasePage
    {
        public ProductPage(IWebDriver driver) : base(driver)
        {



        }

        public void SelectProduct(Products product)
        {
            // Code to select the specified product on the product page
        }

        public void AddToCart()
        {
            // Code to add the selected product to the cart
        }
    }
}

