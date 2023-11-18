using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Pages
{
    public class Login
    {
        public void LoginAction(IWebDriver driver)
        {
            /* Implicit wait : ifimplicit wait is for 5 seconds, then it will wait for 5 seconf for each element to load, 
             * if within 5 seconds that elment is found its good, if an element is taking more than 5 sec to load then it
             * will through erreo that this element can not be found,implici twait is given as
             * driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);*/
            driver.Manage().Window
                .Maximize();
            //Launce TurnUp portal and Navigate to the website login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");  // through driver we are accessing navigate and gotourl methods
            Thread.Sleep(4000);
            //usind wait utility
            Wait.WaitToExit(driver, "Id", "UserName", 8);
            //Identify the username textbox(elements,throughInspect and html port ) and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            // Preffered identifier is Id, xpath generate unique identifier for the element,,there are 2 types of xpath 1. Relative xpath 2.absolute/full xpath
            //Identify the password textbox(elements,throughInspect and html port ) and enter valid password
            /*explicit wait : it is given for individual element to wait till the perticular element exist
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            wait.Until(ExpectedCondition.ElementExists(By.Id("UserName")));
            Here I have doubt, if selenium will wait till expected element to exist then what is the use of FromSecons(5)
            Also why erroe is showing for ExpectedCondition */
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            // Identify login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//section[@id='loginForm']/form[@role='form']//input[@value='Log in']"));
            loginButton.Click();

        }
    }
}
