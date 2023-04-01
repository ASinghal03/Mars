
using Mars.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    
    public class MarsProfilePage
    {
        public IWebDriver driver;
        public void MarsGoToSkillsTab(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-tab='second']")));
            IWebElement marsSkillsButton = driver.FindElement(By.CssSelector("a[data-tab='second']"));
            marsSkillsButton.Click();

        }
        
        public void MarsAddNewSkill(IWebDriver driver)
        {
            
            
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Resilient");
            SelectElement oSelect = new SelectElement(driver.FindElement(By.CssSelector("select[name='level']")));
            oSelect.SelectByValue("Intermediate");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
            Thread.Sleep(1000);
            //IWebElement textBox = driver.FindElement(By.Name("ns-box ns-growl ns-effect-jelly ns-type-error ns-show"));
            //string marsnotwin=textBox.Text;
            //Console.Write(marsnotwin);
            //Console.WriteLine("Skill Added");
        
        }
        
        public void MarsEditSkill(IWebDriver driver,string skill,string level)
            {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")).Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys(skill);
            SelectElement oSelect = new SelectElement(driver.FindElement(By.CssSelector("select[name='level']")));
            oSelect.SelectByValue(level);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

        }
        
        public void MarsDeleteSkill(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();

        }
        public string MarsAddedSkillText(IWebDriver driver)
        {
            IWebElement actualSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualSkill.Text;
        }
        public string MarsAddedSkillLevelText(IWebDriver driver)
        {
            IWebElement actualSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualSkillLevel.Text;
        }
        public string MarsEditedSkillText(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IWebElement editedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }
        public string MarsEditedSkillLevelText(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedSkillLevel.Text;
        }
        public string MarsDeletedSkillText(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IWebElement editedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }
    }
}
