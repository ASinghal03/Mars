using Mars.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Mars.Pages
{
    public class MarsLoginPage : MarsChromeDriver
    {
        public void MarsNavigateToPortal(IWebDriver driver)
        {

            //Launch Turnup Portal
           driver.Navigate().GoToUrl("http://localhost:5000/Home");
        
        }
        public void MarsSignInClick(IWebDriver driver)
        {
            //Click on Sign In
            IWebElement marsSignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            marsSignInButton.Click();
        }
        public void MarsSignInCredentials(IWebDriver driver)
        { 
            //Identify Username Text Box
            IWebElement marsUserNameTextBox = driver.FindElement(By.Name("email"));
            marsUserNameTextBox.Click();
            //Enter Username
            marsUserNameTextBox.SendKeys("ankursinghal9118@gmail.com");

            //Identify Password Text Box
            IWebElement marsPasswordTextBox = driver.FindElement(By.Name("password"));

            //Enter Password
            marsPasswordTextBox.SendKeys("Singhal&18");

            //Identify Remember Me Radio Button
            IWebElement marsRememberMeRadioButton = driver.FindElement(By.Name("rememberDetails"));

            //Remember Me Must be Ticked
            marsRememberMeRadioButton.Click();
            Thread.Sleep(1000);

            //Locate Login Button
            IWebElement marsLoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]"));


            //Click on Login Button
            marsLoginButton.Click();

        }
        public void MarsAddNewSkill(IWebDriver driver) 
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }
        
    }
}
