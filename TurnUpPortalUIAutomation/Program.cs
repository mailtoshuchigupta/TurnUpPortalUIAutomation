
//PAckage used 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using TurnUpPortalUIAutomation.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser

        IWebDriver driver = new ChromeDriver(); /*telling sellenium that variable driver is the a chrome driver and through this driver  
                                         * we can access packages of selenium chrome */

        /* //check if user logged in successfully
         IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));*/

        // Login object initialization and definition
        Login loginObj = new Login();
        loginObj.LoginAction(driver);

        //Home page object intialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //TimeAndMAterial object intialization and definition
        TimeAndMaterial timeAndMaterialObj = new TimeAndMaterial();
        timeAndMaterialObj.create_TimeRecord(driver);

        //edit new code
        timeAndMaterialObj.Edit_TimeRecord(driver);

      /*  //delete new code
        timeAndMaterialObj.Delete_TimeRecord(driver); */
    }
}
/* if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User hasn't been logged in.");
}
//Create a new time recrd */




