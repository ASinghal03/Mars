using Mars.Drivers;
using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    
    [Binding]
   
    public class MarsFeature1StepDefinitions: MarsChromeDriver
    {
        IWebDriver driver = new ChromeDriver();
        MarsLoginPage marsLoginPageObj = new MarsLoginPage();
        MarsProfilePage marsProfilePageObj = new MarsProfilePage();


        [Given(@"I Logged Into Mars Portal Successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully() => marsLoginPageObj.MarsNavigateToPortal(driver);
        [When(@"I Navigate to Skills Tab")]
        public void WhenINavigateToSkillsTab()
        {
            marsProfilePageObj.MarsGoToSkillsTab(driver);
        }
        [When(@"Add New Skill")]
        public void WhenAddNewSkill()
        {
            
            marsProfilePageObj.MarsAddNewSkill(driver);
        }
        [Then(@"New Skill Should Be Added")]
        public void ThenNewSkillShouldBeAdded()
        {
            string marsAddedSkill = marsProfilePageObj.MarsAddedSkillText(driver);
            string marsAddedSkillLevel = marsProfilePageObj.MarsAddedSkillLevelText(driver);
            Assert.That(marsAddedSkill == "Resilient", "Actual skill and expected skill do not match.");
            Assert.That(marsAddedSkillLevel == "Intermediate", " Actual level and level description do not match.");

        }
        [When(@"I Update '([^']*)','([^']*)' to an existing skill record")]
        public void WhenIUpdateToAnExistingSkillRecord(string skill,string level)
        {
            marsProfilePageObj.MarsEditSkill(driver,skill,level);
        }

        [Then(@"'([^']*)','([^']*)' is modified successfully")]
        public void ThenIsModifiedSuccessfully(string skill, string level)
        {
            string marsEditedSkill = marsProfilePageObj.MarsEditedSkillText(driver);
            string marsEditedSkillLevel = marsProfilePageObj.MarsEditedSkillLevelText(driver);
            Assert.That(marsEditedSkill == skill, "Actual skill and expected skill do not match.");
            Assert.That(marsEditedSkillLevel == level, " Actual level and expected level do not match.");
        }
        [When(@"I Click Delete button")]
        public void WhenIClickDeleteButton()
        {
            marsProfilePageObj.MarsDeleteSkill(driver);
        }

        [Then(@"Record is deleted")]
        public void ThenRecordIsDeleted()
        {
            string marsEditedSkill = marsProfilePageObj.MarsEditedSkillText(driver);
            string marsLastSkillRecord = marsProfilePageObj.MarsDeletedSkillText(driver);
            Assert.That(marsLastSkillRecord == marsEditedSkill, "Skill deletion unsuccessful.");
        }

    }
}
