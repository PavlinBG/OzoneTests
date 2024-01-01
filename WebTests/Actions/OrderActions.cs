using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTests.Pages;
using WebTests.Enums;


namespace WebTests.Actions
{
    public class OrderActions
    {
        private readonly IWebDriver driver;

        private HomePage homePage;
        private ProductPage productPage;
        private ShoppingCartPage cartPage;
        private ShoppingCartReviewPage reviewPage;


        public OrderActions(IWebDriver driver)
        {
            this.driver = driver;
            homePage = new HomePage(driver);


        }

        public void AddProductToCart(Products product)
        {


            var home_page = new HomePage(driver);
            home_page.Open();
            homePage.SearchProduct(product.ToString());
            productPage.SelectProduct(product);
            productPage.AddToCart();
        }

        public void RemoveProductFromCart(Products product)
        {
            cartPage.NavigateToCart();
            cartPage.RemoveProduct(product);
        }

        public void UpdateProductQuantity(Products product, int quantity)
        {
            cartPage.NavigateToCart();
            cartPage.UpdateProductQuantity(product, quantity);
        }

        public void ProceedToCheckout()
        {
            cartPage.NavigateToCart();
            cartPage.ProceedToCheckout();
        }

        public void PlaceOrder(Objects.User user)
        {
            reviewPage.FillShippingAddress(user);
            reviewPage.PlaceOrder();
        }

        internal bool VerifyOrderConfirmation()
        {
            throw new NotImplementedException();
        }
    }
}