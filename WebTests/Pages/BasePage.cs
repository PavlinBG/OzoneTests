﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver) 
        {  
            
            this.driver = driver; 
        }

        //Header
        public IWebElement HomeLink => driver.FindElement(By.CssSelector("body > header > div.wide-area.header-logo-cart > div > div.logo-wrapper > a"));

        public IWebElement Categories => driver.FindElement(By.LinkText("Категории"));

        public IWebElement LastAdded => driver.FindElement(By.LinkText("Последно добавени"));

        public IWebElement Unpacked => driver.FindElement(By.LinkText("Разопаковани"));

        public IWebElement OutLet => driver.FindElement(By.LinkText("Outlet"));

        public IWebElement Discount => driver.FindElement(By.LinkText("Промоции"));

        public IWebElement OurStore => driver.FindElement(By.LinkText("Нашите магазини"));






        //Footer



        //Social Links 

        public IWebElement Facebook => driver.FindElement(By.CssSelector("body > footer > div.footer-line-1 > div:nth-child(1) > div > div:nth-child(1) > div > a:nth-child(2) > i"));
        public IWebElement Instagram => driver.FindElement(By.CssSelector("body > footer > div.footer-line-1 > div:nth-child(1) > div > div:nth-child(1) > div > a:nth-child(3) > i"));
        public IWebElement Tiktok => driver.FindElement(By.CssSelector("body > footer > div.footer-line-1 > div:nth-child(1) > div > div:nth-child(1) > div > a:nth-child(4) > i"));
        public IWebElement Youtube => driver.FindElement(By.CssSelector("body > footer > div.footer-line-1 > div:nth-child(1) > div > div:nth-child(1) > div > a:nth-child(5) > i"));




        public IWebElement AboutUs => driver.FindElement(By.LinkText("За нас"));

        public IWebElement Generalterms => driver.FindElement(By.LinkText("Общи условия"));
        public IWebElement PrivacyPolicy => driver.FindElement(By.LinkText("Политика за поверителност"));

        public IWebElement WorkAtOzone => driver.FindElement(By.LinkText("Работа в Ozone.bg"));
        public IWebElement BlogPage => driver.FindElement(By.LinkText("Блог"));


        public IWebElement Contacts => driver.FindElement(By.LinkText("Контакти"));

        public IWebElement FrequentlyAskedQuestions => driver.FindElement(By.LinkText("Често задавани въпроси"));

        public IWebElement HowToShop=> driver.FindElement(By.LinkText("Как да пазарувам"));
        public IWebElement Delivery => driver.FindElement(By.LinkText("Доставка"));
        public IWebElement PaymentOfInstallments => driver.FindElement(By.LinkText("Плащане на вноски"));

        public IWebElement QuestionsAndDisputeResolution => driver.FindElement(By.LinkText("Въпроси и разрешаване на спорове"));


        public IWebElement SiteMap => driver.FindElement(By.LinkText("Карта на сайта"));
        public IWebElement OzoneBooks => driver.FindElement(By.LinkText("ozone е-книги"));


        public IWebElement BabyBG => driver.FindElement(By.LinkText("baby.bg"));
        public IWebElement OzoneRO => driver.FindElement(By.LinkText("ozone.ro"));
        public IWebElement OzoneHR=> driver.FindElement(By.LinkText("ozone.hr"));
        public IWebElement OzonGR => driver.FindElement(By.LinkText("ozon.gr"));




        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool isOpen()
        {
            return driver.Url == this.PageUrl;
        }

        public String GetPageUrl()
        {
            return driver.Title;
        }

    }
}
