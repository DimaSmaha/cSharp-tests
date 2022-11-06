using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using pageObjects;

namespace tests
{
    public class loginTest:commonTest
    {
        [Test]
        public void LoginTest()
        {
            homePage home = new homePage(driver);
            home.fillLoginInput("standard_user");
            home.fillPassInput("secret_sauce");
            home.clickLoginBtn();
            //home.fillElement((OpenQA.Selenium.By)home.loginInput, "standard_user");
            //home.fillElement((OpenQA.Selenium.By)home.passwordInput, "secret_sauce");
            //home.clickElement((OpenQA.Selenium.By)home.loginBtn);
            string url = home.stringUrl();
            Assert.AreEqual(url, "https://www.saucedemo.com/inventory.html");
        }

    }
}
