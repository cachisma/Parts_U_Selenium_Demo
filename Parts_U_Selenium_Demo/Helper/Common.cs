using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts_U_Selenium_Demo.Helper
{
    public partial class Common
    {
        protected WebDriver _driver;

        public Common(WebDriver driver)
        {
            _driver = driver;
        }
    }
}
