using System;
using OpenQA.Selenium;

namespace pageObjects
{
    public class commonObjects
    {
        // constructor for webdriver in page objects
        protected static IWebDriver driver;
  
        public commonObjects(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
