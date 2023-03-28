using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Mars.Pages;

namespace Mars.Drivers
{
    public class MarsChromeDriver
    {
        public IWebDriver driver;
       
        public void MarsLoginSteps()
        {
            // Open Web Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            MarsLoginPage marsLoginPageObj = new MarsLoginPage();
            marsLoginPageObj.MarsNavigateToPortal(driver);
        }
    }
}
