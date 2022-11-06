using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace pageObjects
{
    public class homePage:commonObjects
    {
        public homePage(IWebDriver driver):base(driver)
        {

        }

        public IWebElement loginInput => driver.FindElement(By.Id("user-name"));
        public IWebElement passwordInput => driver.FindElement(By.Id("password"));
        public IWebElement loginBtn => driver.FindElement(By.Id("login-button"));

        public void fillLoginInput(String keys)
        {
            this.loginInput.SendKeys(keys);
        }
        public void fillPassInput(String keys)
        {
            this.passwordInput.SendKeys(keys);
        }
        public void clickLoginBtn()
        {
            this.loginBtn.Click();
        }
        public void clickElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public void fillElement(By element, String keys)
        {
            driver.FindElement(element).SendKeys(keys);
        }

    }
}
