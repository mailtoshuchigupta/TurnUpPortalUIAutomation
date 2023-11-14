
//PAckage used 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//open chrome browser

IWebDriver driver = new ChromeDriver(); /*telling sellenium that variable driver is the a chrome driver and through this driver  
                                         * we can access packages of selenium chrome */
driver.Manage().Window.Maximize();
//Launce TurnUp portal and Navigate to the website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");  // through driver we are accessing navigate and gotourl methods

//Identify the username textbox(elements,throughInspect and html port ) and enter valid username
IWebElement usernameTextbox =driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
// Preffered identifier is Id, xpath generate unique identifier for the element,,there are 2 types of xpath 1. Relative xpath 2.absolute/full xpath
//Identify the password textbox(elements,throughInspect and html port ) and enter valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
// Identify login button and click on the button
IWebElement loginButton = driver.FindElement(By.XPath("//section[@id='loginForm']/form[@role='form']//input[@value='Log in']"));
loginButton.Click();
//check if user logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User hasn't been logged in.");
}