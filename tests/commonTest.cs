using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tests
{
    public class commonTest
    {
        protected IWebDriver driver;
        // protected to get access only from children classes

        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
