using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts_U_Selenium_Demo
{
    public class CheckoutPage : Helper.Common
    {
 
        PULObjects pULObjects = new PULObjects();
        
        public CheckoutPage(WebDriver driver) : base(driver) { }

        public void CheckOut()
        {
            //Click on Checkout button
            _driver.FindElement(By.XPath("/html/body/div[1]/div/section/div[2]/div[4]/div/div/a")).Click();
            //Add Shipping Information
            _driver.FindElement(pULObjects.ShippingName).SendKeys("Cayce");
            _driver.FindElement(pULObjects.ShippingPhoneNumber).SendKeys("123-456-7890");
            _driver.FindElement(pULObjects.ShippingAddress).SendKeys("123 Somewhere Rd");
            _driver.FindElement(pULObjects.ShippingCity).SendKeys("Tampa");
            _driver.FindElement(pULObjects.ShippingState).SendKeys("Florida");
            _driver.FindElement(pULObjects.ShippingZipCode).SendKeys("12345");
            _driver.FindElement(pULObjects.ShippingCountry).SendKeys("USA");

            //Submit Order Button
            _driver.FindElement(pULObjects.SubmitOrderButton).Click();
        }

    }
}
