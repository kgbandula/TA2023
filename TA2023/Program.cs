//20230222
//Open the ChromeBrowser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch TurnUp portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify username textbox and enter valid username
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
Thread.Sleep(1000);

//Identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//Check if user has successfully logged in
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));


if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully");
}
else
{ 
    Console.WriteLine("Login failed");
}

//20230223
//Create a new Time and Material


//Navigate to time and material
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));  
administrationDropdown.Click();

IWebElement timematerialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timematerialOption.Click();

//Click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

//select time option from typecode dropdown list
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodeDropdown.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();
Thread.Sleep(2000);

//input code into CodeTextbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("TA2023");
Thread.Sleep(2000);

//input description into descriptionTextBox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("TA2023");
Thread.Sleep(3000);

//input price into priceperunitTextbox
IWebElement PricePerUnitTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
PricePerUnitTextbox.SendKeys("75");

//Click on saveButton
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(5000);

//check if new time record has been created
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "TA2023")
{
    Console.WriteLine("New record created successfully");
}
else
{
    Console.WriteLine("New record has not been created");
}

//Edit and Delete functions

//Edit a time and material

//Click on Last Edit button
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();

//select material option from typecode dropdown list
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCodeDropdown.Click();
Thread.Sleep(2000);

IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
materialOption.Click();
Thread.Sleep(5000);

//Edit code txtbox
IWebElement codeTxtbox = driver.FindElement(By.Id("Code"));
codeTxtbox.Clear();
codeTxtbox.SendKeys("TA20230223");
Thread.Sleep(2000);

//edit description txtbox
IWebElement descriptionTxtbox = driver.FindElement(By.Id("Description"));
descriptionTxtbox.Clear();
descriptionTxtbox.SendKeys("TA20230223New");
Thread.Sleep(3000);

//Edit price per unit
IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricePerUnit.Clear();
pricePerUnit.SendKeys("80");
Thread.Sleep(3000);


//Click on saveButton
IWebElement saveButtn = driver.FindElement(By.Id("SaveButton"));
saveButtn.Click();
Thread.Sleep(3000);

//check if new edit material saved
IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastPageButton.Click();

IWebElement newEditCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[Last()]/td[1]"));


if (newEditCode.Text == "TA20230223")
{
    Console.WriteLine("Successfully Edited");
}
else
{
    Console.WriteLine("Record was not edited");
}


//Delete a time and material

//Find the last row that should be deleted
IWebElement deleteButton = driver.FindElement(By.XPath("///*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[7]/td[Last()]/a[2]"));
deleteButton.Click ():

//Navigate to pop up window





