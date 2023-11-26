using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Data.SqlTypes;
using TechTalk.SpecFlow;
using TurnUpPortalUIAutomation.Pages;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver(); 
            LoginPage loginObj = new LoginPage();
            loginObj.LoginAction(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time record")]
        public void WhenICreateANewTimeRecord()
        {
            TMPage tmPageObject = new TMPage();

            tmPageObject.Create_TimeRecord(driver);
        }

        [Then(@"the recrd should be created successfully")]
        public void ThenTheRecrdShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObject = new TMPage();

            string newCode = tmPageObject.getCode(driver);

            Assert.That(newCode == "SG2", "New code and expected code do not match");
        }
    }
}
