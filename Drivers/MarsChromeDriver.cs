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
       
        public void LoginSteps()
        {
            // Open Web Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login Page Object Initialization and Definition
            MarsLoginPage MarsLoginPageObj = new MarsLoginPage();
            MarsLoginPageObj.MarsLoginActions(driver);
        }
    }
}
