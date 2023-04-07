using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mars.Drivers;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class MarsShareSkillsPage
    {
        public void MarsShareSkillsForm(IWebDriver driver)
        {
            //Title
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
            driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")).SendKeys("Software Testing");

            //Description
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea");
            driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("Fresher providing efficient Testing Services for Web Applications");

            //Category 1
            //Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select");
            driver.FindElement(By.Name("categoryId"));
            SelectElement category1Select = new SelectElement(driver.FindElement(By.Name("categoryId")));
            category1Select.SelectByValue("6");

            //Category 2
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select");
            driver.FindElement(By.Name("subcategoryId")).SendKeys(Keys.Space);
            SelectElement category2Select = new SelectElement(driver.FindElement(By.Name("subcategoryId")));
            category2Select.SelectByValue("4");

            //Tags
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
            IWebElement marsTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            marsTag.SendKeys("Professional" + "\n");
            //SelectElement earnSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select")));
            //earnSelect.SelectByValue("Programming & Tech");


            //Service Type Radio Button
            //Wait.WaitToBeClickable(driver, "CssSelector", 5, "#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(2) > div > input[type=radio]");
            IWebElement serviceTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(2) > div > input[type=radio]"));
            serviceTypeRB.Click();



            //Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            IWebElement locationTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(6) > div.twelve.wide.column > div > div:nth-child(1) > div > input[type=radio]"));
            locationTypeRB.Click();

            // Wait.WaitToBeClickable(driver, "CssSelector", 5, "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div.two.wide.field > div > input[type=checkbox]");
            IWebElement daysTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div.two.wide.field > div > input[type=checkbox]"));
            daysTypeRB.Click();

            //// Wait.WaitToBeClickable(driver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            //IWebElement sTradeTypeRB = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(2) > div > div:nth-child(2) > div > input[type=radio]"));
            //sTradeTypeRB.Click();

            Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");
            Thread.Sleep(3000);
            IWebElement sExchTypeRB = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            sExchTypeRB.SendKeys("Professional" + "\n");
            sExchTypeRB.SendKeys("Time Management" + "\n");
            sExchTypeRB.SendKeys("Communication" + "\n");
            sExchTypeRB.SendKeys("Team Player" + "\n");

             Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            IWebElement saveB = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            saveB.Click();
        }

        public string MarsSkillListingCheck(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]");
            IWebElement skillTitle = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            return skillTitle.Text;
        }
        public void MarsSkillListingSearch(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            Wait.WaitToBeClickable(driver, "CssSelector", 5, "#home > div > div > div.main-search > div > input[type=text]");
            driver.FindElement(By.CssSelector("#home > div > div > div.main-search > div > input[type=text]")).SendKeys("Testingq");
            Wait.WaitToBeClickable(driver, "CssSelector", 5, "#home > div > div > div.main-search > div > button");
            driver.FindElement(By.CssSelector("#home > div > div > div.main-search > div > button")).Click();
        }
        public string MarsSkillListingRead(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "CssSelector", 5, "#service-search-section > div.ui.container > div > section > div > div.twelve.wide.column > div > div:nth-child(2) > div > div > div > div:nth-child(2) > a.service-info > p");
            IWebElement skillRead = driver.FindElement(By.CssSelector("#service-search-section > div.ui.container > div > section > div > div.twelve.wide.column > div > div:nth-child(2) > div > div > div > div:nth-child(2) > a.service-info > p"));
            return skillRead.Text;
        }


    }
}
