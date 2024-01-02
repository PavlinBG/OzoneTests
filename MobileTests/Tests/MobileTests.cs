using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileTests.Tests.Tests
{
    public class MobileTests
    {
        private readonly AndroidDriver<AndroidElement> driver;


        public MobileTests(AndroidDriver<AndroidElement> driver<)
        {
            this.driver = driver;
        }
    }
}
