using Mars.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Mars.Pages
{
    public class MarsLoginPage : MarsChromeDriver
    {
        public void MarsLoginActions(IWebDriver driver)
        {

            //Launch Turnup Portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Click on Sign In
            IWebElement marsSignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            marsSignInButton.Click();

            //Identify Username Text Box
            IWebElement marsUserNameTextBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/div[1]/input"));

            //Enter Username
            marsUserNameTextBox.SendKeys("ankursinghal9118@gmail.com");

            //Identify Password Text Box
            IWebElement marsPasswordTextBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/div[2]/input"));

            //Enter Password
            marsPasswordTextBox.SendKeys("Singhal&18");

            //Identify Remember Me Radio Button
            IWebElement marsRememberMeRadioButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/div[3]/div/input"));

            //Remember Me Must be Ticked
            marsRememberMeRadioButton.Click();
            Thread.Sleep(1000);

            //Locate Login Button
            IWebElement marsLoginButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/div[4]/button"));


            //Click on Login Button
            marsLoginButton.Click();

        }
    }
}
