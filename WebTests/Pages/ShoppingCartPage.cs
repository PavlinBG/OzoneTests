using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTests.Enums;

namespace WebTests.Pages
{
    public  class ShoppingCartPage : BasePage
    {
 
        public ShoppingCartPage(IWebDriver driver) : base(driver)
        { 

        }

         

        public void NavigateToCart()
        {
            // Code to navigate to the shopping cart page
        }

        public void RemoveProduct(Products product)
        {
            // Code to remove the specified product from the cart
        }

        public void UpdateProductQuantity(Products product, int quantity)
        {
            // Code to update the quantity of the specified product in the cart
        }

        public void ProceedToCheckout()
        {
            // Code to proceed to the checkout process from the shopping cart page
        }

    }
}
