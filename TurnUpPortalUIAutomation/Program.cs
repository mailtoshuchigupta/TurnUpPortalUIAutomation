
//PAckage used 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
//open chrome browser

   
        IWebDriver driver = new ChromeDriver(); /*telling sellenium that variable driver is the a chrome driver and through this driver  
                                         * we can access packages of selenium chrome */
        driver.Manage().Window.Maximize();
        //Launce TurnUp portal and Navigate to the website login page
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");  // through driver we are accessing navigate and gotourl methods
        Thread.Sleep(8000);
        //Identify the username textbox(elements,throughInspect and html port ) and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
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
        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully");
        }
        else
        {
            Console.WriteLine("User hasn't been logged in.");
        }
//Create a new time recrd
//1. navigate to time and materials module through adminastration drop down
IWebElement adminastrationOption =driver.FindElement(By.XPath("/html//div[@class='container']//ul[@class='nav navbar-nav']//a[@role='button']"));
adminastrationOption.Click();
IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html//div[@class='container']//ul[@class='nav navbar-nav']//ul[@role='menu']//a[@href='/TimeMaterial']"));
timeAndMaterial.Click();
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
 * html table table body, tr is row and td is data ie column, so by giving row as last(); we reacht o last row and 1st column

if (newCode.Text=="October2023")
{
    Console.WriteLine("New record has been created successfully");
}
else
{
    Console.WriteLine("New record is not created successfully");
}

//now I will push this code in gitHUb