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
        MarsLoginPage marsLoginPageObj = new MarsLoginPage();
        MarsProfilePage marsProfilePageObj = new MarsProfilePage();

        [Given(@"I Logged Into Mars Portal Successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully() => marsLoginPageObj.MarsNavigateToPortal(driver);
        [When(@"Add New Skill")]
        public void WhenAddNewSkill()
        {
            marsProfilePageObj.MarsAddNewSkill(driver);
        }

        [Then(@"New Should Added Successfully")]
        public void ThenNewShouldAddedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
