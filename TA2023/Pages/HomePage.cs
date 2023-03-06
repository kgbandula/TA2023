using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2023.Pages
{
    public class HomePage
    {
        public void GotoTMPage(IWebDriver driver) 
        {
            //Navigate to time and material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]"));
            administrationDropdown.Click();

            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            timeMaterial.Click();
        }
    }
}
