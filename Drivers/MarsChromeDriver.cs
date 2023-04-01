using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Mars.Pages;
using TechTalk.SpecFlow;

namespace Mars.Drivers
{
    public class MarsChromeDriver
    {
         public IWebDriver driver;
        
       
        public void MarsLoginSteps()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            MarsLoginPage marsLoginPageObj= new MarsLoginPage();
            marsLoginPageObj.MarsNavigateToPortal(driver);
           
        }
        
        //public void MarsSkillPageSteps()
        //{
         //   MarsProfilePage marsProfilePageObj = new MarsProfilePage();
         //   marsProfilePageObj.MarsAddNewSkill(driver);
       // }


    }
}
