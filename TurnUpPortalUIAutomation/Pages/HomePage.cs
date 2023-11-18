using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalUIAutomation.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //1. navigate to time and materials module through adminastration drop down
            IWebElement adminastrationOption = driver.FindElement(By.XPath("/html//div[@class='container']//ul[@class='nav navbar-nav']//a[@role='button']"));
            adminastrationOption.Click();
            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html//div[@class='container']//ul[@class='nav navbar-nav']//ul[@role='menu']//a[@href='/TimeMaterial']"));
            timeAndMaterial.Click();
        }
    }
}
