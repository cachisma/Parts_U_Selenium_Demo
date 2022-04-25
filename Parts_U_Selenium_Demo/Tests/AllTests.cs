using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Parts_U_Selenium_Demo;
using OpenQA.Selenium.Remote;

namespace Parts_U_Selenium_Demo
{
    [TestClass]
    public class AllTests
    {
        private WebDriver _driver;
        private string Base_Url = "https://pule2e236b5818.azurewebsites.net";

        [TestMethod]
        public void Login()
        {
            Helper.Helper.InitializeChromeDriver(out _driver, Base_Url);
            PULObjects pULObjects = new PULObjects();
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.LoginProfile();

        }

        [TestMethod]
        public void AddItemToCartandCheckout()
        {
            Helper.Helper.InitializeChromeDriver(out _driver, Base_Url);
            LoginPage login = new LoginPage(_driver);
            PULObjects pULObjects = new PULObjects();
            CheckoutPage checkout = new CheckoutPage(_driver);

            login.LoginProfile();
            _driver.FindElement(pULObjects.MatteFinishRim).Click();
            _driver.FindElement(pULObjects.AddToCartButton).Click();
            checkout.CheckOut();
        }

        [TestMethod]
        public void SearchForItem()
        {
            Helper.Helper.InitializeChromeDriver(out _driver, Base_Url);
            PULObjects pULObjects = new PULObjects();

            _driver.FindElement(By.Id("search-box")).SendKeys("Headlight");
            _driver.FindElement(By.Id("search-link")).Click();
            _driver.FindElement(pULObjects.BugeyeHeadLights).Click();
            _driver.FindElement(pULObjects.AddToCartButton).Click();
        }



        [TestCleanup]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
