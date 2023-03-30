using Mars.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Mars.Pages
{
    public class MarsLoginPage
    {
        
        public void MarsNavigateToPortal(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            IWebElement marsSignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            marsSignInButton.Click();
            IWebElement marsUserNameTextBox = driver.FindElement(By.Name("email"));
            marsUserNameTextBox.Click();
            marsUserNameTextBox.SendKeys("ankursinghal9118@gmail.com");
            IWebElement marsPasswordTextBox = driver.FindElement(By.Name("password"));
            marsPasswordTextBox.SendKeys("Singhal&18");
            IWebElement marsRememberMeRadioButton = driver.FindElement(By.Name("rememberDetails"));
            marsRememberMeRadioButton.Click();
            Thread.Sleep(1000);
            IWebElement marsLoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]"));
            marsLoginButton.Click();
            

        }


    }
}
