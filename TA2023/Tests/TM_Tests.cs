//Open Chrome Browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TA2023.Pages;

//Open Chrome Browser
//IWebDriver driver (driver is ChromeDriver) = new ChromeDriver(@"F:\");
IWebDriver driver = new ChromeDriver(@"F:\");

//Login page object initialization and definition
//LoginPage(class=cs) loginpageOb(name given to loginpage) = new LoginPage(relate to class)();
LoginPage loginpageObj = new LoginPage();
loginpageObj.loginActions(driver);

//Homepage object initialization and definition
HomePage homepageObj = new HomePage();
homepageObj.GotoTMPage(driver);

//TM page object initialization and definition
TMPage tmpageObj = new TMPage();
tmpageObj.CreateTM(driver);

//Edit TM
tmpageObj.EditTM(driver);

//Delete
tmpageObj.DeleteTM(driver);



