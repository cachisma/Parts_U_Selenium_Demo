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

    public class LoginPage : Helper.Common 
    {
        PULObjects pULObjects = new PULObjects();
        public LoginPage(WebDriver driver) : base(driver) { }

        public void LoginProfile()
        {
            //Click on Login Main Button
            _driver.FindElement(By.XPath("/html/body/header/nav/div[1]/div/div[2]/div[2]/ul/li[4]/a")).Click();
            //Once on Login Page - Enter Username
            _driver.FindElement(pULObjects.UsernameObject).SendKeys("example@example.com");
            //Enter Password
            _driver.FindElement(pULObjects.PasswordObject).SendKeys("P@ssword1");
            //Click "Login-Button"
            _driver.FindElement(By.XPath("/html/body/div[1]/section/div/div[1]/div/form/div[4]/div/input")).Click();

        }   
    }
}
