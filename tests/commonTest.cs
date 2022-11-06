using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tests
{
    public class commonTest
    {
        // protected to get access only from children classes
        protected IWebDriver driver;

        protected string baseUrl = "https://www.saucedemo.com/";

        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
