using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace pageObjects
{
    public class inventoryPage:commonObjects
    {
        public inventoryPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement backpackId => driver.FindElement(By.Id("item_4_title_link"));

        public void clickOnBackback()
        {
            this.backpackId.Click();
        }
    }
}
