using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalUIAutomation.Pages;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Test
{
    [TestFixture]
    public class Tm_Test_Nunit : CommonDriver
    {
        [SetUp]
        public void Timesetup()
        {
            //open chrome browser

           driver = new ChromeDriver(); /*telling sellenium that variable driver is the a chrome driver and through this driver  
                                         * we can access packages of selenium chrome */

            /* //check if user logged in successfully
             IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));*/

            // Login object initialization and definition
            LoginPage loginObj = new LoginPage();
            loginObj.LoginAction(driver);

            //Home page object intialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test, Order(1), Description("creating new record")]
        public void CreateTime_test()
        {
            //TimeAndMAterial object intialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.Create_TimeRecord(driver);
        }
        [Test, Order(2), Description("Editing new record")]
        public void EditTime_test()
        {
            //edit new code
            TMPage tmPageObject = new TMPage();
            tmPageObject.Edit_TimeRecord(driver);
        }
        [Test, Order(3), Description("Deleting the record")]
        public void DeleteTime_test()
        {
       TMPage tmPageObject = new TMPage();
             //delete new code
              tmPageObject.Delete_TimeRecord(driver); 
        }
        [TearDown]
        public void CloseTimeRun()
        {
            driver.Quit();
        }
    }
}
