using Mars.Drivers;
using Mars.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class MarsFeature1StepDefinitions : MarsChromeDriver
    {
        MarsLoginPage marsLoginPageObj = new MarsLoginPage();
        MarsChromeDriver marsChromeDriver = new MarsChromeDriver();
        [Given(@"I navigate to Mars Portal Successfully")]
        public void GivenINavigateToMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            MarsLoginPage marsLoginPageObj = new MarsLoginPage();
            marsLoginPageObj.MarsNavigateToPortal(driver);

        }

        [When(@"Click on Sign In")]
        public void WhenClickOnSignIn()
        {
            marsLoginPageObj.MarsSignInClick(driver);
        }

        [When(@"Feed Credentials")]
        public void WhenFeedCredentials()
        {
            marsLoginPageObj.MarsSignInCredentials(driver);
        }

        [Then(@"Should be on Home page")]
        public void ThenShouldBeOnHomePage()
        {
            throw new PendingStepException();
        }

        
    }
}
