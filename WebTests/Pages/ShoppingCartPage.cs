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
           // IWebElement navigateToCart = driver.FindElement(By.XPath($"//div[@class='product' and contains(text(), '{product.ToString()}')]"));
           // navigateToCart.Click();

            // Get the product ID
            IWebElement productIdElement = driver.FindElement(By.XPath("//div[@class='product-id']"));
            string productId = productIdElement.Text;
            Console.WriteLine("Product ID: " + productId);
        }

        public void RemoveProduct(Products product)
        {
            IWebElement removeProduct = driver.FindElement(By.CssSelector("#delete_item"));

           removeProduct.Click();
        }

        public void UpdateProductQuantity(Products product, int quantity)
        {
            IWebElement updateProductQuantity = driver.FindElement(By.XPath("#shopping-cart-table > div.cart-row.item > div.cell.col3 > div > span.ui-spinner.ui-corner-all.ui-widget.ui-widget-content > a.ui-spinner-button.ui-spinner-up.ui-corner-tr"));

            updateProductQuantity.Click();

            //Note to Updateing the Quantity of the products reloads the page
            //Add Implicit Wait 
            Thread.Sleep(2000);


        }

        public void ProceedToCheckout()
        {

            //Note to Proceed to Cheackout you need to be log in 

            IWebElement proceedToCheckout = driver.FindElement(By.LinkText("Към завършване"));

            proceedToCheckout.Click();
         }

    }
}
