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
            IWebElement productElement = driver.FindElement(By.XPath($"//div[@class='product' and contains(text(), '{product.ToString()}')]"));

            productElement.Click();

        }

        public void AddToCart()
        {
            IWebElement addToCartButton = driver.FindElement(By.XPath("//button[contains(text(), 'Add to Cart')]"));

            addToCartButton.Click();

        }
    }
}

