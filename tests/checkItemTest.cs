using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using pageObjects;

namespace tests
{
    public class checkItemTest:commonTest
    {
        [Test]
        public void CheckItemTest()
        {
            homePage home = new homePage(driver);
            home.fillLoginInput("standard_user");
            home.fillPassInput("secret_sauce");
            home.clickLoginBtn();
            string url = home.stringUrl();
            Assert.AreEqual(url, "https://www.saucedemo.com/inventory.html");

            inventoryPage inventory = new inventoryPage(driver);
            inventory.clickOnBackpack();
            string url1 = inventory.stringUrl();
            Assert.AreEqual(url1, "https://www.saucedemo.com/inventory-item.html?id=4");
            Assert.AreEqual(inventory.getBackpackTitleText(), "Sauce Labs Backpack");
        }
    }
}
