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
        public IWebElement backpackTitle => driver.FindElement(By.CssSelector("[class=\"inventory_details_name large_size\"]"));

        public void clickOnBackpack()
        {
            this.backpackId.Click();
        }

        public string getBackpackTitleText()
        {
            return backpackTitle.Text;
        }
    }
}
