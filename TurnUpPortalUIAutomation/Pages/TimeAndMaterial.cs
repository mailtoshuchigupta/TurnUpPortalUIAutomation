using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Pages
{
    public class TimeAndMaterial
    {

        public void create_TimeRecord(IWebDriver driver)
        {
            Wait.WaitForClickable(driver, "XPath", "//div[@id='container']//a[@href='/TimeMaterial/Create']", 5);
            //2. Click on create a new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//div[@id='container']//a[@href='/TimeMaterial/Create']"));
            createNewButton.Click();
            //3.slect time from typecode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("/html//form[@id='TimeMaterialEditForm']//span[@role='listbox']//span[@class='k-input']"));
            typeCodeDropdown.Click();
            IWebElement timeOption = driver.FindElement(By.XPath("//ul[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();
            //Entering code in code text box
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("October2023");
            //Entering description into discription textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("October2023description");

            //Enter price into price per unit textbo
            IWebElement priceTextbox = driver.FindElement(By.XPath("/html//form[@id='TimeMaterialEditForm']/div/div[4]/div[@class='col-md-10']/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            // CLickon save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(4000);
            //Check if new record has been created successfully
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            /*[@id="tmsGrid"]/div[3]/table/tbody/tr[3]/td[1],this is Xpath for the last code enter but it will keep changing this x path says
             * html table table body, tr is row and td is data ie column, so by giving row as last(); we reacht o last row and 1st column*/

            if (newCode.Text == "October2023")
            {
                Console.WriteLine("New record has been created successfully");
            }
            else
            {
                Console.WriteLine("New record is not created successfully");
            }
        }
        public void Edit_TimeRecord(IWebDriver driver)
        {
            //editing the new record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            IWebElement editCodeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editCodeTextbox.Clear();
            IWebElement codeeditTextbox = driver.FindElement(By.Id("Code"));
            codeeditTextbox.SendKeys("November2023");
            IWebElement saveButtonEdit = driver.FindElement(By.Id("SaveButton"));
            saveButtonEdit.Click();
            Thread.Sleep(4000);
            //checking editing of record
            IWebElement goToLastPageEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageEdit.Click();
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "November2023")
            {
                Console.WriteLine("New record has been edited successfully");
            }
            else
            {
                Console.WriteLine("New record is not edited successfully");
            }
        }

        /*public void Delete_TimeRecord(IWebDriver driver)
        {
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            deleteButton.Click();
            IWebElement goToLastPageDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageDelete.Click();
            IWebElement newCodeDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCodeDelete.Text == "November2023")
            {
                Console.WriteLine("New record has not deleted successfully");
            }
            else
            {
                Console.WriteLine("New record is deleted successfully");
            }*/
        
    }

}


