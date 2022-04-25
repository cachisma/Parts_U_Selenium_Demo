using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Parts_U_Selenium_Demo
{
    public class PULObjects
    {
        public By UsernameObject = By.Name("Email");
        public By PasswordObject = By.Name("Password");
        public string MyUsername = "example@example.com";
        
        public By MatteFinishRim = By.XPath("/html/body/div[3]/div/section[2]/div/div[2]/div/a/div[1]/div[3]/div[1]/img");
        public By BugeyeHeadLights = By.XPath("/html/body/div[3]/div/section[2]/div/div[4]/div/a/div[1]/div[3]/div[1]/img");

        //BUTTONS
        public By LoginProfileButton = By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[4]/a");
        public By AddToCartButton = By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a");
        public By RemoveFromCartButton = By.Name("remove-link btn");
        public By CartButton = By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[3]/a");
        public By CheckoutButton = By.XPath("/html/body/div[1]/div/section/div[2]/div[4]/div/a");
        public By SubmitOrderButton = By.XPath("/html/body/div[1]/section/form/div/div[2]/div[4]/input");

        //FORM INPUTS
        public By ShippingName = By.Id("Name");
        public By ShippingPhoneNumber = By.Id("Phone");
        public By ShippingAddress = By.Id("Address");
        public By ShippingCity = By.Name("City");
        public By ShippingState = By.Name("State");
        public By ShippingZipCode = By.Name("PostalCode");
        public By ShippingCountry = By.Name("Country");


    }
}
