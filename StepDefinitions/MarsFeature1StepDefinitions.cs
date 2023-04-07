using Docker.DotNet.Models;
using Mars.Drivers;
using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using System.Reflection.Emit;
using FluentAssertions;

namespace Mars.StepDefinitions
{

    [Binding]

    public class MarsFeature1StepDefinitions : MarsChromeDriver
    {
        IWebDriver driver = new ChromeDriver();
        //Driver.Manage().Window.Maximize();
        MarsLoginPage marsLoginPageObj = new MarsLoginPage();
        MarsProfilePage marsProfilePageObj = new MarsProfilePage();
        MarsShareSkillsPage marsShareSkillPageObj = new MarsShareSkillsPage();


        [Given(@"I Logged Into Mars Portal Successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully() => marsLoginPageObj.MarsNavigateToPortal(driver);
        [When(@"Add all details to profile page")]
        public void WhenAddDetailsToProfilePage()
        {
            marsProfilePageObj.MarsAddProfileDetails(driver);
            marsProfilePageObj.MarsAddNewLanguage(driver);          
            marsProfilePageObj.MarsAddNewEducation(driver);
            marsProfilePageObj.MarsAddNewCertificate(driver);
            marsProfilePageObj.MarsAddNewSkill(driver);
        }

        [Then(@"Profile is updated successfully")]
        public void ThenProfileIsUpdatedSuccessfully()
        {   
            string marsAddedSkill = marsProfilePageObj.MarsAddedSkillText(driver);
            string marsAddedSkillLevel = marsProfilePageObj.MarsAddedSkillLevelText(driver);
            //SimpleAssertThat.Assert.That(marsAddedSkill, EqualTo("Resilient"));
            Assert.That(marsAddedSkill == "Resilient", "Actual skill and expected skill do not match.");
            Assert.That(marsAddedSkillLevel == "Intermediate", "Actual level and level description do not match.");

        }

        [When(@"Edit Following Records:Language, Skill, Education, Certificate")]
        public void WhenEditSkillSkillLevelInSkillsTab()
        {
            marsProfilePageObj.MarsEditLanguage(driver);
            marsProfilePageObj.MarsEditEducation(driver);
            marsProfilePageObj.MarsEditCertificate(driver);
            marsProfilePageObj.MarsEditSkill(driver);
        }

        [Then(@"Following records are updated successfully:Language, Skill, Education, Certificate")]
        public void ThenSkillSkillLevelIsUpdatedSuccessfully()
        {
            string marsEditSkill = marsProfilePageObj.MarsEditSkillText(driver);
            //string marsEditSkillLevel = marsProfilePageObj.MarsEditSkillLevelText(driver);
            ////SimpleAssertThat.Assert.That(marsAddedSkill, EqualTo("Resilient"));
            Assert.That(marsEditSkill == "Time Management", "Actual skill and expected skill do not match.");
            //Assert.That(marsEditSkillLevel == "Expert", "Actual level and level description do not match.");
        }

        [When(@"Delete following records:Language, Skill, Education, Certificate")]
        public void WhenDeleteFollowingRecordsLanguageSkillEducationCertificate()
        {
            //marsLoginPageObj.MarsNavigateToPortal(driver);
            marsProfilePageObj.MarsDeleteLanguage(driver);
            marsProfilePageObj.MarsDeleteSkills(driver);
            marsProfilePageObj.MarsDeleteEducation(driver);
            marsProfilePageObj.MarsDeleteCertificate(driver);
        }

        [Then(@"Following records are deleted successfully:Language, Skill, Education, Certificate")]
        public void ThenFollowingRecordsAreDeletedSuccessfullyLanguageSkillEducationCertificate()
        {
            string marsDeleteSkill = marsProfilePageObj.MarsDeleteSkillText(driver);
            Assert.That(marsDeleteSkill != "Time Management", "Actual skill and expected skill do not match.");
        }



        [When(@"I Click on Share Skill")]
        public void WhenIClickOnShareSkill()
        {
            marsProfilePageObj.GoToShareSkillsPage(driver);
        }


        [When(@"I Update all necessary fields")]
        public void WhenIUpdateAllNecessaryFields()
        {
            marsShareSkillPageObj.MarsShareSkillsForm(driver);
        }

        [Then(@"A skill listing is created successfully")]
        public void ThenASkillListingIsCreatedSuccessfully()
        {
            string skillCheck = marsShareSkillPageObj.MarsSkillListingCheck(driver);
            Assert.That(skillCheck == "Software Testing", "Error");
        }

        [When(@"Enter Skill to be searched and Click on Search")]
        public void WhenEnterSkillToBeSearchedAndClickOnSearch()
        {
            marsShareSkillPageObj.MarsSkillListingSearch(driver);
        }

        [Then(@"Results should be filtered based on search")]
        public void ThenResultsShouldBeFilteredBasedOnSearch()
        {
            string skillRead = marsShareSkillPageObj.MarsSkillListingRead(driver);
            //SimpleAssertThat.Assert.That(marsAddedSkill, EqualTo("Resilient"));
            Assert.That(skillRead == "Testingq", "Actual skill and expected skill do not match.");
        }



        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
